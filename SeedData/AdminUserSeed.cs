using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using infiniteworlds_fronted.Models; 

public static class AdminUserSeed
{
    public static void SeedAdminUser(this ModelBuilder modelBuilder)
    {
        // Crear un ID único para el rol y el usuario
        var adminRoleId = "role-admin-id";
        var adminUserId = "user-admin-id";

        // Crear y seedear el rol "Admin"
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = adminRoleId,
            Name = "Admin",
            NormalizedName = "ADMIN"
        });

        // Crear el usuario administrador
        var hasher = new PasswordHasher<IdentityUser>();
        var adminUser = new IdentityUser
        {
            Id = adminUserId,
            UserName = "admin",  // Esto cumple con el campo "UserName" del modelo
            NormalizedUserName = "ADMIN",
            Email = "admin@example.com",  // Esto cumple con el campo "Email"
            NormalizedEmail = "ADMIN@EXAMPLE.COM",
            EmailConfirmed = true,
            SecurityStamp = string.Empty,
            PasswordHash = hasher.HashPassword(null, "Admin@123")  // Cumple con las reglas de "Password"
        };

        // Seedear el usuario administrador
        modelBuilder.Entity<IdentityUser>().HasData(adminUser);

        // Asignar el rol "Admin" al usuario administrador
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = adminRoleId,
            UserId = adminUserId
        });
    }
}
