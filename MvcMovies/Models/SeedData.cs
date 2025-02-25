﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovies.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovies.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }
                context.AddRange(
                         new Movie()
                         {
                             Title = "When Harry Met Sally",
                             ReleaseDate = DateTime.Parse("1989-2-12"),
                             Genre = "Romantic Comedy",
                             Price = 7.99M
                         },
                         new Movie()
                         {
                             Title = "Ghostbusters ",
                             ReleaseDate = DateTime.Parse("1984-3-13"),
                             Genre = "Comedy",
                             Price = 8.99M
                         },
                         new Movie()
                         {
                             Title = "Ghostbusters 2",
                             ReleaseDate = DateTime.Parse("1986-2-23"),
                             Genre = "Comedy",
                             Price = 9.99M
                         },
                         new Movie()
                         {
                             Title = "Ghostbusters 2",
                             ReleaseDate = DateTime.Parse("1986-2-23"),
                             Genre = "Comedy",
                             Price = 9.99M
                         }
                         );

                context.SaveChanges();
            }
        }
    }
}

