using Newtonsoft.Json;
using XB.API.Client.Response;
using XB.API.Domain;

namespace XB.API.Client.Request
{
    /// <summary>
    /// 交易确认信息
    /// </summary>
    [JsonObject(Title = "TransactionWrapper")]
    public class TransactionWrapper : IRequest<TransactionResult>
    {
        /// <summary>
        /// 序列号
        /// (预留，暂不使用)
        /// </summary>
        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }

        /// <summary>
        /// 交易动作类型
        /// 1，成功：寄件人寄件；2，成功：快递员取件；3，成功：快递员投件；4，成功：收件人收件；5，成功：寄存人寄件；6，成功：寄存人取件；7，无空箱：寄件人寄件；8，无空
        /// </summary>
        [JsonProperty("transActionType")]
        public int TransActionType { get; set; }

        /// <summary>
        /// 物箱编码
        /// 编号规则：【区域+地点+物箱组+物箱】例：31011500020320（310115为上海市浦东新区的Code，0002为浦东新区某一地点A，03
        /// </summary>
        [JsonProperty("storageStationId")]
        public string StorageStationId { get; set; }

        /// <summary>
        /// 操作时间 
        /// （格式：yyyy-MM-dd HH24:mm:ss）
        /// </summary>
        [JsonProperty("clientTime")]
        public string ClientTime { get; set; }

        /// <summary>
        /// 上传提交时间 
        /// （格式：yyyy-MM-dd HH24:mm:ss）
        /// </summary>
        [JsonProperty("clientUploadTime")]
        public string ClientUploadTime { get; set; }

        [JsonProperty("transactionInfo")]
        public TransactionInfo TransactionInfo { get; set; }

        public string GetServiceUrl()
        {
            return "/XBPhysicalBoxServlet";
        }

        public string GetApplyCode()
        {
            return "2";
        }

    }
}