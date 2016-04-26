using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace WebApplication2.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Size> Size { get; set; }
        
    }
}