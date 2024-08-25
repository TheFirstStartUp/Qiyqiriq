using eShop.Domain.Enitities.Products;
using eShop.Infrastructure.Repositories.Products.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public TestController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> TestActionAsync()
        {
            return Ok(_categoryRepository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> PostCategoryTest(Category category)
        {
            return Ok(await _categoryRepository.AddAsync(category));
        }
    }
}
