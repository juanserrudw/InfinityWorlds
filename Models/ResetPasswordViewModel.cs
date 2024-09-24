using System.ComponentModel.DataAnnotations;

public class ResetPasswordViewModel
{
    [Required]
    public required string Token { get; set; }

    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public required string Password { get; set; }

    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
    public required string ConfirmPassword { get; set; }
}
