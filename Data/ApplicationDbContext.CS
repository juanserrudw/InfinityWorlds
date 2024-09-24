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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfileViewModel>()
                    .HasKey(up => up.UserProfileId);
            base.OnModelCreating(modelBuilder);


        }



    }
}
