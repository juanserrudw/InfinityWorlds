using Microsoft.AspNetCore.Mvc;
using infiniteworlds_frontend.Models;
using infiniteworlds_frontend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.JsonPatch;

namespace infiniteworlds_frontend.Controllers
{
    public class GamesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Games
        public async Task<IActionResult> Index()
        {
            var games = await _context.Games.ToListAsync();
            return View(games);
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var game = await _context.Games
                .FirstOrDefaultAsync(g => g.GameId == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }



        

        // POST: Games/Create

        [HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Create(Game game)
{
    if (ModelState.IsValid)
    {
        // Validar si la URL de la imagen es proporcionada
        if (string.IsNullOrEmpty(game.ImageFilePath))
        {
            ModelState.AddModelError("ImageFilePath", "The image URL is required.");
        }

        // Intentar agregar el juego a la base de datos si el modelo es válido
        if (ModelState.IsValid)
        {
            try
            {
                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error saving the game to the database.");
                Console.WriteLine($"Database saving error: {ex.Message}");
            }
        }
    }
    else
    {
        // Registrar el estado del modelo si no es válido
        foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
        {
            Console.WriteLine(error.ErrorMessage);
        }
    }

    return View(game);
}



        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        } 

        // POST: Games/Edit/5
       [HttpPost]
public async Task<IActionResult> Edit(int id, [Bind("GameId,Name,Descripcion,Genero,ReleaseDate,ImageFilePath")] Game game)
{
    if (id != game.GameId)
    {
        return NotFound();
    }

    if (ModelState.IsValid)
    {
        try
        {
            _context.Update(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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
    }
    return View(game);
} 


        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var game = await _context.Games
                .FirstOrDefaultAsync(g => g.GameId == id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game != null)
            {
                _context.Games.Remove(game);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        // Método auxiliar para verificar si el registro Game existe
        private bool GameExists(int id)
        {
            return _context.Games.Any(e => e.GameId == id);
        }

        // Método para manejar PATCH (simulado)
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
    }
}













