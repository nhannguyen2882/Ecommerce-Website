using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.Entities
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options)
        : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("User");
            modelBuilder.Entity<User>()
                .Property(s => s.UserId)
                .HasColumnName("UserId");
            modelBuilder.Entity<User>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(s => s.Age)
                .IsRequired(false);
        }

    }


}
