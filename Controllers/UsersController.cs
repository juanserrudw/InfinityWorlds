using Microsoft.AspNetCore.Mvc;
using infiniteworlds_frontend.Models;
using Microsoft.EntityFrameworkCore;
using infiniteworlds_frontend.Data;
using Microsoft.AspNetCore.JsonPatch;

namespace infiniteworlds_frontend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }


        // POST: api/Users
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,UserName,LastName,Email,PasswordHash")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }


        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
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


        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent(); // 204 No Content
        }
   
   
   [HttpPatch("{id}")]
public async Task<IActionResult> PatchUser(int id, [FromBody] JsonPatchDocument<User> patchDoc)
{
    if (patchDoc == null)
    {
        return BadRequest("Patch document is null.");
    }

    var user = await _context.Users.FindAsync(id);
    if (user == null)
    {
        return NotFound();
    }

    // Aplicar el parche al usuario encontrado
    patchDoc.ApplyTo(user, ModelState);

    // Verificar el estado del modelo después de aplicar el parche
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }

    try
    {
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (!UserExists(id))
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






        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
