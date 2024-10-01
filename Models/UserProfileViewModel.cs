using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace infiniteworlds_fronted.Models{
    public class UserProfileViewModel
    {

    [Key] 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public required string UserProfileId { get; set; }
    [StringLength(100, ErrorMessage = "El apellido no puede exceder los 100 caracteres.")]

    public string? LastName { get; set; }
    [StringLength(4000, ErrorMessage = "La descripción no puede exceder los 4000 caracteres.")]

    public string? Description { get; set; }
    public DateTime DateJoined { get; set; }
    [Url(ErrorMessage = "La URL de la imagen no es válida.")]
    public string? ProfilePictureUrl { get; set; }

     public required string UserId { get; set; } 
    }
}