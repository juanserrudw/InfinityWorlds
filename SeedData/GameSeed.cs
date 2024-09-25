using Bogus;
using infiniteworlds_frontend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public static class GameSeed
{
    public static void SeedGames(this ModelBuilder modelBuilder)
    {
        var faker = new Faker<Game>()
            .RuleFor(g => g.GameId, f => f.IndexFaker + 1) // Asigna un ID único
            .RuleFor(g => g.Name, f => f.Commerce.ProductName()) // Nombre del juego
            .RuleFor(g => g.Descripcion, f => f.Lorem.Paragraph()) // Descripción
            .RuleFor(g => g.Genero, f => f.Random.ListItem(new[] { "Action", "Adventure", "RPG", "Shooter", "Strategy", "Puzzle" })) // Género
            .RuleFor(g => g.ImageFilePath, _ => "https://picsum.photos/200/300") // URL de imagen fija
            .RuleFor(g => g.ReleaseDate, f => f.Date.Past(10)); // Fecha de lanzamiento

        var games = faker.Generate(50); // Genera 50 juegos

        modelBuilder.Entity<Game>().HasData(games);
    }
}
