using Microsoft.AspNetCore.Authorization;  // Asegurarse de usar la autorización
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using infiniteworlds_fronted.Models;
using infiniteworlds_frontend.Data;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace infiniteworlds_fronted.Controllers
{
    [Authorize]  // Requiere que el usuario esté autenticado
    public class UserProfileController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        // Inyectamos el DbContext y el UserManager
        public UserProfileController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Método para listar los perfiles de usuario desde la base de datos

        public async Task<IActionResult> Index()
        {
            // Obtenemos el Id del usuario actual
            var userId = _userManager.GetUserId(User);

            // Buscamos el perfil del usuario actual
            var profile = await _context.userProfileViewModels
                                         .FirstOrDefaultAsync(p => p.UserId == userId);

            if (profile == null)
            {
                return NotFound(); // Maneja el caso en que no se encuentre el perfil
            }

            return View(profile);
        }

        // Método para crear un nuevo perfil
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Create(UserProfileViewModel model)
{
    // Obtener el ID del usuario autenticado
    var userId = _userManager.GetUserId(User);

    if (ModelState.IsValid)
    {
        try
        {
            // Asociamos el perfil al usuario autenticado
            model.UserId = userId;
            model.DateJoined = DateTime.Now;  // Establecemos la fecha de creación

            _context.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            
            ModelState.AddModelError("", "Ocurrió un error al guardar el perfil. Inténtalo de nuevo más tarde.");
            Console.WriteLine($"Database saving error: {ex.Message}");
           
        }
    }

    return View(model);
}


// Método GET para mostrar el formulario de edición o creación
[HttpGet]
public async Task<IActionResult> Edit()
{
    // Obtener el ID del usuario autenticado
    var userId = _userManager.GetUserId(User);

    // Buscar el perfil del usuario
    var profile = await _context.userProfileViewModels.FirstOrDefaultAsync(p => p.UserId == userId);
    
    // Si no existe el perfil, crear un nuevo modelo vacío para permitir la creación
    if (profile == null)
    {
        profile = new UserProfileViewModel
        {
            UserProfileId = Guid.NewGuid().ToString(),
            UserId = userId  // Asociar el perfil al usuario autenticado
        };
    }

    return View(profile);  // Mostrar el formulario con los datos actuales (o vacíos si es nuevo)
}

[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Edit(UserProfileViewModel model)
{
    // Obtener el ID del usuario autenticado
    var userId = _userManager.GetUserId(User);

    if (userId != model.UserId)
    {
        return Unauthorized();  // Asegurarse de que el usuario autenticado esté editando su propio perfil
    }

    // Validar si el modelo es válido
    if (ModelState.IsValid)
    {
        // Validar la URL de la imagen
        if (string.IsNullOrEmpty(model.ProfilePictureUrl))
        {
            ModelState.AddModelError("ProfilePictureUrl", "La URL de la imagen es obligatoria.");
        }

        // Intentar guardar el perfil en la base de datos si el modelo es válido
        if (ModelState.IsValid)
        {
            try
            {
                // Buscar el perfil existente en la base de datos
                var existingProfile = await _context.userProfileViewModels.FirstOrDefaultAsync(p => p.UserId == userId);

                // Si no existe el perfil, crear uno nuevo
                if (existingProfile == null)
                {
                    existingProfile = new UserProfileViewModel
                    {
                        UserProfileId = Guid.NewGuid().ToString(),  // Generar un nuevo ID solo al crear
                        UserId = userId,  // Asociar el perfil al usuario autenticado
                        LastName = model.LastName,
                        Description = model.Description,
                        ProfilePictureUrl = model.ProfilePictureUrl,
                        DateJoined = DateTime.Now  // Fecha de creación
                    };

                    _context.Add(existingProfile);
                }
                else
                {
                    // Si existe, asegurarse de que se mantenga el UserProfileId
                    existingProfile.LastName = model.LastName;
                    existingProfile.Description = model.Description;
                    existingProfile.ProfilePictureUrl = model.ProfilePictureUrl;

                    // No modificar el UserProfileId, solo actualizar el perfil
                    _context.Update(existingProfile);
                }

                // Guardar los cambios en la base de datos (crear o actualizar)
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));  // Redirigir al índice después de la edición/creación exitosa
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al guardar el perfil en la base de datos.");
                Console.WriteLine($"Error al guardar el perfil: {ex.Message}");
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

    return View(model);  // Si el modelo no es válido o hay un error, retornar la vista con los datos ingresados
}


        // Método para ver los detalles de un perfil
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profile = await _context.userProfileViewModels
                                        .FirstOrDefaultAsync(m => m.UserProfileId == id && m.UserId == _userManager.GetUserId(User));
            if (profile == null)
            {
                return NotFound();
            }

            return View(profile);
        }

        // Otros métodos (Edit, Delete, etc.) también deben considerar el userId para evitar que un usuario acceda a perfiles de otros.
    }
}
