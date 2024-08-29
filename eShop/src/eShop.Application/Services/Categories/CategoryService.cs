using eShop.Application.DataTransferObjects.Categories;
using eShop.Domain.Enitities.Products;
using eShop.Infrastructure.Repositories.Products.Categories;
using Mapster;

namespace eShop.Application.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository) 
            => _categoryRepository = categoryRepository;

        public async Task<Category> AddCategoryAsync(CategoryCreationDTO categoryCreationDTO)
        {
            var category = categoryCreationDTO.Adapt<Category>();
            category = await _categoryRepository.AddAsync(category);

            return category;
        }

        public async Task<Category> DeleteCategoryAsync(int id)
        {
            var category = await _categoryRepository.FindAsync(x => x.Id.Equals(id));

            if(category == null) 
            {
                //validate
            }
            
            category = await _categoryRepository.RemoveAsync(category);

            return category;
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return _categoryRepository.GetAll().ToList();
        }

        public async Task<Category> GetByIdCategoryAsync(int id)
        {
            var category = await _categoryRepository.FindAsync(x => x.Id.Equals(id));

            if(category == null) 
            {
                // validate
            }

            return category;
        }

        public async Task<List<Category>> GetCategiesByParentIdCategoryAsync(int id) 
            => await _categoryRepository.Filter(x => x.ParentId == id);

        public async Task<Category> UpdateCategoryAsync(int id,CategoryModificationDTO categoryModificationDTO)
        {
            var category = await _categoryRepository.FindAsync(x => x.Id.Equals(id));

            if(category == null) 
            {
                // validate
            }

            category = categoryModificationDTO.Adapt(category);
            return await _categoryRepository.UpdateAsync(category);
        }
    }
}
