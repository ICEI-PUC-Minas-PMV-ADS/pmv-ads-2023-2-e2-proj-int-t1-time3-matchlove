using Microsoft.EntityFrameworkCore;

namespace matchlove.Models
{
    public class AppDbContext : DbContext
    {        
            protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            public DbSet<Pessoa> Pessoas { get; set; }
            public DbSet<Curtida> Curtida { get; set; }
            public DbSet<Match> Match { get; set; }
            public DbSet<Denuncia> Denuncia { get; set; }
            public DbSet<Login> Login { get; set; }
        }

    }
