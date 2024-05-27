using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KhumaloCraft.Data
{
    

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<KhumaloCraft.Models.Products> Products { get; set; }
        public DbSet<KhumaloCraft.Models.Order> Orders { get; set; }
    }
}
