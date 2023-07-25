using Demo.CustomerAPI.Model;
using Demo.CustomerAPI.Model.dto;

namespace Demo.CustomerAPI.Services
{
    public interface IUserService
    {
        Task CreateUser(UserAddRequest model);
        Task Delete(int id);
        Task<AppUser> GetById(int id);
        Task<IEnumerable<AppUser>> GetUsers();
    }
}
