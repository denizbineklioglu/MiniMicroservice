using Demo.MVC.Models.User;

namespace Demo.MVC.Services
{
    public interface IUserService
    {
        Task<bool> Register(UserRegisterModel model);
        Task<bool> Login(UserLoginModel model);
    }
}
