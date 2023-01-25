using GamesRental.Models;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using System.Net;

namespace GamesRental.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Games.Any())
                {
                    context.Games.AddRange(new List<Game>()
                    {
                        new Game()
                        {
                            Image = "https://static.techspot.com/images2/news/bigimage/2022/03/2022-03-17-image-37-j_1100.webp",
                            Title = "Game1",
                            Description = "Elden Ring is an action role-playing game played in a third person perspective, with gameplay focusing on combat and exploration.",
                            Price = 199
                         },
                        new Game()
                        {
                            Image = "https://static.techspot.com/images2/news/bigimage/2022/03/2022-03-17-image-37-j_1100.webp",
                            Title = "Game1",
                            Description = "Elden Ring is an action role-playing game played in a third person perspective, with gameplay focusing on combat and exploration.",
                            Price = 199
                        },
                        new Game()
                        {
                            Image = "https://static.techspot.com/images2/news/bigimage/2022/03/2022-03-17-image-37-j_1100.webp",
                            Title = "Game1",
                            Description = "Elden Ring is an action role-playing game played in a third person perspective, with gameplay focusing on combat and exploration.",
                            Price = 199
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Customers.Any())
                {
                    context.Customers.AddRange(new List<Customer>()
                    {
                        new Customer()
                        {
                            FirstName = "Robinson",
                            LastName = "Cruse",
                            email = "robinson@test"
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

    }
    
}

