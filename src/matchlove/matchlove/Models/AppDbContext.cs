using Microsoft.EntityFrameworkCore;

namespace matchlove.Models
{
<<<<<<< HEAD
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Login> Login { get; set; }
=======
        
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
        }
>>>>>>> 73aae586d67bb84c5e649d07c7647326d65710e7
    }
