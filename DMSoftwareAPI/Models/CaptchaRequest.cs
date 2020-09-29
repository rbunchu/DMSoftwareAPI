using Newtonsoft.Json;

namespace DMSoftwareAPI.Models
{
    public class CaptchaRequest
    {
        [JsonProperty("secret")]
        public string Secret { get; set; }
        [JsonProperty("response")]
        public string Response { get; set; }
        [JsonProperty("remoteip")]
        public string RemoteIp { get; set; }
    }
}
