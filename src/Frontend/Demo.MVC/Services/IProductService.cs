using Demo.MVC.Models.Product;

namespace Demo.MVC.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductListViewModel>> GetProducts();
    }
}
