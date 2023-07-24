using Demo.ProductAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo.ProductAPI.Context.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ProductDBContext _dbContext;

        public EFProductRepository(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Product t)
        {
            await _dbContext.Products.AddAsync(t);
            await _dbContext.SaveChangesAsync();    
        }

        public async Task Delete(Product t)
        {
            _dbContext.Products.Remove(t);
            await _dbContext.SaveChangesAsync();
        }

        public Task<Product> GetByID(int id)
        {
            return _dbContext.Products.SingleOrDefaultAsync(x => x.ProductID == id);
        }

        public async Task<IList<Product>> GetList()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task Update(Product t)
        {
            ;_dbContext.Products.Update(t);
            await _dbContext.SaveChangesAsync();
        }
    }
}
