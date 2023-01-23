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
                            Title = "Fifa 23",
                            Image = "https://www.sport.pl/sport/7,164252,28703584,znamy-okladki-fifa-23-ostatni-raz-z-ta-nazwa.html",
                            Description = "FIFA 23 is a football video game published by Electronic Arts.",
                            PricePerMonth = 30,
                            Price = 249
                         },
                        new Game()
                        {
                            Title = "God of War",
                            Image = "https://www.mobygames.com/game/god-of-war_/cover-art/gameCoverId,474565/",
                            Description = "In God of War, players control Kratos, a Spartan warrior who is sent by the Greek gods to kill Ares, the god of war.",
                            PricePerMonth = 50,
                            Price = 299
                        },
                        new Game()
                        {
                            Title = "Elden Ring",
                            Image = "https://i.redd.it/bueqtztxmnj81.png",
                            Description = "Elden Ring is an action role-playing game played in a third person perspective, with gameplay focusing on combat and exploration.",
                            PricePerMonth = 19,
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
                            LastName = "Cruse"
                        },
                    });
                    context.SaveChanges();
                }
            }
        }

    }
    
}

