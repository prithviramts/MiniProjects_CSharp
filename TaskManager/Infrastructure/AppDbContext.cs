using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Models;

namespace TaskManager.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Users> User => Set<Users>();
        public DbSet<Tasks> Task => Set<Tasks>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
