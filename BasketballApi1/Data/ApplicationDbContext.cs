using Microsoft.EntityFrameworkCore;
using BasketballApi1.Models;
namespace BasketballApi1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Players> Players { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}

