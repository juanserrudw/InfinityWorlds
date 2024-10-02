using Microsoft.AspNetCore.Mvc;
using infiniteworlds_frontend.Models;
using infiniteworlds_frontend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.JsonPatch;
using System.Security.Claims;
using infiniteworlds_fronted.Models;
using Microsoft.AspNetCore.Hosting.Server.Features;

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
            Console.WriteLine($"el precioo es {game.Price}");
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

        public async Task<IActionResult> MyGames()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var purchasedGames = await _context.PurchasedGames
                .Include(pg => pg.Game)
                .Where(pg => pg.UserId == userId)
                .Select(pg => pg.Game)
                .ToListAsync();

            return View(purchasedGames); // Asegúrate de que este es un IEnumerable<Game>
        }

        [HttpPost]
        public async Task<IActionResult> Purchase(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Lógica para verificar si el juego ya ha sido comprado y realizar la compra
            var game = await _context.Games.FindAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            // Crear la entrada de juego comprado para el usuario
            var purchasedGame = new PurchasedGame
            {
                UserId = userId,
                GameId = game.GameId,
                PurchaseDate = DateTime.Now
            };

            _context.PurchasedGames.Add(purchasedGame);
            await _context.SaveChangesAsync();

            // Redirigir a la lista de juegos comprados o a alguna otra página
            return RedirectToAction("MyGames");
        }
        [HttpGet]
        public async Task<IActionResult> Cart()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var cartItems = await _context.ShoppingCartItems
                .Include(c => c.Game)
                .Where(c => c.UserId == userId)
                .ToListAsync();

            return View(cartItems);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int gameId)
        {
            if (gameId <= 0)
            {
                return BadRequest("El ID del juego es inválido.");
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var game = await _context.Games.FindAsync(gameId);

            if (game == null)
            {
                return NotFound();
            }

            var existingCartItem = await _context.ShoppingCartItems
                .FirstOrDefaultAsync(c => c.UserId == userId && c.GameId == gameId);

            if (existingCartItem != null)
            {
                existingCartItem.Quantity++;
            }
            else
            {
                var cartItem = new ShoppingCartItem
                {
                    UserId = userId,
                    GameId = gameId,
                    Quantity = 1
                };

                _context.ShoppingCartItems.Add(cartItem);
            }

            await _context.SaveChangesAsync();

            TempData["Success"] = "Juego agregado al carrito.";
            return RedirectToAction("Cart");
        }

        // Método para mostrar la página de Checkout
        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            // Obtener el ID del usuario actual
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Obtener los juegos en el carrito del usuario actual
            var cartItems = await _context.ShoppingCartItems
                .Include(c => c.Game) // Incluir la información del juego asociado
                .Where(c => c.UserId == userId)
                .ToListAsync();

            if (cartItems == null || !cartItems.Any())
            {
                // Si no hay juegos en el carrito, redirigir al carrito de compras
                return RedirectToAction("Cart");
            }

            // Retornar la vista de Checkout con los items del carrito
            return View(cartItems);
        }

        // Acción para procesar la compra (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProcessCheckout()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Obtener los juegos en el carrito del usuario
            var cartItems = await _context.ShoppingCartItems
                .Where(c => c.UserId == userId)
                .ToListAsync();

            if (cartItems == null || !cartItems.Any())
            {
                return RedirectToAction("Cart");
            }

            // Procesar la compra: aquí puedes implementar lógica para registrar la compra
            foreach (var item in cartItems)
            {
                var purchasedGame = new PurchasedGame
                {
                    UserId = userId,
                    GameId = item.GameId,
                    PurchaseDate = DateTime.Now
                };

                _context.PurchasedGames.Add(purchasedGame);
            }

            // Guardar los cambios
            await _context.SaveChangesAsync();

            // Limpiar el carrito después de la compra
            _context.ShoppingCartItems.RemoveRange(cartItems);
            await _context.SaveChangesAsync();

            // Redirigir a una página de confirmación de la compra
            return RedirectToAction("PurchaseConfirmation");
        }

        // Página de confirmación de la compra
        [HttpGet]
        public IActionResult PurchaseConfirmation()
        {
            return View();
        }

        
 [HttpPost]
public async Task<IActionResult> RemoveFromCart(int gameId)
{
    // Verificar si el gameId es válido
    if (gameId <= 0)
    {
        Console.WriteLine($"Error: El ID del juego recibido es inválido. gameId: {gameId}");
        return BadRequest("El ID del juego es inválido.");
    }

    // Obtener el ID del usuario
    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
    
    // Buscar el artículo en el carrito
    var cartItem = await _context.ShoppingCartItems
        .FirstOrDefaultAsync(c => c.UserId == userId && c.GameId == gameId);

    // Verificar si se encontró el artículo
    if (cartItem == null)
    {
        Console.WriteLine($"Error: No se encontró el artículo en el carrito para el gameId: {gameId}");
        return NotFound("El juego no se encuentra en el carrito.");
    }

    // Reducir la cantidad o eliminar el artículo del carrito
    if (cartItem.Quantity > 1)
    {
        cartItem.Quantity--;
    }
    else
    {
        _context.ShoppingCartItems.Remove(cartItem);
    }

    // Guardar cambios en la base de datos
    await _context.SaveChangesAsync();

    // Mensaje de éxito
    TempData["Success"] = "Juego removido del carrito.";
    return RedirectToAction("Cart");
}


    }

}













