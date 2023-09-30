using Microsoft.EntityFrameworkCore;

namespace matchlove.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Curtida> Curtida { get; set; }
        public DbSet<Match> Match { get; set; }
        public DbSet<Denuncia> Denuncia { get; set; }
    }
}
