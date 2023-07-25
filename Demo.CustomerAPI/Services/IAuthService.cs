using Demo.CustomerAPI.Model.dto;

namespace Demo.CustomerAPI.Services
{
    public interface IAuthService
    {
        Task Register(UserRegisterRequest model);
        Task<bool> Login(UserLoginRequest model);
    }
}
