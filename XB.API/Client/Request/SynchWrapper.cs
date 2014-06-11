using Newtonsoft.Json;
using XB.API.Client.Response;
using XB.API.Domain;

namespace XB.API.Client.Request
{
    /// <summary>
    /// 物箱信息注册同步【物箱 ---> 平台】
    /// </summary>
    public class SynchWrapper : IRequest<SynchResult>
    {
        public SynchWrapper()
        {
            StorageStationInfo = new StorageStationInfo();
        }
        /// <summary>
        /// 同步类型  
        /// 1，注册、新建；2，注册、故障恢复；3，注册、重启；4，注册、其他原因；5，同步、周期；6，同步、派件；7，同步、取件；8，同步、故障
        /// </summary>
        [JsonProperty("synchType")]
        public int SynchType { get; set; }

        /// <summary>
        /// 序列号
        /// 预留，暂不使用
        /// </summary>
        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }

        /// <summary>
        /// 指令序列号
        /// 仅GUI命令触发的同步需要此序列号(整个服务器全局唯一，由服务器端创建发起，物箱端负责转发)
        /// </summary>
        [JsonProperty("guiSequenceNumber")]
        public int GuiSequenceNumber { get; set; }

        /// <summary>
        /// 物箱编码 
        /// 编号规则：【区域+地点+物箱组+物箱>】
        /// 例：31011500020320（310115为上海市浦东新区的Code，0002为浦东新区某一地点A，03为某一地点区域物箱组，20为某一物箱组中的某一个物箱）
        /// </summary>
        [JsonProperty("storageStationId")]
        public string StorageStationId { get; set; }


        /// <summary>
        /// 操作时间
        /// date format: yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }

        /// <summary>
        /// 物箱详情
        /// </summary>
        [JsonProperty("storageStation")]
        public StorageStationInfo StorageStationInfo { get; set; }


        public string GetServiceUrl()
        {
            return "/XBPhysicalBoxServlet";
        }

        public string GetApplyCode()
        {
            return "1";
        }
    }
}