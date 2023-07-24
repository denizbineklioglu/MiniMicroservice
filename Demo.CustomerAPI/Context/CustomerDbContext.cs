using Demo.CustomerAPI.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Demo.CustomerAPI.Context
{
    public class CustomerDbContext : IdentityDbContext<AppUser,AppRole,int>
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
        }


        public DbSet<Customer> Customers { get; set; }

    }
}
