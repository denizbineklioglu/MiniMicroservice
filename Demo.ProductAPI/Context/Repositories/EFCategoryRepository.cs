
using Demo.ProductAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo.ProductAPI.Context.Repositories
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly ProductDBContext _dbContext;

        public EFCategoryRepository(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Category t)
        {
            await _dbContext.Categories.AddAsync(t);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Category t)
        {
            _dbContext.Categories.Remove(t);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Category> GetByID(int id)
        {
            return await _dbContext.Categories.SingleOrDefaultAsync(x => x.CategoryID == id);
        }

        public async Task<IList<Category>> GetList()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        public async Task Update(Category t)
        {
            _dbContext.Categories.Update(t);
            await _dbContext.SaveChangesAsync();
        }
    }
}
