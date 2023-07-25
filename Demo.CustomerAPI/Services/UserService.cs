using AutoMapper;
using Demo.CustomerAPI.Context.Repositories;
using Demo.CustomerAPI.Model;
using Demo.CustomerAPI.Model.dto;
using Microsoft.AspNetCore.Identity;

namespace Demo.CustomerAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        private readonly IMapper _mapper;
        public UserService(IUserRepository repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateUser(UserAddRequest model)
        {
            var user = _mapper.Map<AppUser>(model);
            await _repo.Add(user);
        }

        public async Task Delete(int id)
        {
            var user = await _repo.GetByID(id);
            if (user != null)
            {
                await _repo.Delete(user);
            }
        }

        public async Task<AppUser> GetById(int id)
        {
            return await _repo.GetByID(id);
        }

        public async Task<IEnumerable<AppUser>> GetUsers()
        {
            return await _repo.GetList();
        }
    }
}
