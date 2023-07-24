using Demo.CustomerAPI.Model.dto;

namespace Demo.CustomerAPI.Services
{
    public interface IUserService
    {
        Task Register(UserRegisterRequest model);
        Task Login(UserLoginRequest model);
    }
}
