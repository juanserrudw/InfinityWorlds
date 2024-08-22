using System.ComponentModel.DataAnnotations;

namespace infiniteworlds_frontend.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required]
        public required string Name { get; set; }

        public  string? Descripcion { get; set; }
        public required string Genero { get; set; }

        public DateTime ReleaseDate { get; set; }

        // Relationships
        public ICollection<Player>? Players { get; set; }
    }
}
