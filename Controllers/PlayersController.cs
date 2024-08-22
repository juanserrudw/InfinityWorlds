using Microsoft.AspNetCore.Mvc;
using infiniteworlds_frontend.Models;
using Microsoft.EntityFrameworkCore;
using infiniteworlds_frontend.Data;
using Microsoft.AspNetCore.JsonPatch;

namespace infiniteworlds_frontend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlayersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Players
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var players = await _context.Players.ToListAsync();
            return View(players);
        }

        // GET: api/Players/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // POST: api/Players
        [HttpPost]
        public async Task<IActionResult> Create([Bind("PlayerId,Username,EstadoCuenta,UserId,GameId")] Player player)
        {
            if (ModelState.IsValid)
            {
                _context.Add(player);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(player);
        }

        // PUT: api/Players/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Player player)
        {
            if (id != player.PlayerId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(player); // Actualiza el registro en la base de datos
                    await _context.SaveChangesAsync(); // Guarda los cambios
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerExists(player.PlayerId))
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

        // DELETE: api/Players/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }

            _context.Players.Remove(player);
            await _context.SaveChangesAsync();

            return NoContent(); // 204 No Content
        }

        // PATCH: api/Players/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchPlayer(int id, [FromBody] JsonPatchDocument<Player> patchDoc)
        {
            if (patchDoc == null)
            {
                return BadRequest("Patch document is null.");
            }

            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }

            // Aplicar el parche al objeto Player encontrado
            patchDoc.ApplyTo(player, ModelState);

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
                if (!PlayerExists(id))
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

        // Método auxiliar para verificar si el registro Player existe
        private bool PlayerExists(int id)
        {
            return _context.Players.Any(e => e.PlayerId == id);
        }
    }
}
