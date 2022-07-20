using Microsoft.EntityFrameworkCore;
using MovieAPI.Data;

namespace MovieAPI.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieAPIContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MovieAPIContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }
                context.AddRange(
                    new Movie
                    {
                        Title = "Inception",
                        dateTime = DateTime.Now,
                    },
                    new Movie
                    {
                        Title = "Interstellar",
                        dateTime = DateTime.Now,
                    },
                    new Movie
                    {
                        Title = "The Dark Knight",
                        dateTime = DateTime.Now,
                    },
                    new Movie
                    {
                        Title = "The Shawshank Redemption",
                        dateTime = DateTime.Now,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
