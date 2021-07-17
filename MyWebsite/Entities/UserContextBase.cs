using Microsoft.EntityFrameworkCore;

namespace MyWebsite.Entities
{
    public class UserContextBase
    {
        public DbSet<User> Users { get; set; }
    }
}