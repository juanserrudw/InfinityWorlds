using System.ComponentModel.DataAnnotations;

namespace infiniteworlds_fronted.Models
{
    public class RegisterViewModel
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

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public required string ConfirmPassword { get; set; }
    }
}
