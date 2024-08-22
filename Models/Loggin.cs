using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace infiniteworlds_frontend.Models{

    public class Loggin{
    [Key]
    public int LogginId { get; set; }
    public int UserId { get; set; }
    public int AuthenticationId { get; set; }
    public DateTime LoginTime { get; set; }
    public bool Success { get; set; }

    // Navigation properties
    public User? User { get; set; }
    public Authentication? Authentication { get; set; }
    }

}