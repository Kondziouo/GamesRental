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
                            Image = "https://www.fifplay.com/img/public/fifa-23-cover-star-kylian-mbappe.jpg",
                            Description = "FIFA 23 is a football video game published by Electronic Arts.",
                            PricePerMonth = 30,
                            Price = 249
                         },
                        new Game()
                        {
                            Title = "God of War",
                            Image = "https://www.mobygames.com/images/covers/l/474565-god-of-war-playstation-4-front-cover.png",
                            Description = "In God of War, players control Kratos, a Spartan warrior who is sent by the Greek gods to kill Ares, the god of war.",
                            PricePerMonth = 50,
                            Price = 299
                        },
                        new Game()
                        {
                            Title = "Elden Ring",
                            Image = "https://static.techspot.com/images2/news/bigimage/2022/03/2022-03-17-image-37-j_1100.webp",
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

