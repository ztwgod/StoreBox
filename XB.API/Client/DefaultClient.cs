using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using XB.API.Client.Request;
using XB.API.Client.Response;
using XB.API.Log;

namespace XB.API.Client
{
    public class DefaultClient : IClient
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(DefaultClient));

        #region JSON序列化和反序列化封装
        /// <summary>
        /// JSON反序列化方法
        /// 从根节点开始解析
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        protected T Deserialize<T>(String jsonStr)
        {
            try
            {
                var jObj = JObject.Parse(jsonStr);
                return jObj.Properties().First().Value.ToObject<T>();
            }
            catch (Exception e)
            {
                throw new ApplicationException("deserialize failed", e);
            }
        }

        /// <summary>
        /// JSON序列化方法封装
        /// 增加根节点内容
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
        protected String Serialize<T>(T o)
        {

            // var attr = o.GetType().GetCustomAttribute(typeof(JsonObjectAttribute)) as JsonObjectAttribute;
            var type = o.GetType();
            string title;
            if (type.IsDefined(typeof(JsonObjectAttribute), false))
            {
                object[] attrs = type.GetCustomAttributes(typeof(JsonObjectAttribute), true);
                var jsonObjectAttr = attrs[0] as JsonObjectAttribute;
                title = jsonObjectAttr.Title;
            }
            else
            {
                title = type.Name.Substring(type.Name.LastIndexOf('.') + 1);
            }

            var jv = JValue.FromObject(o);

            return new JObject(new JProperty(title, jv)).ToString(Formatting.None, null);
        }
        #endregion

        public T Execute<T>(IRequest<T> request) where T : BaseResponse
        {
            // get service url
            var url = ConfigurationManager.AppSettings["plat_url_base"];
            if (string.IsNullOrEmpty(url))
            {
                Log.Error("configuration with name 'plat_url_base' not found");
                throw new ApplicationException("configuration with name 'plat_url_base' not found");
            }
            url = url + request.GetServiceUrl();

            // serialze request message
            var reqJson = Serialize(request);

            var reqBody = string.Format("applyCode={0}&MSG={1}", request.GetApplyCode(), HttpUtility.UrlEncode(reqJson));
            // create a guid for logging
            string logId = Guid.NewGuid().ToString("D");
            // write request message in database
            SqlLog.Write(logId, request.GetType().Name, request.GetApplyCode(), reqJson, string.Empty, ResultCode.UNKNOWN, string.Empty);

            // setting up HttpWebRequest
            var webRequest = (HttpWebRequest)WebRequest.Create(url);
            //webRequest.Proxy = new WebProxy("127.0.0.1", 8888);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";

            string respStr = string.Empty;
            try
            {
                // post message to platform
                using (var rs = webRequest.GetRequestStream())
                {

                    var logMessage = string.Format("POST {0} to {1}\r\nApply Code:{2}\r\n{3}",
                        request.GetType(),
                        request.GetServiceUrl(),
                        request.GetApplyCode(),
                        reqJson);
                    Log.Info(logMessage);

                    var reqBytes = Encoding.Default.GetBytes(reqBody);
                    rs.Write(reqBytes, 0, reqBytes.Length);
                    rs.Close();
                }



                string resultCode = ResultCode.UNKNOWN;
                string resultMessage = string.Empty;
                T ret = default(T);

                // get response
                using (var resp = (HttpWebResponse)webRequest.GetResponse())
                {
                    var respStream = resp.GetResponseStream();

                    if (respStream == null)
                    {
                        throw new WebException("GetResponseStream returned null");
                    }

                    var streamReader = new StreamReader(respStream);
                    respStr = streamReader.ReadToEnd();
                    ret = Deserialize<T>(respStr);

                    if (ret.ResultStatus != 1)
                    {
                        resultCode = ResultCode.PLATFORM_FAILED;
                        resultMessage = ret.ErrorMsg;
                    }
                    else
                    {
                        resultCode = ResultCode.OK;
                    }
                    SqlLog.Update(logId, respStr, resultCode, resultMessage);
                    return ret;
                }
            }
            catch (Exception e)
            {
                SqlLog.Update(logId, respStr, ResultCode.EXCEPTION, e.Message);
                // throw;
                // return default(T);
                T ret = Activator.CreateInstance<T>();
                ret.ResultStatus = -1;
                ret.ErrorMsg = e.Message;
                return ret;
            }

        }
    }
}