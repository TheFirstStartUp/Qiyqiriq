using eShop.Application.DataTransferObjects.Categories;
using eShop.Application.Services.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService) 
            => _categoryService = categoryService;

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CategoryCreationDTO categoryCreationDTO)
        {
            return Ok(await _categoryService.AddCategoryAsync(categoryCreationDTO));
        }
   
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _categoryService.GetAllCategoriesAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _categoryService.GetByIdCategoryAsync(id));
        }

         [HttpGet("{id}/childs")]
        public async Task<IActionResult> GetChildsByIdAsync(int id)
        {
            return Ok(await _categoryService.GetCategiesByParentIdCategoryAsync(id));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, CategoryModificationDTO categoryModificationDTO){
            return Ok(await _categoryService.UpdateCategoryAsync(id, categoryModificationDTO));
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            return Ok(await _categoryService.DeleteCategoryAsync(id));
        }
    }
}
