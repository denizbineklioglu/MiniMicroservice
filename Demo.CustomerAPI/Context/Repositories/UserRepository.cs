using Demo.CustomerAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo.CustomerAPI.Context.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CustomerDbContext _context;

        public UserRepository(CustomerDbContext context)
        {
            _context = context;
        }

        public async Task Add(AppUser t)
        {
            await _context.Users.AddAsync(t);   
            await _context.SaveChangesAsync();
        }

        public async Task Delete(AppUser t)
        {
            _context.Users.Remove(t);
            await _context.SaveChangesAsync();
        }

        public async Task<AppUser> GetByID(int id)
        {
            return await _context.Users.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IList<AppUser>> GetList()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task Update(AppUser t)
        {
            _context.Users.Update(t);
            await _context.SaveChangesAsync();
        }
    }
}
