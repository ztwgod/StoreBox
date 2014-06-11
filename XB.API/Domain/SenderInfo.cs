using System;
using Newtonsoft.Json;

namespace XB.API.Domain
{
    /// <summary>
    /// ��������Ϣ
    /// </summary>
    public class SenderInfo
    {
        /// <summary>
        /// ����
        /// </summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        /// <summary>
        /// �ƶ��绰
        /// </summary>
        [JsonProperty("mobilePhone")]
        public String MobilePhone { get; set; }

        /// <summary>
        /// ��ַ
        /// </summary>
        [JsonProperty("address")]
        public String Address { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [JsonProperty("email")]
        public String Email { get; set; }
    }
}