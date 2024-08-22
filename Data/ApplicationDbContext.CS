using infiniteworlds_frontend.Models;
using Microsoft.EntityFrameworkCore;

namespace infiniteworlds_frontend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Authentication> Authentications { get; set; }
        public DbSet<Loggin> Loggins { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Loggin>()
        .HasOne(l => l.User)
        .WithMany()
        .HasForeignKey(l => l.UserId)
        .OnDelete(DeleteBehavior.NoAction);

    modelBuilder.Entity<Loggin>()
        .HasOne(l => l.Authentication)
        .WithMany()
        .HasForeignKey(l => l.AuthenticationId)
        .OnDelete(DeleteBehavior.NoAction);
}


        
    }
}
