using Demo.MVC.Models.Product;

namespace Demo.MVC.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public  async Task<IEnumerable<CategoryViewModel>> GetCategories()
        {
            var requestUri = "http://localhost:5170/Category/GetCategories";
            var response = await _httpClient.GetAsync(requestUri);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSuccess = await response.Content.ReadFromJsonAsync<IEnumerable<CategoryViewModel>>();

            return responseSuccess;

        }
    }
}
