using Newtonsoft.Json;
using System;

namespace XB.API.Domain
{
    /// <summary>
    /// 外围设备POCO类
    /// </summary>
    public class Peripheral
    {
        public Peripheral()
        {
            this.StartTime = DateTime.MinValue.ToString("yyyy-MM-dd HH:mm:ss");
            this.StopTime = DateTime.MaxValue.ToString("yyyy-MM-dd HH:mm:ss");
        }


        /// <summary>
        /// 设备CODE
        /// 需要保证全系统唯一，格式：[物箱][设备]，例：31011500020320002，后面设备序号固定三位数
        /// </summary>
        [JsonProperty("peripheralCode")]
        public String PeripheralCode { get; set; }

        /// <summary>
        /// 设备简称
        /// 【主控计算机、读卡器、二维码识别器、红外识别...】
        /// </summary>
        [JsonProperty("peripheralAbbName")]
        public String PeripheralAbbName { get; set; }

        /// <summary>
        /// 资产编号
        /// </summary>
        [JsonProperty("assetSn")]
        public String AssetSn { get; set; }

        /// <summary>
        /// 设备类型
        /// 1，工程计算机；2，读卡器；3，二维码识别器；4，红外识别；5，钱币识别器；6，摄像头；7，触摸屏；8，报警器】
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("version")]
        public String Version { get; set; }

        /// <summary>
        /// 启用时间
        /// </summary>
        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// 停用时间
        /// </summary>
        [JsonProperty("stopTime")]
        public string StopTime { get; set; }

        /// <summary>
        /// 运行状态
        /// 【1,正常;2,故障;3,被破坏;4,维修】
        /// </summary>
        [JsonProperty("runStatus")]
        public int RunStatus { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        public String Memo { get; set; }
    }
}