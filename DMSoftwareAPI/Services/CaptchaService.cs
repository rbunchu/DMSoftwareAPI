using DMSoftwareAPI.Models;
using DMSoftwareAPI.Repositories;
using DMSoftwareAPI.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DMSoftwareAPI.Services
{
    public class CaptchaService : ICaptchaService
    {
        private ReCaptchaSettings _recaptchaSettings;

        public CaptchaService(IConfiguration configuration)
        {
            this._recaptchaSettings = new ReCaptchaSettings();
            configuration.GetSection(ReCaptchaSettings.ReCaptcha).Bind(this._recaptchaSettings);
        }

        public async Task<CaptchaResponse> Validate(string captchaToken)
        {
            using(var httpClient = new HttpClient())
            {
                var captchaRequest = new CaptchaRequest()
                {
                    Secret = this._recaptchaSettings.SecretKey,
                    Response = captchaToken
                };

                string content = $"secret={captchaRequest.Secret}&response={captchaRequest.Response}";

                HttpResponseMessage result = await httpClient.PostAsync("https://www.google.com/recaptcha/api/siteverify", new StringContent(content, Encoding.UTF8, "application/x-www-form-urlencoded"));

                string body = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<CaptchaResponse>(body);
            }
        }
    }
}
