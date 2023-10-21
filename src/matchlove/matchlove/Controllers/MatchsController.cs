using matchlove.Models;
using Microsoft.AspNetCore.Mvc;

namespace matchlove.Controllers
{
    public class MatchsController : Controller
    {
        private readonly AppDbContext _context;
        public MatchsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados =  _context.Match.ToList();
            return View(dados);
        }
    }
}
