using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace XB.API.Client.Request
{
    public class DepositUnpackInfoWarpper
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userMobilePhone")]
        public string UserMobilePhone { get; set; }

        [JsonProperty("guiSequenceNumber")]
        public string GuiSequenceNumber { get; set; }

        [JsonProperty("storageStationId")]
        public string StorageStationId { get; set; }

        [JsonProperty("boxCode")]
        public string BoxCode { get; set; }

        [JsonProperty("randomNum")]
        public string RandomNum { get; set; }

        [JsonProperty("delayTime")]
        public long DelayTime { get; set; }
    }
}
