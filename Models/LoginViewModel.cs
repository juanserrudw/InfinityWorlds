using System.ComponentModel.DataAnnotations;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
namespace infiniteworlds_fronted.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [Display(Name = "Username")]
         public required string UserName { get; set; }
        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Por favor, ingrese un correo electrónico válido.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [DataType(DataType.Password, ErrorMessage = "El formato de la contraseña no es válido. Debe contener almenos una  mayuscula y un numero y minimo 6 caracteres.")]
        public required string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}