using System;
using Newtonsoft.Json;

namespace XB.API.Client.Request
{
    public class ConfigureCommandWarpper : BaseRequest
    {
        /// <summary>
        /// 操作用户ID（平台操作用户）
        /// </summary>
        [JsonProperty("userId")]
        public String UserId { get; set; }

        /// <summary>
        /// 对应的箱子Code
        /// </summary>
        [JsonProperty("boxCode")]
        public String BoxCode { get; set; }

        /// <summary>
        /// gui指令类型
        /// 1，物箱信息同步；2，设置收件快递员组；3，设置投件快递员组；4，设置维护员；5，查询物箱状态；6，查询外围设备状态；7，查询箱子状态；8，开箱；
        /// </summary>
        [JsonProperty("guiOperationType")]
        public int GuiOperationType { get; set; }

    }
}