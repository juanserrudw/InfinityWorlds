using System.ComponentModel.DataAnnotations;
using infiniteworlds_fronted.Models;

namespace infiniteworlds_frontend.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        
         [Required(ErrorMessage = "El nombre del juego es obligatorio.")]
         [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public required string Name { get; set; }
         [StringLength(2000, ErrorMessage = "La descripción no puede exceder los 2000 caracteres.")]
        public  string? Descripcion { get; set; }
        [Required(ErrorMessage = "El género del juego es obligatorio.")]
        public required string Genero { get; set; }
        
         [Url(ErrorMessage = "La URL de la imagen no es válida.")]
         [StringLength(255, ErrorMessage = "La ruta del archivo de imagen no puede exceder los 255 caracteres.")]
         public  string? ImageFilePath { get; set; }
           [Required(ErrorMessage = "La fecha de lanzamiento es obligatoria.")]
          
          [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }

        // Relationships
        //  public ICollection<Player>? Players { get; set; } 
         public virtual ICollection<PurchasedGame>? PurchasedGames { get; set; } // Relación inversa
    }
}
