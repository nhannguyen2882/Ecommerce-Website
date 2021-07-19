using EcomWeb.DataAccessor.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcomWeb.DataAccessor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Image> Images{ get; set; }



    }
}
