using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechGab.API.Data;
using TechGab.API.Models.Domain;
using TechGab.API.Models.DTO;
using TechGab.API.Repositories.Interface;

namespace TechGab.API.Controllers
{
    // https://localhost:XXXX/api/categories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDTO request)
        {
            // Map request DTO to Domain Model
            var category = new Category
            {
                Name = request.Name,
                URLHandle = request.URLHandle
            };

            await categoryRepository.CreateAsync(category);

            // Map response Domain Model to Category DTO
            var response = new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                URLHandle = category.URLHandle
            };

            return Ok(response);

        }
    }
}
