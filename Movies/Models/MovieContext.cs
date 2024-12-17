using Microsoft.EntityFrameworkCore;
namespace Movies.Models
{
	public class MovieContext : DbContext
	{
		public DbSet<Movie> Movies { get; set; } = null!;
		public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Movie>().HasData(
				new Movie() { MovieId = 123, Name = "The God Father", Year = 2010, Rating = 5 },
                new Movie() { MovieId = 523, Name = "Kill Bill", Year = 2008, Rating = 4 },
                new Movie() { MovieId = 1233, Name = "Interstellar", Year = 2015, Rating = 5 },
                new Movie() { MovieId = 223, Name = "Scream", Year = 1972, Rating = 2 }

            );
		}
	}
}

