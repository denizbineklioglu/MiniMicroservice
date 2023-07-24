using Demo.ProductAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo.ProductAPI.Context
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
