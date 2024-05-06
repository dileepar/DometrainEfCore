using Dometrain.EFCore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Dometrain.EFCore.API.Data;

public class MovieContext : DbContext
{
    public DbSet<Movie> Movies => Set<Movie>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Data Source=Localhost; Initial Catalog=MoviesDB; User Id=sa; Password=MyPassword123;TrustServerCertificate=True;");
        
        base.OnConfiguring(optionsBuilder);
    }
}