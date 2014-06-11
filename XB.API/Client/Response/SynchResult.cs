using Newtonsoft.Json;

namespace XB.API.Client.Response
{
    public class SynchResult : BaseResponse, IResponse
    {
        /// <summary>
        /// 同步状态: 
        /// 1,注册成功；2,失败、配置错误；3,失败、系统忙；4,失败、操作维护；5,同步成功；6,失败；7,拒绝同步
        /// </summary>
        [JsonProperty("synchStatus")]
        public int SynchStatus { get; set; }
    }
}