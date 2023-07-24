using AutoMapper;
using Demo.CustomerAPI.Model;
using Demo.CustomerAPI.Model.dto;
using Microsoft.AspNetCore.Identity;

namespace Demo.CustomerAPI.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;
        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task Login(UserLoginRequest model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName,model.Password,false,true);
        }

        public async Task Register(UserRegisterRequest model)
        {
            var user = _mapper.Map<AppUser>(model); 
            var result = await _userManager.CreateAsync(user,model.Password);
        }
    }
}
