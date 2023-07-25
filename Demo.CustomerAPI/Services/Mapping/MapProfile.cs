using AutoMapper;
using Demo.CustomerAPI.Model;
using Demo.CustomerAPI.Model.dto;
using Microsoft.AspNetCore.Identity;

namespace Demo.CustomerAPI.Services.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<UserLoginRequest, AppUser>();
            CreateMap<UserRegisterRequest, AppUser>();
            CreateMap<UserAddRequest, AppUser>();
        }
    }
}
