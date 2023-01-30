using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesRental.Migrations
{
    public partial class game1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "The Elder Scrolls V: Skyrim is an action role-playing video game developed by Bethesda Game Studios and published by Bethesda Softworks. It is the fifth main installment in The Elder Scrolls series, following 2006's The Elder Scrolls IV: Oblivion, and was released worldwide for Microsoft Windows, PlayStation 3, and Xbox 360 on November 11, 2011.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756169/iol0eltwhjl2e4t0ru2j.jpg", 6.99m, "Skyrim" },
                    { 2, "FIFA 23 is a football video game published by Electronic Arts. It is the 30th installment in the FIFA series that is developed by EA Sports, and the final installment under the FIFA banner, and released worldwide on 30 September 2022 for PC, Nintendo Switch, PlayStation 4, PlayStation 5, Xbox One and Xbox Series X/S.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674755549/ha1q3ipzh1xcdzkanqwf.jpg", 68.00m, "Fifa 23" },
                    { 3, "Elden Ring is an action role-playing game played in a third person perspective, with gameplay focusing on combat and exploration. It features elements similar to those found in other games developed by FromSoftware, such as the Dark Souls series, Bloodborne, and Sekiro: Shadows Die Twice.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674755962/baxtap8rqrscyror5i9t.jpg", 48.00m, "Elden Ring" },
                    { 4, "Minecraft is a video game in which players create and break apart various kinds of blocks in three-dimensional worlds. The game's two main modes are Survival and Creative. In Survival, players must find their own building supplies and food.", "http://res.cloudinary.com/dbtbooroa/image/upload/v1674756102/femn6kdwsbnp9hjirbwh.jpg", 9.99m, "Minecraft" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
