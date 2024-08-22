using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace infiniteworlds_frontend.Models{



public class User
    {
       [Key]
        public int Id { get; set; }

        
        [MaxLength(15)]
        public required string UserName { get; set; }

        [MaxLength(10)]
        public required string LastName { get; set; }

        
        [EmailAddress]
        public required string Email { get; set; }

      
        public required string PasswordHash { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Relación con Authentication
        // public ICollection<Authentication>? Authentications { get; set; }


    }
}
