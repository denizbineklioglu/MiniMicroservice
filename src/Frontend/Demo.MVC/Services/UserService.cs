using Demo.MVC.Models.Product;
using Demo.MVC.Models.User;
using System.Net.Http.Json;

namespace Demo.MVC.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> Register(UserRegisterModel model)
        {
            var requestUri = "http://localhost:5170/Auth/Register";
            var response = await _httpClient.PostAsJsonAsync<UserRegisterModel>(requestUri, model);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> Login(UserLoginModel model)
        {
            var requestUri = "http://localhost:5170/Auth/Login";
            var response = await _httpClient.PostAsJsonAsync<UserLoginModel>(requestUri, model);

            return response.IsSuccessStatusCode;
        }
    }
}
