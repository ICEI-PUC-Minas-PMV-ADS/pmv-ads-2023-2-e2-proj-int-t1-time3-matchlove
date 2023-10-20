using Microsoft.AspNetCore.Mvc;
using matchlove.Models;

namespace matchlove.Controllers

{
    public class CurtidasController : Controller
    {
        private readonly AppDbContext _context;
        public CurtidasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = _context.Curtida.ToList();
            return View();
        }
    }
}