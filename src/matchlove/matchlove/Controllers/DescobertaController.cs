using Microsoft.AspNetCore.Mvc;
using matchlove.Models;
using Microsoft.EntityFrameworkCore;
using NodaTime;
using matchlove.Enum;

namespace matchlove.Controllers
{
    public class DescobertaController : Controller
    {
        private readonly AppDbContext _context;
        public DescobertaController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? usuario, int? idadeMin, string? idadeMax, string? genero, int? musica, int? hobby, int? filme)
        {
            ViewBag.Musicas = await _context.Musicas.ToListAsync();
            ViewBag.Hobbies = await _context.Hobbies.ToListAsync();
            ViewBag.Filmes = await _context.Filmes.ToListAsync();
            
            IQueryable<Pessoa> query = _context.Pessoas
            .Include(p => p.Infos)
            .ThenInclude(i => i.Filme)   // Inclui informações sobre filmes
            .Include(p => p.Infos)
            .ThenInclude(i => i.Hobby)   // Inclui informações sobre hobbies
            .Include(p => p.Infos)
            .ThenInclude(i => i.Musica)  // Inclui informações sobre músicas
            .AsQueryable();

            

            if (idadeMin.HasValue)
            {
                if (idadeMax == "80+")
                {
                    query = query.Where(p => p.DataNascimento.HasValue &&
                                             DateTime.Now.Year - p.DataNascimento.Value.Year >= idadeMin);
                }
                else
                {
                    int idadeMaxInt = idadeMax != null ? int.Parse(idadeMax) : int.MaxValue;
                    query = query.Where(p => p.DataNascimento.HasValue &&
                                             DateTime.Now.Year - p.DataNascimento.Value.Year >= idadeMin &&
                                             DateTime.Now.Year - p.DataNascimento.Value.Year <= idadeMaxInt);
                }
            }
            if (!string.IsNullOrEmpty(genero))
            {
                if (genero.ToLower() == "masculino")
                {
                    query = query.Where(p => p.Genero == TipoGeneros.Masculino);
                }
                else if (genero.ToLower() == "feminino")
                {
                    query = query.Where(p => p.Genero == TipoGeneros.Feminino);
                }
                else
                {
                    query = query.Where(p => p.Genero == TipoGeneros.Outros || p.Genero == TipoGeneros.Feminino || p.Genero == TipoGeneros.Masculino);
                }
            }

            if (musica.HasValue && musica > 0)
            {
                query = query.Where(p => p.Infos.Any(i => i.MusicaId == musica));
            }

            // Filtro de hobby
            if (hobby.HasValue && hobby > 0)
            {
                query = query.Where(p => p.Infos.Any(i => i.HobbyId == hobby));
            }

            // Filtro de filme
            if (filme.HasValue && filme > 0)
            {
                query = query.Where(p => p.Infos.Any(i => i.FilmeId == filme));
            }

            if (usuario.HasValue)
            {
                query = query.Where(p => p.Id != usuario);

            }
            else
            {
                query = query.Where(p => p.Id != 1);
            }
            string usuarioLogado;
            if (usuario != null)
            {
                usuarioLogado = await _context.Pessoas
            .Where(p => p.Id == usuario)
            .Select(p => p.Nome)
            .FirstOrDefaultAsync();
            }
            else
            {
                usuarioLogado = await _context.Pessoas
            .Where(p => p.Id == 1)
            .Select(p => p.Nome)
            .FirstOrDefaultAsync();
            }
            var dados = query.ToList();

            ViewBag.UsuarioMockado = usuarioLogado;

            return View(dados);
        }
    }
}
