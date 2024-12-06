using Microsoft.EntityFrameworkCore;
using GameCatalog.Models;

namespace GameCatalog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Game> Games { get; set; }
    }
}
