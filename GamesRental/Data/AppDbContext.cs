using GamesRental.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesRental.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Game>().HasData(new Game[]
            {
                new Game
                {
                    Id = 1,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756169/iol0eltwhjl2e4t0ru2j.jpg",
                    Title = "Skyrim",
                    Description = "The Elder Scrolls V: Skyrim is an action role-playing video game developed by Bethesda Game Studios and published by Bethesda Softworks. It is the fifth main installment in The Elder Scrolls series, following 2006's The Elder Scrolls IV: Oblivion, and was released worldwide for Microsoft Windows, PlayStation 3, and Xbox 360 on November 11, 2011.",
                    Price = 6.99M
                },
                new Game
                {
                    Id = 2,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674755549/ha1q3ipzh1xcdzkanqwf.jpg",
                    Title = "Fifa 23",
                    Description = "FIFA 23 is a football video game published by Electronic Arts. It is the 30th installment in the FIFA series that is developed by EA Sports, and the final installment under the FIFA banner, and released worldwide on 30 September 2022 for PC, Nintendo Switch, PlayStation 4, PlayStation 5, Xbox One and Xbox Series X/S.",
                    Price = 68.00M
                },
                new Game
                {
                    Id = 3,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674755962/baxtap8rqrscyror5i9t.jpg",
                    Title = "Elden Ring",
                    Description = "Elden Ring is an action role-playing game played in a third person perspective, with gameplay focusing on combat and exploration. It features elements similar to those found in other games developed by FromSoftware, such as the Dark Souls series, Bloodborne, and Sekiro: Shadows Die Twice.",
                    Price = 48.00M
                },
                new Game
                {
                    Id = 4,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756102/femn6kdwsbnp9hjirbwh.jpg",
                    Title = "Minecraft",
                    Description = "Minecraft is a video game in which players create and break apart various kinds of blocks in three-dimensional worlds. The game's two main modes are Survival and Creative. In Survival, players must find their own building supplies and food.",
                    Price = 9.99M
                },
            });
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }

}
