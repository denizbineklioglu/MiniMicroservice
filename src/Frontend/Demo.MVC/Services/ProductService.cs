using Demo.MVC.Models.Product;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Demo.MVC.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateProduct(ProductCreateViewModel model)
        {
            var requestUri = "http://localhost:5170/Product/CreateProduct";
            var response = await _httpClient.PostAsJsonAsync<ProductCreateViewModel>(requestUri, model);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var requestUri = "http://localhost:5170/Product/DeleteProduct/" + id;
            var response = await _httpClient.DeleteAsync(requestUri);

            return response.IsSuccessStatusCode;
        }

        public async Task<ProductViewModel> GetProductById(int id)
        {
            var requestUri = "http://localhost:5170/Product/GetProductById/" + id;
            var response = await _httpClient.GetAsync(requestUri);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var responseSuccess = await response.Content.ReadFromJsonAsync<ProductViewModel>();
            return responseSuccess;
        }

        public async Task<IEnumerable<ProductListViewModel>> GetProducts()
        {

            var requestUri = "http://localhost:5170/Product/GetProducts";
            var response = await _httpClient.GetAsync(requestUri);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var responseSuccess = await response.Content.ReadFromJsonAsync<IEnumerable<ProductListViewModel>>();
            return responseSuccess;
        }

        public async Task<bool> UpdateProduct(ProductUpdateModel model)
        {
            var requestUri = "http://localhost:5170/Product/UpdateProduct";
            var response = await _httpClient.PutAsJsonAsync<ProductUpdateModel>(requestUri, model);

            return response.IsSuccessStatusCode;

        }
    }
}
