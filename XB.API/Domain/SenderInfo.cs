using System;
using Newtonsoft.Json;

namespace XB.API.Domain
{
    /// <summary>
    /// 发件人信息
    /// </summary>
    public class SenderInfo
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        /// <summary>
        /// 移动电话
        /// </summary>
        [JsonProperty("mobilePhone")]
        public String MobilePhone { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("address")]
        public String Address { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        [JsonProperty("email")]
        public String Email { get; set; }
    }
}