using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-06-03"),
                        Genre = "Drama",
                        Price = 7.99M,
                        Rating = "PG",
                        ImagePath = "~/content/images/17miracles.jpg"
                    },

                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("2013-10-09"),
                        Genre = "Action",
                        Price = 8.99M,
                        Rating = "PG-13",
                        ImagePath = "~/content/images/thesaratovapproach.jpg"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2002-04-12"),
                        Genre = "Adventure",
                        Price = 9.99M,
                        Rating = "PG",
                        ImagePath = "~/content/images/theothersideofheaven.jpg"
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-01-30"),
                        Genre = "Comedy",
                        Price = 3.99M,
                        Rating = "PG",
                        ImagePath = "~/content/images/thesinglesward.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}