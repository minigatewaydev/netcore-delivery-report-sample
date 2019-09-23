using System;
using Newtonsoft.Json;

namespace Models
{

    public class DeliveryReport
    {
        public const string GW_TO = "gw-to";
        public const string GW_FROM = "gw-from";
        public const string GW_DLR_STATUS = "gw-dlr-status";
        public const string GW_ERROR_CODE = "gw-error-code";
        public const string GW_MSGID = "gw-msgid";

        [JsonProperty(GW_FROM)]
        public string From { get; set; }        
        [JsonProperty(GW_TO)]
        public string To { get; set; }
        [JsonProperty(GW_DLR_STATUS)]
        public string Status { get; set; }
        [JsonProperty(GW_ERROR_CODE)]
        public string ErrorCode { get; set; }
        [JsonProperty(GW_MSGID)]
        public string MsgId { get; set; }
    }
}