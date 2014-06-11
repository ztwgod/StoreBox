using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace XB.API.Domain
{
    /// <summary>
    /// 物箱柜子的POCO类
    /// </summary>
    public class CabinetContainer
    {
        public CabinetContainer()
        {
            // BoxInfos = new List<BoxInfo>();
        }

        /// <summary>
        /// 柜子CODE
        /// 需全系统唯一，格式：[物箱Code][柜子序列（两位）]，例：3101150002032001
        /// </summary>
        [JsonProperty("cabinetCode")]
        public String CabinetCode { get; set; }

        /// <summary>
        /// 柜子序号 
        /// 必须两位数字，不足两位补零，对应code，柜子所在序号：01
        /// </summary>
        [JsonProperty("cabinetIndex")]
        public String CabinetIndex { get; set; }

        /// <summary>
        /// 柜子类型
        /// 【1，A型；2、B型；】
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("version")]
        public String Version { get; set; }

        /// <summary>
        /// 资产编号
        /// </summary>
        [JsonProperty("assetSn")]
        public String AssetSn { get; set; }

        /// <summary>
        /// 宽度，横排箱子数
        /// </summary>
        [JsonProperty("cabinetWidth")]
        public int CabinetWidth { get; set; }

        /// <summary>
        /// 高度，竖排箱子数
        /// </summary>
        [JsonProperty("cabinetHeight")]
        public int CabinetHeight { get; set; }

        /// <summary>
        /// 柜子包含箱子数
        /// </summary>
        [JsonProperty("boxNumber")]
        public int BoxNumber { get; set; }

        /// <summary>
        /// 状态
        /// 【1,正常;2,无空箱;3,负荷高;4,系统忙;5,故障恢复;6,维护中;7,断链;8,闭塞;9,重启】
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// 箱子列表
        /// </summary>
        [JsonProperty("boxInfos")]
        public BoxInfos BoxInfos { get; set; }
    }

    public class BoxInfos
    {
        public BoxInfos(IList<BoxInfo> boxInfos)
        {
            this.IBoxInfo = boxInfos;
        }

        public IList<BoxInfo> IBoxInfo { get; set; }
    }
}