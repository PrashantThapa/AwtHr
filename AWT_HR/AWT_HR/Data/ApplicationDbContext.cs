using Microsoft.EntityFrameworkCore;
using AppHealth.Models;

namespace AppHealth.Data
{
    public class ApplicationDbContext:DbContext//IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Role>().ToTable("Role");
            builder.Entity<User>().ToTable("User");
            base.OnModelCreating(builder);
        }
        public  DbSet<Role> Roles { get; set; }
        public  DbSet<User> Users { get; set; }
        public DbSet<LoginViewModel> LoginViewModel { get; set; }
    }
}
