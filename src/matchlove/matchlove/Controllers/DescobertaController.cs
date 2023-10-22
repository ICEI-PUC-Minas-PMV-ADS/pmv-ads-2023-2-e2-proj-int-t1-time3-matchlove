using Microsoft.AspNetCore.Mvc;
using matchlove.Models;
using Microsoft.EntityFrameworkCore;
using NodaTime;

namespace matchlove.Controllers
{
    public class DescobertaController : Controller
    {
        private readonly AppDbContext _context;
        public DescobertaController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? idadeMin, string? idadeMax)
        {
            IQueryable<Pessoa> query = _context.Pessoas.Include(p => p.Infos).AsQueryable();

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

            var dados = query.ToList();

            return View(dados);
        }
    }
}
