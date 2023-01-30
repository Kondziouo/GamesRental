using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesRental.Migrations
{
    public partial class employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "ContactNumber", "DateOfBirth", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "425 532 841", new DateTime(1985, 3, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), "james.green@gmail.com", "James", "Green" },
                    { 2, "421 298 915", new DateTime(1994, 3, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "tom.davies@gmail.com", "Tom", "Davies" },
                    { 3, "924 941 012", new DateTime(1975, 9, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), "bush@gmail.com", "Jean", "Bush" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { 5, "In God of War, players control Kratos, a Spartan warrior who is sent by the Greek gods to kill Ares, the god of war. As the story progresses, Kratos is revealed to be Ares' former servant, who had been tricked into killing his own family and is haunted by terrible nightmares.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756274/nosaemw1eb8gockduumq.jpg", 40.00m, "God of war" },
                    { 6, "Immortality is the indefinite continuation of a person's existence, even after death. In common parlance, immortality is virtually indistinguishable from afterlife, but philosophically speaking, they are not identical.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756385/yniwzfje8mc5xwudfhjo.jpg", 19.99m, "Immortality" },
                    { 37, "Lost, alone and separated from family, a stray cat must untangle an ancient mystery to escape a long-forgotten city. Stray is a third-person cat adventure game set amidst the detailed, neon-lit alleys of a decaying cybercity and the murky environments of its seedy underbelly.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756441/mizrusvx8omejavlccua.jpg", 29.99m, "Stray" },
                    { 38, "NORCO is a Southern Gothic point & click narrative adventure that immerses the player in the sinking suburbs and verdant industrial swamps of a distorted South Louisiana. Your brother Blake has gone missing in the aftermath of your mother's death.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756474/eqnullat0nnnuignobfr.jpg", 18.00m, "Norco" },
                    { 39, "Stranded in a ruined land, and armed with only your own curiosity, you will confront colossal beasts, collect strange and powerful items, and unravel long-lost secrets. Stories say that a great treasure is hidden somewhere in this land.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756549/psjlu6es1gqdlci6ujqa.jpg", 29.99m, "Tunic" },
                    { 40, "Cult of the Lamb casts players in the role of a possessed lamb saved from annihilation by an ominous stranger and must repay their debt by building a loyal following in his name.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756589/tf7tonfsxdjcu1yqonhg.jpg", 29.98m, "Cult of the Lamb" },
                    { 41, "The player assumes a detective role in connecting together the details of the narrative from eleven cases, placing the player at or shortly after a static point in time where a central character in the narrative has met their death.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756675/c7xcodbhrxl6wlzp6tjq.jpg", 12.74m, "The Case of the Golden Idol" },
                    { 42, "It was announced in December 2017, and was released on October 28, 2022. The game follows the titular angel-hunting witch Bayonetta, who must face against man-made bioweapons called Homunculi, and an entity known as the Singularity which threatens to destroy the multiverse.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756728/a7n10bqmpryi0leup2t6.jpg", 49.95m, "Bayonetta 3" },
                    { 43, "Total War is a series of strategy games developed by British developer Creative Assembly for personal computers. They combine turn-based strategy and resource management with real-time tactical control of battles.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756765/al8cjf9tfly9izjsp05h.jpg", 59.99m, "Total War: Warhammer III" },
                    { 44, "Splatoon is a third-person shooter developed and published by Nintendo. The game features battles between Inklings, using weaponized ink to cover territory and \"splat\" opponents. The game was first revealed at the Nintendo E3 2014 Digital Event and was released for the Wii U on 29 May 2015.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756884/lexygrrjh1git6qxl76q.jpg", 39.99m, "Splatoon 3" },
                    { 45, "In the story of Neon White, Heaven deals with a demon infestation, and a group of assassins called Neons are getting a chance to stay in Heaven by competing against each other in dealing with the demon threat.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756937/hm4h0tw3plhkkmtklvtw.jpg", 24.99m, "Neon White" },
                    { 46, "Pentiment is a narrative adventure role-playing video game set in Bavaria in the 16th century.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674757083/hlmdovah56su3ye8yfdy.jpg", 19.99m, "Pentiment" },
                    { 47, "Horizon Forbidden West is a 2022 action role-playing game developed by Guerrilla Games and published by Sony Interactive Entertainment. The sequel to 2017's Horizon Zero Dawn, the game is set in a post-apocalyptic version of the Western United States recovering from the aftermath of an extinction event caused by a rogue robot swarm.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674757067/vel3aepnxv5pwqldqgw5.jpg", 70.00m, "Horizon Forbidden West" },
                    { 48, "OlliOlli World is a sports video game developed by Roll7 and published by Private Division. As the third game in the OlliOlli series, the game was released for Microsoft Windows, Nintendo Switch, PlayStation 4, PlayStation 5, Xbox One, and Xbox Series X/S in February 2022.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674757145/r5knzzhs4mgtmckqjbwd.jpg", 29.99m, "OlliOlli World" },
                    { 49, "Return to Monkey Island is a point-and-click adventure game developed by Terrible Toybox and published by Devolver Digital. The sixth Monkey Island game, it was released for macOS, Nintendo Switch, and Windows on September 19, 2022.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674757192/jkzyzvvytllnzferyrgu.jpg", 26.00m, "Return to Monkey Island" },
                    { 50, "A Little To The Left is something like a non-traditional point-and-click. Players don't move through the world, but instead, interact by just dragging and dropping objects around the screen", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674757249/clackjfg16kzplzxgbvj.jpg", 13.55m, "A Little to the Left" },
                    { 51, "The final component of the gameplay worth mentioning is the Snap mechanic: At any point during the match, players can “snap” to increase the Cosmic Cubes (rank trophies) that they will win or lose in the match", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674757318/kcpvggh63ffvpi8ym8io.jpg", 0.01m, "Marvel Snap" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 51);
        }
    }
}
