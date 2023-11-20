//using matchlove.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace matchlove.Controllers
//{
//    public class LikesController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public LikesController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: Likes
//        public async Task<IActionResult> Index()
//        {
//            // retorna uma lista de likes do usuário atual
//            var userId = User.Identity.GetUserId();
//            var likes = await _context.Likes
//                .Where(l => l.LikerId == userId || l.LikeeId == userId)
//                .ToListAsync();
//            return View(likes);
//        }

//        // POST: Likes/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create(int likeeId)
//        {
//            // cria um novo like do usuário atual para outro usuário
//            var userId = User.Identity.GetUserId();
//            var like = new Like
//            {
//                LikerId = userId,
//                LikeeId = likeeId,
//                Matched = false
//            };
//            _context.Add(like);
//            await _context.SaveChangesAsync();

//            // verifica se houve um match (like mútuo)
//            var match = await _context.Likes
//                .FirstOrDefaultAsync(l => l.LikerId == likeeId && l.LikeeId == userId);
//            if (match != null)
//            {
//                // atualiza o status de matched para ambos os likes
//                like.Matched = true;
//                match.Matched = true;
//                _context.Update(like);
//                _context.Update(match);
//                await _context.SaveChangesAsync();
//            }

//            return RedirectToAction(nameof(Index));
//        }

//        // POST: Likes/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            // deleta um like existente
//            var like = await _context.Likes.FindAsync(id);
//            _context.Likes.Remove(like);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }
//    }

//}
