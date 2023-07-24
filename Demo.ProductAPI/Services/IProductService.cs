using Demo.ProductAPI.Model;
using Demo.ProductAPI.Services.dtos;
using Demo.ProductAPI.Services.Dtos;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Demo.ProductAPI.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductListReponse>> GetProducts();
        Task CreateProduct(ProductAddRequestDto model);
        Task<Product> GetById(int id);
        Task DeleteProduct(int id);
    }
}
