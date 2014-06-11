using System;
using Newtonsoft.Json;

namespace XB.API.Client.Response
{
    public class TransactionResult : BaseResponse, IResponse
    {
        /// <summary>
        /// 交易ID [物箱端的ID，用于与服务器中的数据对应]
        /// </summary>
        [JsonProperty("transactionID")]
        public String TransactionID { get; set; }

        /// <summary>
        /// 物箱编码
        /// </summary>
        [JsonProperty("storageStationId")]
        public String StorageStationId { get; set; }

        /// <summary>
        /// 箱子编码
        /// </summary>
        [JsonProperty("boxCode")]
        public String Boxcode { get; set; }

        /// <summary>
        /// 起步价
        /// </summary>
        [JsonProperty("pricingStarts")]
        public double PricingStarts { get; set; }

        /// <summary>
        /// 免费时长
        /// </summary>
        [JsonProperty("freeTime")]
        public int FreeTime { get; set; }

        /// <summary>
        /// 超时后单价
        /// </summary>
        [JsonProperty("overTimeUnitPrice")]
        public double OverTimeUnitPrice { get; set; }

        /// <summary>
        /// 最高限额
        /// </summary>
        [JsonProperty("maximumPrice")]
        public double MaximumPrice { get; set; }

        /// <summary>
        /// 超时时长 
        /// </summary>
        [JsonProperty("overdueTime")]
        public int OverdueTime { get; set; }
    }
}