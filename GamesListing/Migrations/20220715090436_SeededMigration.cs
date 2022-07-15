using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesListing.Migrations
{
    public partial class SeededMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "Bayonetta", 8.9f },
                    { 2, "Devil May Cry 5: Special Edition", 8.4f },
                    { 3, "Tales of Arise", 8.7f }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "https://store.steampowered.com/", "Steam" },
                    { 2, "https://www.origin.com/en-us/store/", "Origin" },
                    { 3, "https://www.uplay.com/en-us/", "Uplay" },
                    { 4, "https://store.epicgames.com/en-US/", "Epic Games Store" },
                    { 5, "https://www.xbox.com/pt-BR/games/all-games", "Xbox" }
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
                table: "Stores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
