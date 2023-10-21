using Microsoft.AspNetCore.Mvc;
using matchlove.Models;

namespace matchlove.Controllers
{
    public class PessoasController : Controller
    {
        private readonly AppDbContext _context;
        public PessoasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        { 
            var dados = _context.Pessoas.ToList();
            return View(dados);
        }
    }
}
