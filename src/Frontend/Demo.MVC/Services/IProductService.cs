using Demo.MVC.Models.Product;

namespace Demo.MVC.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductListViewModel>> GetProducts();
        Task<bool> CreateProduct(ProductCreateViewModel model);
        Task<bool> DeleteProduct(int id);
        Task<bool> UpdateProduct(ProductUpdateModel model);

        Task<ProductViewModel> GetProductById(int id); 
    }
}
