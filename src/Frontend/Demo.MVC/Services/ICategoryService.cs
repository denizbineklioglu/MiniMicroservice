using Demo.MVC.Models.Product;

namespace Demo.MVC.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryViewModel>> GetCategories();
    }
}
