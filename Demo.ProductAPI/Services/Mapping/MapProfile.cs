using AutoMapper;
using Demo.ProductAPI.Model;
using Demo.ProductAPI.Services.dtos;
using Demo.ProductAPI.Services.Dtos;

namespace Demo.ProductAPI.Services.Mapping
{
    public class MapProfile :Profile
    {
        public MapProfile()
        {
            CreateMap<CategoryAddRequest, Category>();
            CreateMap<Category, CategoryListResponse>();

            CreateMap<Product, ProductListReponse>();
            CreateMap<ProductAddRequestDto, Product>();

            CreateMap<ProductUpdateDto, Product>();
            CreateMap<CategoryUpdateDto, Category>();
        }
    }
}
