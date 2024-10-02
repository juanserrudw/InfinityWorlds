using System.ComponentModel.DataAnnotations;
using infiniteworlds_fronted.Models;

namespace infiniteworlds_frontend.Models
{
    public class ShoppingCartItem
{
    public int Id { get; set; }
    public string UserId { get; set; } // Para relacionar el carrito con el usuario
    public int GameId { get; set; }
    public Game Game { get; set; }
    public int Quantity { get; set; } = 1; // Cantidad del mismo juego en el carrito
}

}
