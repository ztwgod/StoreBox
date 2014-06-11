using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XB.API.Client.Response;

namespace XB.API.Client.Request
{
    public class DepositUnpackInfoResult : IRequest<DepositUnpackInfoCallbackResponse>
    {
        [JsonProperty("guiSequenceNumber")]
        public string GuiSequenceNumber { get; set; }

        [JsonProperty("resultStatus")]
        public int ResultStatus { get; set; }

        [JsonProperty("errorMsg")]
        public string ErrorMsg { get; set; }

        public string GetApplyCode()
        {
            return "3";
        }

        public string GetServiceUrl()
        {
            return "/XBPhysicalBoxServlet";
        }
    }
}
