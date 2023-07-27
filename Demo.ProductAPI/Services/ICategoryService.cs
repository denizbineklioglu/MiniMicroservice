using Demo.ProductAPI.Model;
using Demo.ProductAPI.Services.Dtos;

namespace Demo.ProductAPI.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryListResponse>> GetCategoryList();
        Task CreateCategory(CategoryAddRequest model);
        Task DeleteCategory(int id);
        Task<Category> GetById(int id);
        Task<CategoryUpdateResponse> GetCategoryForUpdate(int id);
        Task UpdateCategory(CategoryUpdateDto model);
    }
}
