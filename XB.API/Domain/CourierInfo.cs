using System;
using Newtonsoft.Json;

namespace XB.API.Domain
{
    public class CourierInfo
    {
        /// <summary>
        /// 快递员编号
        /// </summary>
        [JsonProperty("courierId")]
        public String CourierId { get; set; }

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
        /// 所属公司Name
        /// </summary>
        [JsonProperty("excoName")]
        public String ExcoName { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        [JsonProperty("email")]
        public String Email { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
    }
}
