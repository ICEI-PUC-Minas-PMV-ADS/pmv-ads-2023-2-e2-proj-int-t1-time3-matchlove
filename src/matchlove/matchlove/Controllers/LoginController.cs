using matchlove.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace matchlove.Controllers
{
    public class LoginController : Controller
    {

        private readonly AppDbContext _context;
        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Login()
        {
            var dados = await _context.Login.ToListAsync();

            return View(dados);
        }
    }
}
