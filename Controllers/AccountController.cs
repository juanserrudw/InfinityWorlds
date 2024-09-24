using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using infiniteworlds_fronted.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Authorization;
using System.Net.Mail;
using System.Net;


namespace infiniteworlds_fronted.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailSender _emailSender;

        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, IEmailSender emailSender)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _emailSender = emailSender;
        }


        /* // Método de prueba para enviar correo
        [HttpGet]
        public IActionResult TestEmail()
        {
            var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("22f4710d5c4ab3", "11b365390d2813"),
                EnableSsl = true
            };

            try
            {
                var mailMessage = new MailMessage("from@example.com", "to@example.com", "Test Subject", "This is a test email.");
                mailMessage.IsBodyHtml = true;

                client.Send(mailMessage);
                ViewBag.Message = "Email sent successfully.";
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"Error sending email: {ex.Message}";
            }

            return View();
        }
     */

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else if (result.IsLockedOut)
                {
                    ModelState.AddModelError("", "Su cuenta está bloqueada.");
                    // Mostrar en consola que la cuenta está bloqueada
                    Console.WriteLine("Intento de inicio de sesión fallido: cuenta bloqueada para el usuario " + model.UserName);
                }
                else
                {
                    // Si las credenciales no son válidas
                    ModelState.AddModelError("", "Inicio de sesión no válido. Por favor, revise sus credenciales.");
                    // Mostrar en consola el intento de inicio de sesión fallido
                    Console.WriteLine("Inicio de sesión no válido para el usuario: " + model.UserName);
                }
            }
            else
            {
                // Registrar el estado del modelo si es inválido
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }

            return View(model);
        }




        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
  
    

    [HttpPost]
public async Task<IActionResult> Register(RegisterViewModel model)
{
    if (ModelState.IsValid)
    {
        var user = new IdentityUser { UserName = model.UserName, Email = model.Email };
        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            // Generar token de confirmación de correo
            var emailConfirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var confirmationLink = Url.Action("ConfirmEmail", "Account", 
                new { userId = user.Id, token = emailConfirmationToken }, Request.Scheme);

            // Enviar correo de confirmación
            await _emailSender.SendEmailAsync(user.Email, "Confirmación de Correo Electrónico", 
                $"Por favor confirma tu cuenta haciendo clic en este enlace: <a href='{confirmationLink}'>Confirmar Email</a>");

            // Redirigir a la página de confirmación
            return RedirectToAction("RegistrationConfirmation", "Account");
        }

        // Manejar errores en la creación del usuario
        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }
    }

    // Si el modelo no es válido, volver a la vista de registro
    return View(model);
}

 [HttpGet]
    public IActionResult RegistrationConfirmation()
    {
        return View();
    }
[HttpGet]
public async Task<IActionResult> ConfirmEmail(string userId, string token)
{
    if (userId == null || token == null)
    {
        return RedirectToAction("Error", "Home");
    }

    var user = await _userManager.FindByIdAsync(userId);
    if (user == null)
    {
        return RedirectToAction("Error", "Home");
    }

    var result = await _userManager.ConfirmEmailAsync(user, token);
    if (result.Succeeded)
    {
        return View("ConfirmEmail");
    }

    return View("Error");
}

/* 
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.UserName, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

                // Agregar registro de errores
                foreach (var error in result.Errors)
                {
                    // Registrar errores para depuración
                    Console.WriteLine(error.Description);
                    ModelState.AddModelError("", error.Description);
                }
            }
            else
            {
                // Registrar el estado del modelo
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }

            return View(model);
        } */




        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        // GET: ForgotPassword
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        // POST: ForgotPassword
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            Console.WriteLine($"Se empeza a ejecutar el metodo forgot pasasworr: {email}");
            var user = await _userManager.FindByEmailAsync(email);
            //  bool isEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);
            Console.WriteLine($"aquiva  encuentra el user: {user}");
            if (user == null)
            {
                return RedirectToAction("ForgotPasswordConfirmation", "Account");
            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                // Enviar correo de confirmación
                var emailConfirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = emailConfirmationToken }, Request.Scheme);
                // Aquí envías el email con el enlace de confirmación (usa tu servicio de email)

                Console.WriteLine($"Correo de confirmación enviado a: {user.Email}");
                return RedirectToAction("ForgotPasswordConfirmation", "Account");
            }
            //Console.WriteLine($"aquiva  encuentra el is emailconfirmed: {isEmailConfirmed}");
            //  if (user == null || !isEmailConfirmed)
            // {
            //     // No mostrar mensajes de error específicos por razones de seguridad
            //     return RedirectToAction("ForgotPasswordConfirmation", "Account");
            // } 
            /*  if (user == null)
     {
         Console.WriteLine("Usuario no encontrado.");
         return RedirectToAction("ForgotPasswordConfirmation");
     }

     bool isEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);
     if (!isEmailConfirmed)
     {
         Console.WriteLine("El email no está confirmado.");
         return RedirectToAction("Account");
     } */

            Console.WriteLine("aquiva  encuentra la ejecucionnndel esot");
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var resetLink = Url.Action("ResetPassword", "Account", new { token, email = user.Email }, Request.Scheme);

            // Envía el correo electrónico
            Console.WriteLine("Enviando correo de recuperación de contraseña a: " + user.Email);
            await _emailSender.SendEmailAsync(user.Email, "Recuperación de Contraseña",
                $"Haga clic en este enlace para restablecer su contraseña: <a href='{resetLink}'>Restablecer Contraseña</a>");
            Console.WriteLine("Correo enviado con éxito.");
            return RedirectToAction("ForgotPasswordConfirmation", "Account");
        }

        // GET: ResetPassword
        [HttpGet]
        public IActionResult ResetPassword(string token = null)
        {
            if (token == null)
            {
                return BadRequest("A token is required for password reset.");
            }

            // Crear una instancia de ResetPasswordViewModel con todas las propiedades requeridas inicializadas
            var model = new ResetPasswordViewModel
            {
                Token = token,
                Email = string.Empty,  // Inicializar como vacío
                Password = string.Empty,  // Inicializar como vacío
                ConfirmPassword = string.Empty  // Inicializar como vacío
            };

            return View(model);
        }

        // POST: ResetPassword
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return RedirectToAction(nameof(ResetPasswordConfirmation));
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (result.Succeeded)
            {
                // Enviar correo de confirmación
                await _emailSender.SendEmailAsync(model.Email, "Contraseña Restablecida", "Tu contraseña ha sido restablecida con éxito.");
                return RedirectToAction("Login", "Account");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);
        }

        // GET: ForgotPasswordConfirmation
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        // GET: ResetPasswordConfirmation
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }
    }
}
