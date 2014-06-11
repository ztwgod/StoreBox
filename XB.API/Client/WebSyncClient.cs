using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Newtonsoft.Json.Linq;
using XB.API.Log;

namespace XB.API.Client
{
    /// <summary>
    /// 处理长连接操作的类
    /// </summary>
    public class WebSyncClient
    {
        private ICommandDispatcher dispatcher;

        public WebSyncClient(ICommandDispatcher dispatcher)
        {
            this.dispatcher = dispatcher;
        }

        public void Connect(string ssCode)
        {
            while (true)
            {
                try
                {
                    var cometSrvUrl = ConfigurationManager.AppSettings["plat_url_base"] + "cometServlet?ssCode=" + ssCode;
                    var wreq = (HttpWebRequest)WebRequest.Create(cometSrvUrl);
                    wreq.Method = "POST";
                    var wresp = wreq.GetResponse();
                    var ret = new StreamReader(wresp.GetResponseStream()).ReadToEnd();

                    // 处理消息
                    var jobj = JObject.Parse(ret);
                    var cmdType = jobj.Properties().First().Name;
                    var cmdBody = jobj[cmdType].ToString();

                    var logId = Guid.NewGuid().ToString();
                    SqlLog.WriteCommand(logId, cmdType, cmdBody, string.Empty);

                    dispatcher.DispatchMessage(logId, cmdType, cmdBody);
                    // SqlLog.Write();
                    // SqlLog.WriteCommand();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
