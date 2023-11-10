using Microsoft.EntityFrameworkCore;

using UnitTestDemo.Features.Users;

namespace UnitTestDemo
{
    public class UnitTestDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UnitTestDbContext() : base()
        {
            
        }
    }
}
