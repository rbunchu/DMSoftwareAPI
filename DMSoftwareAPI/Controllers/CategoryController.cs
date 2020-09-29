using DMSoftwareAPI.Models;
using DMSoftwareAPI.Repositories.Interfaces;
using DMSoftwareAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DMSoftwareAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        [HttpPost]
        public ApiResponse Post([FromBody]CategoryFormData data)
        {
            this._categoryRepository.AddCategory(
                new Models.Data.Category() {
                    Name = data.Name
            });

            return new ApiResponse() { StatusCode = StatusCodes.Status201Created };
        }
    }
}