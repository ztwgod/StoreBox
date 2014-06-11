using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XB.API.Domain
{
    /// <summary>
    /// 物箱详情POCO类
    /// </summary>
    public class StorageStationInfo
    {
        public StorageStationInfo()
        {
           // Peripherals = new List<Peripheral>();
           // CabinetContainers = new List<CabinetContainer>();
        }

        /// <summary>
        /// 物箱类型
        /// </summary>
        [JsonProperty("storageStationType")]
        public String StorageStationType { get; set; }

        /// <summary>
        /// 物箱版本
        /// </summary>
        [JsonProperty("storageStationVersion")]
        public String StorageStationVersion { get; set; }

        /// <summary>
        /// 资产编号
        /// </summary>
        [JsonProperty("assetSn")]
        public String AssetSn { get; set; }

        /// <summary>
        /// 物箱状态
        /// [1,正常;2,无空箱;3,负荷高;4,系统忙;5,故障恢复;6,维护中;7,断链;8,闭塞;9,重启]
        /// </summary>
        [JsonProperty("storageStationStatus")]
        public int StorageStationStatus { get; set; }

        /// <summary>
        /// 数据卡号
        /// </summary>
        [JsonProperty("dataCard")]
        public String DataCard { get; set; }

        /// <summary>
        /// 物箱对应IP地址
        /// 若有IP地址则传递（目前需求信元定义中无ＩＰ定义）
        /// </summary>
        [JsonProperty("ipAddress")]
        public String IpAddress { get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("port")]
        public String Port { get; set; }

        /// <summary>
        /// PHY链路类型
        /// （GPRS、WCDMA、WIFI、GE/FE）
        /// </summary>
        [JsonProperty("phyLinkType")]
        public int PhyLinkType { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// 可用箱子
        /// </summary>
        [JsonProperty("availableBoxNum")]
        public int AvailableBoxNum { get; set; }

        /// <summary>
        /// 安装时间
        /// date format: yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("installDate")]
        public String InstallDate { get; set; }

        /// <summary>
        /// 控制面板所在位置
        /// [1,2,3]
        /// </summary>
        [JsonProperty("controlCabinetLocation")]
        public int ControlCabinetLocation { get; set; }

        /// <summary>
        /// 外围设备列表
        /// </summary>
        [JsonProperty("peripherals")]
        public Peripherals Peripherals { get; set; }
        // public IList<Peripheral> Peripherals { get; set; }

        /// <summary>
        /// 物箱柜子
        /// </summary>
        [JsonProperty("cabinetContainers")]
        public CabinetContainers CabinetContainers { get; set; }
        //[JsonProperty("cabinetContainers")]
        //public IList<CabinetContainer> CabinetContainers { get; set; } 
    }

    public class Peripherals
    {
        public Peripherals(IList<Peripheral> peripheralList)
        {
            this.IPeripheral = peripheralList;
        }

        [JsonProperty("IPeripheral")]
        public IList<Peripheral> IPeripheral { get; set; }
    }

    public class CabinetContainers
    {
        public CabinetContainers(IList<CabinetContainer> cabinetContainers)
        {
            this.ICabinetContainer = cabinetContainers;
        }

        [JsonProperty("ICabinetContainer")]
        public IList<CabinetContainer> ICabinetContainer { get; set; }
    }
}