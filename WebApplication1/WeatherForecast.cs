using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    public decimal Price { get; set; }
}
public class MvcMovieContext : DbContext
{
    public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movie { get; set; }
}