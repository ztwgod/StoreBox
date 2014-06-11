using Newtonsoft.Json;
using System;

namespace XB.API.Domain
{
    /// <summary>
    /// 箱子详情
    /// </summary>
    public class BoxInfo
    {
        /// <summary>
        /// 箱子CODE
        /// （全系统唯一，格式：[柜子Code][箱子序列（三位）]，例：3101150002032001003）
        /// </summary>
        [JsonProperty("boxCode")]
        public String BoxCode { get; set; }

        /// <summary>
        /// 箱子序号
        /// 【必须三位数字，不足三位补零，从1开始，如：003】
        /// </summary>
        [JsonProperty("boxIndex")]
        public String BoxIndex { get; set; }

        /// <summary>
        /// 资产编号
        /// </summary>
        [JsonProperty("assetSn")]
        public String AssetSn { get; set; }

        /// <summary>
        /// 类型、规格
        /// 【1，超大,2，大,3，中,4，小,5，超小】
        /// </summary>
        [JsonProperty("boxType")]
        public int BoxType { get; set; }

        /// <summary>
        /// 存货状态
        /// 【1,空闲;2,占用;3,占用超时;4,弃件（占用超期）】
        /// </summary>
        [JsonProperty("boxLoadStatus")]
        public int BoxLoadStatus { get; set; }

        /// <summary>
        /// 运行状态：
        /// 1，空闲、2，占用、3，占用超时、4，弃件（占用超期）、5，开启、6，故障、7，租用、8，预留、9，闭塞、10，未关闭、11，被破坏、12，维修
        /// </summary>
        [JsonProperty("boxRunStatus")]
        public int BoxRunStatus { get; set; }
    }
}