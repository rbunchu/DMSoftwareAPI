using DMSoftwareAPI.Models;
using System.Threading.Tasks;

namespace DMSoftwareAPI.Services.Interfaces
{
    public interface ICaptchaService
    {
        Task<CaptchaResponse> Validate(string captchaToken);
    }
}
