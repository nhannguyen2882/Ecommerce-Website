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
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems{ get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
