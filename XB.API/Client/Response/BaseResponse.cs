using System;
using Newtonsoft.Json;

namespace XB.API.Client.Response
{
    [JsonObject(Title = "BaseResponse")]
    public class BaseResponse
    {
        [JsonProperty("sequenceNumber")]
        public long SequenceNumber { get; set; }// 序列号

        [JsonProperty("resultStatus")]
        public int ResultStatus { get; set; }// 1：成功 ；0：失败

        [JsonProperty("errorMsg")]
        public String ErrorMsg { get; set; } // 错误信息(可选，调用接口出错，需要提示错误)

        [JsonProperty("storageStationId")]
        public String StorageStationId { get; set; }// 物箱编码

        [JsonProperty("guiSequenceNumber")]
        public String GuiSequenceNumber { get; set; } // 指令序列号，仅GUI命令触发的同步需要此序列号(整个服务器全局唯一) 
    }
}