using eShop.Application.DataTransferObjects.Categories;
using eShop.Domain.Enitities.Products;

namespace eShop.Application.Services.Categories
{
    public interface ICategoryService
    {
        Task<Category> AddCategoryAsync(CategoryCreationDTO categoryCreationDTO);
        Task<Category> GetByIdCategoryAsync(int id);
        Task<List<Category>> GetCategiesByParentIdCategoryAsync(int id);
        Task<List<Category>> GetAllCategoriesAsync();
        Task<Category> UpdateCategoryAsync(int id,CategoryModificationDTO categoryModificationDTO);
        Task<Category> DeleteCategoryAsync(int id);
    }
}
