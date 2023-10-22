using matchlove.Models;
using Microsoft.AspNetCore.Mvc;

namespace matchlove.Controllers
{
    public class DenunciasController : Controller
    {
        private readonly AppDbContext _context;
        public DenunciasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = _context.Denuncia.ToList();
            return View();
        }
    }
}
