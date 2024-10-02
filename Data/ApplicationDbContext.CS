using infiniteworlds_fronted.Models;
using infiniteworlds_frontend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace infiniteworlds_frontend.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // public DbSet<User> Users { get; set; }
        // public DbSet<Authentication> Authentications { get; set; }
        //public DbSet<Loggin> Loggins { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<UserProfileViewModel> userProfileViewModels { get; set; }
        public DbSet<PurchasedGame> PurchasedGames { get; set; }
          public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ShoppingCartItem>()
            .HasKey(c => c.Id);
            
        modelBuilder.Entity<ShoppingCartItem>()
            .HasOne(c => c.Game)
            .WithMany()
            .HasForeignKey(c => c.GameId);
             modelBuilder.Entity<Game>()
            .Property(g => g.Price)
            .HasColumnType("decimal(18, 2)"); // Define precisión y escala

        //      modelBuilder.Entity<PurchasedGame>()
        //     .HasKey(pg => pg.Id);

        // modelBuilder.Entity<PurchasedGame>()
        //     .HasOne(pg => pg.User)
        //     .WithMany() // No es necesario definir la colección en IdentityUser
        //     .HasForeignKey(pg => pg.UserId)
        //     .OnDelete(DeleteBehavior.Cascade); // Manejo de eliminación en cascada

        // modelBuilder.Entity<PurchasedGame>()
        //     .HasOne(pg => pg.Game)
        //     .WithMany(g => g.PurchasedGames)
        //     .HasForeignKey(pg => pg.GameId);

            // modelBuilder.Entity<UserProfileViewModel>()
            //         .HasKey(up => up.UserProfileId);
            base.OnModelCreating(modelBuilder);
            // Llama a los métodos de siembra para las tablas
            // GameSeed.SeedGames(modelBuilder);
            // UserSeed.SeedUsers(modelBuilder);
            // modelBuilder.SeedAdminUser();

        }
    }
}
