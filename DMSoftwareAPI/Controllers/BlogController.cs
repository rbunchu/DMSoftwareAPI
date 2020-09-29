using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMSoftwareAPI.Repositories.Interfaces;
using DMSoftwareAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DMSoftwareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private ICaptchaService _captchaService;
        private IBlogRepository _contactRepository;


        public BlogController(ICaptchaService captchaService, IBlogRepository contactRepository)
        {
            this._captchaService = captchaService;
            this._contactRepository = contactRepository;
        }
    }
}