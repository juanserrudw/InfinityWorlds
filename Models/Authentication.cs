using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace infiniteworlds_frontend.Models{

    public class Authentication{
    [Key]
        public int AuthenticationId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public  string? AuthToken { get; set; }

        [Required]
        [MaxLength(50)]
        public string? AuthMethod { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Relación con User
        [ForeignKey("UserId")]
        public required User User { get; set; }

        // Relación con Loggin
        public ICollection<Loggin>? Loggins { get; set; }

    }
}