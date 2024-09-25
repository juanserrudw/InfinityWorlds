using Bogus;
using infiniteworlds_fronted.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public static class UserSeed
{
    public static void SeedUsers(this ModelBuilder modelBuilder)
    {
        var faker = new Faker<IdentityUser>()
           // .RuleFor(u => u.UserId, f => f.IndexFaker + 1) // Asigna un ID único
            .RuleFor(u => u.UserName, f => f.Internet.UserName()) // Nombre de usuario
            .RuleFor(u => u.PasswordHash, f => f.Internet.Password(8, true)) // Contraseña
            .RuleFor(u => u.Email, f => f.Internet.Email());// Correo electrónico
            // Puedes agregar otros campos aquí si es necesario
           // .RuleFor(u => u.CreatedAt, f => f.Date.Past(1)); // Fecha de creación

        var users = faker.Generate(10); // Genera 50 usuarios

        modelBuilder.Entity<IdentityUser>().HasData(users);
    }
}
