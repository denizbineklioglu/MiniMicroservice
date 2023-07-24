using Microsoft.AspNetCore.Identity;

namespace Demo.CustomerAPI.Model
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
