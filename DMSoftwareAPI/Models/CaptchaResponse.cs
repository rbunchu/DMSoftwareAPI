using Newtonsoft.Json;
using System;

namespace DMSoftwareAPI.Models
{
    public class CaptchaResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("challenge_ts")]
        public DateTime ChallengeDateTime { get; set; }
        [JsonProperty("apk_package_name")]
        public string ApplicationPackageName { get; set; }
        [JsonProperty("error-codes")]
        public string[] Errors { get; set; }
    }
}
