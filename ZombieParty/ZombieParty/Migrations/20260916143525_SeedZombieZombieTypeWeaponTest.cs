using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    /// <inheritdoc />
    public partial class SeedZombieZombieTypeWeaponTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "WeaponId", "CreatedDate", "Description", "Force", "Image", "Name", "Price", "Qty", "QtyBought" },
                values: new object[] { 3, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The best gun in the game", 160m, "https://valorantstrike.com/valorant-primordium-skins/", "Primoridum Vandal", 2175m, 20, 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 3);
        }
    }
}
