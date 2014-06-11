using Newtonsoft.Json;

namespace XB.API.Domain
{
    /// <summary>
    /// 交易信息POCO类
    /// </summary>
    public class TransactionInfo
    {
        /// <summary>
        /// 交易ID
        /// [物箱端的交易ID，物箱端全局唯一，需要有一定规则，在平台此ID用作订单号处理]
        /// </summary>
        [JsonProperty("transactionID")]
        public string TransactionID { get; set; }

        /// <summary>
        /// 箱子编码（全系统唯一，格式：柜子Code+箱子序列（三位），例：3101150002032001003）
        /// </summary>
        [JsonProperty("boxCode")]
        public string BoxCode { get; set; }

        /// <summary>
        /// 电商供应商代码
        /// </summary>
        [JsonProperty("supplierId")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 快递供应商代码
        /// （同步快递员信息时，会同步下来）
        /// </summary>
        [JsonProperty("expressDeliveryId")]
        public string ExpressDeliveryId { get; set; }

        /// <summary>
        /// 运单号
        /// （快递单号）
        /// </summary>
        [JsonProperty("expressCode")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 快件描述信息
        /// </summary>
        [JsonProperty("expressDescription")]
        public string ExpressDescription { get; set; }

        /// <summary>
        /// 默认存放时长
        /// （单位：min，默认用户取件时长约定为6小时，寄存时长约定为6小时，此期间免费）
        /// </summary>
        [JsonProperty("storageTime")]
        public int StorageTime { get; set; }

        /// <summary>
        /// 逾期时长
        /// [单位：min]
        /// </summary>
        [JsonProperty("pastDueTime")]
        public int PastDueTime { get; set; }

        /// <summary>
        /// 本次交易涉及总金额
        ///（包含本次交易动作涉及金额）
        /// </summary>
        [JsonProperty("totalAmount")]
        public double TotalAmount { get; set; }

        /// <summary>
        /// 支付款项类型
        /// [1，正常支付；2，逾期支付；3，退还金额]
        /// </summary>
        [JsonProperty("payType")]
        public int PayType { get; set; }

        /// <summary>
        /// 支付方式
        ///（1，投币；2，平台支付）
        /// </summary>
        [JsonProperty("payMode")]
        public int PayMode { get; set; }

        /// <summary>
        /// 优惠劵ID
        ///【目前只支持一种优惠劵多张累计】（优惠劵只用于APP取件，APP取件过程中，会将使用的优惠劵ID下发）
        /// </summary>
        [JsonProperty("voucherId")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 优惠劵数量
        /// </summary>
        [JsonProperty("voucherTotal")]
        public int VoucherTotal { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [JsonProperty("payPrice")]
        public double PayPrice { get; set; }

        /// <summary>
        /// 取件密码
        /// </summary>
        [JsonProperty("pickupPassword")]
        public string PickupPassword { get; set; }

        /// <summary>
        /// 物品是否符合标准资费
        /// [快递员取件时使用]（1，符合；2，不符合）
        /// </summary>
        [JsonProperty("isStandardsCompliant")]
        public int IsStandardsCompliant { get; set; }

        /// <summary>
        /// 不符合标准的原因
        /// </summary>
        [JsonProperty("notStandardsCompliantCause")]
        public string NotStandardsCompliantCause { get; set; }

        /// <summary>
        /// 尺寸类型
        /// （1,超大/2,大/3,中/4,小/5,超小）
        /// </summary>
        [JsonProperty("expressSizeType")]
        public int ExpressSizeType { get; set; }

        /// <summary>
        /// 发件人信息
        /// </summary>
        [JsonProperty("senderInfo")]
        public SenderInfo SenderInfo { get; set; }

        [JsonProperty("addresseeInfo")]
        public AddresseeInfo AddresseeInfo { get; set; }

        [JsonProperty("courierInfo")]
        public CourierInfo CourierInfo { get; set; }
    }
}