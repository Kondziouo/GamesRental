using GamesRental.Models;
using GamesRental.Tools;
using Microsoft.AspNetCore.Identity;
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
                 new Game
                {
                    Id = 5,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756274/nosaemw1eb8gockduumq.jpg",
                    Title = "God of war",
                    Description = "In God of War, players control Kratos, a Spartan warrior who is sent by the Greek gods to kill Ares, the god of war. As the story progresses, Kratos is revealed to be Ares' former servant, who had been tricked into killing his own family and is haunted by terrible nightmares.",
                    Price = 40.00M
                },
                  new Game
                {
                    Id = 6,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756385/yniwzfje8mc5xwudfhjo.jpg",
                    Title = "Immortality",
                    Description = "Immortality is the indefinite continuation of a person's existence, even after death. In common parlance, immortality is virtually indistinguishable from afterlife, but philosophically speaking, they are not identical.",
                    Price = 19.99M
                },
                   new Game
                {
                    Id = 37,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756441/mizrusvx8omejavlccua.jpg",
                    Title = "Stray",
                    Description = "Lost, alone and separated from family, a stray cat must untangle an ancient mystery to escape a long-forgotten city. Stray is a third-person cat adventure game set amidst the detailed, neon-lit alleys of a decaying cybercity and the murky environments of its seedy underbelly.",
                    Price = 29.99M
                },
                    new Game
                {
                    Id = 38,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756474/eqnullat0nnnuignobfr.jpg",
                    Title = "Norco",
                    Description = "NORCO is a Southern Gothic point & click narrative adventure that immerses the player in the sinking suburbs and verdant industrial swamps of a distorted South Louisiana. Your brother Blake has gone missing in the aftermath of your mother's death.",
                    Price = 18.00M
                },
                     new Game
                {
                    Id = 39,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756549/psjlu6es1gqdlci6ujqa.jpg",
                    Title = "Tunic",
                    Description = "Stranded in a ruined land, and armed with only your own curiosity, you will confront colossal beasts, collect strange and powerful items, and unravel long-lost secrets. Stories say that a great treasure is hidden somewhere in this land.",
                    Price = 29.99M
                },
                      new Game
                {
                    Id = 40,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756589/tf7tonfsxdjcu1yqonhg.jpg",
                    Title = "Cult of the Lamb",
                    Description = "Cult of the Lamb casts players in the role of a possessed lamb saved from annihilation by an ominous stranger and must repay their debt by building a loyal following in his name.",
                    Price = 29.98M
                },
                       new Game
                {
                    Id = 41,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756675/c7xcodbhrxl6wlzp6tjq.jpg",
                    Title = "The Case of the Golden Idol",
                    Description = "The player assumes a detective role in connecting together the details of the narrative from eleven cases, placing the player at or shortly after a static point in time where a central character in the narrative has met their death.",
                    Price = 12.74M
                },
                        new Game
                {
                    Id = 42,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756728/a7n10bqmpryi0leup2t6.jpg",
                    Title = "Bayonetta 3",
                    Description = "It was announced in December 2017, and was released on October 28, 2022. The game follows the titular angel-hunting witch Bayonetta, who must face against man-made bioweapons called Homunculi, and an entity known as the Singularity which threatens to destroy the multiverse.",
                    Price = 49.95M
                },
                         new Game
                {
                    Id = 43,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756765/al8cjf9tfly9izjsp05h.jpg",
                    Title = "Total War: Warhammer III",
                    Description = "Total War is a series of strategy games developed by British developer Creative Assembly for personal computers. They combine turn-based strategy and resource management with real-time tactical control of battles.",
                    Price = 59.99M
                },
                          new Game
                {
                    Id = 44,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756884/lexygrrjh1git6qxl76q.jpg",
                    Title = "Splatoon 3",
                    Description = "Splatoon is a third-person shooter developed and published by Nintendo. The game features battles between Inklings, using weaponized ink to cover territory and \"splat\" opponents. The game was first revealed at the Nintendo E3 2014 Digital Event and was released for the Wii U on 29 May 2015.",
                    Price = 39.99M
                },
                                     new Game
                {
                    Id = 45,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756937/hm4h0tw3plhkkmtklvtw.jpg",
                    Title = "Neon White",
                    Description = "In the story of Neon White, Heaven deals with a demon infestation, and a group of assassins called Neons are getting a chance to stay in Heaven by competing against each other in dealing with the demon threat.",
                    Price = 24.99M
                },
                                                new Game
                {
                    Id = 46,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674757083/hlmdovah56su3ye8yfdy.jpg",
                    Title = "Pentiment",
                    Description = "Pentiment is a narrative adventure role-playing video game set in Bavaria in the 16th century.",
                    Price = 19.99M
                },
                                                           new Game
                {
                    Id = 47,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674757067/vel3aepnxv5pwqldqgw5.jpg",
                    Title = "Horizon Forbidden West",
                    Description = "Horizon Forbidden West is a 2022 action role-playing game developed by Guerrilla Games and published by Sony Interactive Entertainment. The sequel to 2017's Horizon Zero Dawn, the game is set in a post-apocalyptic version of the Western United States recovering from the aftermath of an extinction event caused by a rogue robot swarm.",
                    Price = 70.00M
                },
                                                                      new Game
                {
                    Id = 48,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674757145/r5knzzhs4mgtmckqjbwd.jpg",
                    Title = "OlliOlli World",
                    Description = "OlliOlli World is a sports video game developed by Roll7 and published by Private Division. As the third game in the OlliOlli series, the game was released for Microsoft Windows, Nintendo Switch, PlayStation 4, PlayStation 5, Xbox One, and Xbox Series X/S in February 2022.",
                    Price = 29.99M
                },
                                                                                 new Game
                {
                    Id = 49,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674757192/jkzyzvvytllnzferyrgu.jpg",
                    Title = "Return to Monkey Island",
                    Description = "Return to Monkey Island is a point-and-click adventure game developed by Terrible Toybox and published by Devolver Digital. The sixth Monkey Island game, it was released for macOS, Nintendo Switch, and Windows on September 19, 2022.",
                    Price = 26.00M
                },
                                                                                            new Game
                {
                    Id = 50,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674757249/clackjfg16kzplzxgbvj.jpg",
                    Title = "A Little to the Left",
                    Description = "A Little To The Left is something like a non-traditional point-and-click. Players don't move through the world, but instead, interact by just dragging and dropping objects around the screen",
                    Price = 13.55M
                },
                                                                                                       new Game
                {
                    Id = 51,
                    Image = "http://res.cloudinary.com/dbtbooroa/image/upload/v1674757318/kcpvggh63ffvpi8ym8io.jpg",
                    Title = "Marvel Snap",
                    Description = "The final component of the gameplay worth mentioning is the Snap mechanic: At any point during the match, players can “snap” to increase the Cosmic Cubes (rank trophies) that they will win or lose in the match",
                    Price = 0.01M
                },

            });

            builder.Entity<Employee>().HasData(new Employee[]
           {
               new Employee
               {
                   Id = 1,
                   FirstName = "James",
                   LastName = "Green",
                   DateOfBirth = new DateTime(1985, 3, 30, 10, 0, 0),
                   ContactNumber = "425 532 841",
                   Email = "james.green@gmail.com"
               },
               new Employee
               {
                   Id = 2,
                   FirstName = "Tom",
                   LastName = "Davies",
                   DateOfBirth = new DateTime(1994, 3, 10, 12, 0, 0),
                   ContactNumber = "421 298 915",
                   Email = "tom.davies@gmail.com"
               },
               new Employee
               {
                   Id = 3,
                   FirstName = "Jean",
                   LastName = "Bush",
                   DateOfBirth = new DateTime(1975, 9, 21, 10, 0, 0),
                   ContactNumber = "924 941 012",
                   Email = "bush@gmail.com"
               }



           });
        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }

}
