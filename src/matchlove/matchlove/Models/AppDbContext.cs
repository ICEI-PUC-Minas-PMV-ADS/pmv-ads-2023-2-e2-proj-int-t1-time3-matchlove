using Microsoft.EntityFrameworkCore;

namespace matchlove.Models
{
    public class AppDbContext : DbContext
    {        
            protected override void OnModelCreating(ModelBuilder builder)
        {
            
             base.OnModelCreating(builder);
            builder.Entity<Info>()
            .HasOne(i => i.Pessoa)
            .WithMany(p => p.Infos)
            .HasForeignKey(i => i.PessoaId)
            .OnDelete(DeleteBehavior.Restrict);
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            public DbSet<Pessoa> Pessoas { get; set; }
            public DbSet<Match> Match { get; set; }
            public DbSet<Denuncia> Denuncia { get; set; }
            public DbSet<Login> Login { get; set; }
            public DbSet<Info> Info { get; set; }
        }

    }
