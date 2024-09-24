using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace infiniteworlds_frontend.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [Required]
        public required string Username { get; set; }
        public required string EstadoCuenta { get; set; }



        // Foreign Key to Game
        // [ForeignKey("Game")]
        // public int GameId { get; set; }
        // public Game? Game { get; set; } 
    }
}
