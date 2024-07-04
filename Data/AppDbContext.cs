using Microsoft.EntityFrameworkCore;
using TicketSystem.Models;

namespace TicketSystem.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext): base(dbContext)
        {
        }

        public DbSet<User> users { get; set; }
        public DbSet<Bug> bug { get; set; }
        public DbSet<Feature> features { get; set; }

    }
}
