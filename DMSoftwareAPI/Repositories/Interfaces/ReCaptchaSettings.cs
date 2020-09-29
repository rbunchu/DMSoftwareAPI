using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMSoftwareAPI.Repositories
{
    public class ReCaptchaSettings
    {
        public const string ReCaptcha = "ReCaptcha";

        public string SecretKey { get; set; }
        public string SiteKey { get; set; }
    }
}
