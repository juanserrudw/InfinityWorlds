using System.ComponentModel.DataAnnotations;
using infiniteworlds_frontend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
namespace infiniteworlds_fronted.Models
{
    public class PurchasedGame
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public int GameId { get; set; }
    public DateTime PurchaseDate{get; set;}
    public virtual IdentityUser User { get; set; }
    public virtual Game Game { get; set; }
}

}