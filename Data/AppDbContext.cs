using Microsoft.EntityFrameworkCore;

namespace encurtador_link.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Encurtador> Encurtador { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}