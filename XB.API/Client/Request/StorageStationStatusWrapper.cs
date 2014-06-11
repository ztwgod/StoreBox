using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using XB.API.Client.Response;

namespace XB.API.Client.Request
{
    public class StorageStationStatusWrapper : BaseRequest, IRequest<StorageStationStatusResult>
    {
        [JsonProperty("storageStationStatus")]
        public int StorageStationStatus { get; set; }

        [JsonProperty("clientUploadTime")]
        public String ClientUploadTime { get; set; }

        /// <summary>
        /// 外围设备运行状态列表(存放内容 外围设备Code,状态)
        /// </summary>
        [JsonProperty("peripheralRunStatus")]
        public PeripheralRunStatus PeripheralRunStatus { get; set; }

        /// <summary>
        /// 柜子运行状态列表(存放内容 柜子Code,状态)
        /// </summary>
        [JsonProperty("cabinetContainerStatus")]
        public CabinetContainerStatus CabinetContainerStatus { get; set; }

        /// <summary>
        /// 箱子存货状态【1,空闲;2,占用;3,占用超时;4,占用超期】
        /// </summary>
        [JsonProperty("boxLoadStatus")]
        public BoxLoadStatus BoxLoadStatus { get; set; }

        /// <summary>
        /// 箱子运行状态：空闲、占用、占用超时、占用超期、开启、故障、租用、预留、闭塞、未关闭、被破坏、维修
        /// </summary>
        [JsonProperty("boxRunStatus")]
        public BoxRunStatus BoxRunStatus { get; set; }

        public string GetServiceUrl()
        {
            return "/XBPhysicalBoxServlet";
        }

        public string GetApplyCode()
        {
            return "7";
        }
    }
    #region 
    public class PeripheralRunStatus
    {
        public PeripheralRunStatus(List<DeviceStatus> status)
        {
            this.DeviceStatus = status;
        }

        [JsonProperty("IDeviceStatus")]
        public List<DeviceStatus> DeviceStatus { get; set; }
    }

    public class CabinetContainerStatus
    {
        public CabinetContainerStatus(List<DeviceStatus> status)
        {
            this.DeviceStatus = status;
        }

        [JsonProperty("IDeviceStatus")]
        public List<DeviceStatus> DeviceStatus { get; set; }
    }

    public class BoxLoadStatus
    {
        public BoxLoadStatus(List<DeviceStatus> status)
        {
            this.DeviceStatus = status;
        }

        [JsonProperty("IDeviceStatus")]
        public List<DeviceStatus> DeviceStatus { get; set; }
    }

    public class BoxRunStatus
    {
        public BoxRunStatus(List<DeviceStatus> status)
        {
            this.DeviceStatus = status;
        }

        [JsonProperty("IDeviceStatus")]
        public List<DeviceStatus> DeviceStatus { get; set; }
    }
    #endregion

    [JsonObject(Title = "IDeviceStatus")]
    public class DeviceStatus
    {
        /// <summary>
        /// 设备Code（外围设备Code，柜子Code，箱子Code）
        /// </summary>
        [JsonProperty("deviceCode")]
        public String DeviceCode { get; set; }

        /// <summary>
        /// 设备状态
        /// </summary>
        [JsonProperty("deviceStatus")]
        public int Status { get; set; }
    }
}