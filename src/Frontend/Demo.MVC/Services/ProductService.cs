using Demo.MVC.Models.Product;
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
    }
}
