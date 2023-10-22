using matchlove.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace matchlove.Controllers
{
    public class LoginsController : Controller
    {

        private readonly AppDbContext _context;
        public LoginsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Login.ToListAsync();

            return View(dados);
        }
    }
}
