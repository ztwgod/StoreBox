using System;
using Newtonsoft.Json;

namespace XB.API.Client.Request
{
    public class BaseRequest
    {
        /// <summary>
        /// 序列号
        /// </summary>
        [JsonProperty("sequenceNumber")]
        public long SequenceNumber;

        /// <summary>
        /// 物箱GUI交易号
        /// </summary>
        [JsonProperty("guiSequenceNumber")]
        public String GuiSequenceNumber;

        /// <summary>
        /// 物箱编码
        /// </summary>
        [JsonProperty("storageStationId")]
        public String StorageStationId;
    }
}
