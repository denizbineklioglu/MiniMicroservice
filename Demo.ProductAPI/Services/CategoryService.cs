using AutoMapper;
using Demo.ProductAPI.Context.Repositories;
using Demo.ProductAPI.Model;
using Demo.ProductAPI.Services.Dtos;

namespace Demo.ProductAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateCategory(CategoryAddRequest model)
        {
            var category = _mapper.Map<Category>(model);
            await _repo.Add(category);
        }

        public async Task DeleteCategory(int id)
        {
            var category = await _repo.GetByID(id);
            await _repo.Delete(category);
        }

        public async Task<Category> GetById(int id)
        {
            return await _repo.GetByID(id);
        }

        public async Task<CategoryUpdateResponse> GetCategoryForUpdate(int id)
        {
            var category = await _repo.GetByID(id);
            return _mapper.Map<CategoryUpdateResponse>(category);
        }

        public async Task<IEnumerable<CategoryListResponse>> GetCategoryList()
        {
            var categories = await _repo.GetList();
            return _mapper.Map<IEnumerable<CategoryListResponse>>(categories);
        }
    }
}
