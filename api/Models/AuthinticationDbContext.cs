using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace wepApiAuth.Models
{
    public class AuthinticationDbContext : IdentityDbContext
    {
        public AuthinticationDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}