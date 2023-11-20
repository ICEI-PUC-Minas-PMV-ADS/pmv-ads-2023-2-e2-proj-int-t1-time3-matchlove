using matchlove.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace matchlove.Controllers
{
    public class AvaliacoesController : Controller
    {
        private readonly AppDbContext _context;
        public AvaliacoesController(AppDbContext context)
        {
            _context = context;
        }
        // GET: AvaliacoesController
        public async Task<ActionResult> Index()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var listaAvaliacoes = await _context.Avaliacoes.ToListAsync();
            var avaliacoes = listaAvaliacoes.Where(a => a.UsuarioId.Equals(userId +"")).ToList();
            return View(avaliacoes);
        }

        // GET: AvaliacoesController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Avaliacoes == null)
            {
                return NotFound();
            }

            var avaliacao = await _context.Avaliacoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (avaliacao == null)
            {
                return NotFound();
            }
            return View(avaliacao);
        }

        // GET: AvaliacoesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AvaliacoesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Classificacao,Comentario,UsuarioId")] Avaliacao avaliacao)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    avaliacao.UsuarioId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                } catch(FormatException)
                {
                    throw;
                }
                
                _context.Add(avaliacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(avaliacao);
        }

        // GET: AvaliacoesController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Avaliacoes == null)
            {
                return NotFound();
            }

            var avaliacao = await _context.Usuarios.FindAsync(id);
            if (avaliacao == null)
            {
                return NotFound();
            }
            return View(avaliacao);
        }

        // POST: AvaliacoesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Classificacao,Comentario,UsuarioId")] Avaliacao avaliacao )
        {
            if (id != avaliacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(avaliacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (null != avaliacao.Id)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(avaliacao);
        }

        // GET: AvaliacoesController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Avaliacoes == null)
            {
                return NotFound();
            }

            var avaliacao = await _context.Avaliacoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (avaliacao == null)
            {
                return NotFound();
            }

            return View(avaliacao);
        }

        // POST: AvaliacoesController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Avaliacoes == null)
            {
                return Problem("Entity set 'AppDbContext.Usuarios' is null.");
            }
            var avaliacao = await _context.Avaliacoes.FindAsync(id);
            if (avaliacao == null)
            {
                _context.Avaliacoes.Remove(avaliacao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
