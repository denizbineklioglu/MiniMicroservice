using AutoMapper;
using Demo.ProductAPI.Context.Repositories;
using Demo.ProductAPI.Model;
using Demo.ProductAPI.Services.dtos;
using Demo.ProductAPI.Services.Dtos;

namespace Demo.ProductAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateProduct(ProductAddRequestDto model)
        {
            var product = _mapper.Map<Product>(model);
            await _repo.Add(product);
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _repo.GetByID(id);
            await _repo.Delete(product);
        }

        public async Task<Product> GetById(int id)
        {
           return await _repo.GetByID(id);
        }

        public async Task<IEnumerable<ProductListReponse>> GetProducts()
        {
            var products = await _repo.GetList();
            return _mapper.Map<IEnumerable<ProductListReponse>>(products);
        }

        public async Task UpdateProduct(ProductUpdateDto model)
        {
            var product = _mapper.Map<Product>(model);
            await _repo.Update(product);
        }
    }
}
