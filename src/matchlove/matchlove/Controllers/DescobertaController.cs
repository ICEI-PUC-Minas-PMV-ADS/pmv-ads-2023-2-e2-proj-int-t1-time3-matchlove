using Microsoft.AspNetCore.Mvc;
using matchlove.Models;

namespace matchlove.Controllers
{
    public class DescobertaController : Controller
    {
        private readonly AppDbContext _context;
        public DescobertaController(AppDbContext context)
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
