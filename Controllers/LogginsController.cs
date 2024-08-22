
using Microsoft.AspNetCore.Mvc;
using infiniteworlds_frontend.Models;
using Microsoft.EntityFrameworkCore;
using infiniteworlds_frontend.Data;
using Microsoft.AspNetCore.JsonPatch;

namespace infiniteworlds_frontend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogginsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LogginsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var loggins = await _context.Loggins.ToListAsync();
            return View(loggins);
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var loggin = await _context.Loggins.FindAsync(id);
            if (loggin == null)
            {
                return NotFound();
            }

            return View(loggin);
        }


        // POST: api/Users
        [HttpPost]
        public async Task<IActionResult> Create([Bind("LogginId,UserId,AuthenticationId,LoginTime,Success")] Loggin loggin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loggin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loggin);
        }


        // PUT: api/Users/5
        // PUT: api/Loggins/5
[HttpPut("{id}")]
public async Task<IActionResult> Edit(int id, [FromBody] Loggin loggin)
{
    if (id != loggin.LogginId)
    {
        return BadRequest();
    }

    if (ModelState.IsValid)
    {
        try
        {
            _context.Update(loggin); // Actualiza el registro en la base de datos
            await _context.SaveChangesAsync(); // Guarda los cambios
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!LogginExists(loggin.LogginId))
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

// Método auxiliar para verificar si el registro Loggin existe
private bool LogginExists(int id)
{
    return _context.Loggins.Any(e => e.LogginId == id);
}



        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var loggin = await _context.Loggins.FindAsync(id);
            if (loggin == null)
            {
                return NotFound();
            }

            _context.Loggins.Remove(loggin);
            await _context.SaveChangesAsync();

            return NoContent(); // 204 No Content
        }
   
   
   // PATCH: api/Loggins/5
[HttpPatch("{id}")]
public async Task<IActionResult> PatchLogin(int id, [FromBody] JsonPatchDocument<Loggin> patchDoc)
{
    if (patchDoc == null)
    {
        return BadRequest("Patch document is null.");
    }

    var loggin = await _context.Loggins.FindAsync(id);
    if (loggin == null)
    {
        return NotFound();
    }

    // Aplicar el parche al objeto Loggin encontrado
    patchDoc.ApplyTo(loggin, ModelState);

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
        if (!LogginExists(id))
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



