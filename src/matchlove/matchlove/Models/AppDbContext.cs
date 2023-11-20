using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

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
            builder.Entity<Info>().HasIndex(i => i.PessoaId).HasDatabaseName("IX_Infos_PessoaId_Custom").IsUnique(false);
            
            builder.Entity<Denuncia>()
                .HasOne(d => d.PerfilDenunciado)
                .WithMany(p => p.DenunciasRecebidas)
                .HasForeignKey(d => d.PerfilDenunciadoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Denuncia>()
                .HasOne(d => d.Denunciante)
                .WithMany(p => p.DenunciasFeitas)
                .HasForeignKey(d => d.DenuncianteId)
                .OnDelete(DeleteBehavior.Restrict);



            builder.Entity<Info>()
         .HasOne(i => i.Filme) // Considerando que você tem uma propriedade de navegação chamada Filme em sua classe Info para representar o relacionamento com Filme
         .WithOne()
         .HasForeignKey<Info>(i => i.FilmeId)
         .IsRequired(false); // FilmeId é opcional

            builder.Entity<Info>()
                .HasOne(i => i.Musica) // Considerando que você tem uma propriedade de navegação chamada Musica em sua classe Info para representar o relacionamento com Musica
                .WithOne()
                .HasForeignKey<Info>(i => i.MusicaId)
                .IsRequired(false); // MusicaId é opcional

            builder.Entity<Info>()
                .HasOne(i => i.Hobby) // Considerando que você tem uma propriedade de navegação chamada Hobby em sua classe Info para representar o relacionamento com Hobby
                .WithOne()
                .HasForeignKey<Info>(i => i.HobbyId)
                .IsRequired(false); // HobbyId é opcional
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            public DbSet<Pessoa> Pessoas { get; set; }
            public DbSet<Match> Match { get; set; }
            public DbSet<Login> Login { get; set; }
            public DbSet<Info> Info { get; set; }
            public DbSet<Filme> Filmes { get; set; }
            public DbSet<Musica> Musicas { get; set; }
            public DbSet<Hobby> Hobbies { get; set; }
            public DbSet<Usuario> Usuarios { get; set; }

            public DbSet<Denuncia> Denuncias { get; set; }  



    }

    }
