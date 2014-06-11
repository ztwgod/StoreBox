using Newtonsoft.Json;
using XB.API.Client.Response;

namespace XB.API.Client.Request
{
    public class SynchCourierWrapper : BaseRequest, IRequest<SynchCourierResult>
    {
        /// <summary>
        /// 快递员执行权限（0,取件/寄件快递员；1,取件快递员；2,派件快递员）
        /// </summary>
        [JsonProperty("exePermissionType")]
        public int ExePermissionType { get; set; }

        public string GetServiceUrl()
        {
            return "/XBPhysicalBoxServlet";
        }

        public string GetApplyCode()
        {
            return "8";
        }
    }
}