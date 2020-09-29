using DMSoftwareAPI.Models;
using DMSoftwareAPI.Repositories.Interfaces;
using DMSoftwareAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DMSoftwareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private ICaptchaService _captchaService;
        private IContactRepository _contactRepository;


        public ContactController(ICaptchaService captchaService, IContactRepository contactRepository)
        {
            this._captchaService = captchaService;
            this._contactRepository = contactRepository;
        }

        // POST api/values
        [HttpPost]
        public async Task<ApiResponse> Post([FromBody] ContactFormData value)
        {
            CaptchaResponse response = await _captchaService.Validate(value.CaptchaToken);
            if(!response.Success)
            {
                return new ApiResponse() { StatusCode = StatusCodes.Status401Unauthorized, ErrorMessage = "Application Error. Please try again later." };
            }

            if(!ModelState.IsValid)
            {
                return new ApiResponse() { StatusCode = StatusCodes.Status400BadRequest, ErrorMessage = "Form errors. Please input correct data" };
            }

            //Save to mongoDb
            this._contactRepository.AddContact(new Contact()
            {
                FullName = value.FullName,
                Email = value.EmailAddress,
                Content = value.Message,
                Answered = false,
                Submitted = DateTime.Now
            });

            return new ApiResponse() { StatusCode = StatusCodes.Status200OK };
        }
    }
}
