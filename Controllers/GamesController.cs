using Microsoft.AspNetCore.Mvc;
using infiniteworlds_frontend.Models;
using Microsoft.EntityFrameworkCore;
using infiniteworlds_frontend.Data;
using Microsoft.AspNetCore.JsonPatch;

namespace infiniteworlds_frontend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Games
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var games = await _context.Games
                .Include(g => g.Players) // Incluye la relación con Players
                .ToListAsync();
            return View(games);
        }

        // GET: api/Games/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var game = await _context.Games
                .Include(g => g.Players) // Incluye la relación con Players
                .FirstOrDefaultAsync(g => g.GameId == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: api/Games
        [HttpPost]
        public async Task<IActionResult> Create([Bind("GameId,Name,Descripcion,Genero,ReleaseDate")] Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        // PUT: api/Games/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Game game)
        {
            if (id != game.GameId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game); // Actualiza el registro en la base de datos
                    await _context.SaveChangesAsync(); // Guarda los cambios
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.GameId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return NoContent(); // Utiliza NoContent() para indicar que la solicitud fue exitosa pero no devuelve contenido
            }
            return BadRequest(ModelState);
        }

        // DELETE: api/Games/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            _context.Games.Remove(game);
            await _context.SaveChangesAsync();

            return NoContent(); // 204 No Content
        }

        // PATCH: api/Games/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchGame(int id, [FromBody] JsonPatchDocument<Game> patchDoc)
        {
            if (patchDoc == null)
            {
                return BadRequest("Patch document is null.");
            }

            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            // Aplicar el parche al objeto Game encontrado
            patchDoc.ApplyTo(game, ModelState);

            // Verificar el estado del modelo después de aplicar el parche
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _context.SaveChangesAsync(); // Guardar los cambios en la base de datos
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent(); // Utiliza NoContent() para indicar que la solicitud fue exitosa pero no devuelve contenido
        }

        // Método auxiliar para verificar si el registro Game existe
        private bool GameExists(int id)
        {
            return _context.Games.Any(e => e.GameId == id);
        }
    }
}
