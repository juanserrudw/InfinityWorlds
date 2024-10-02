using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace infiniteworlds_fronted.Migrations
{
    /// <inheritdoc />
    public partial class AddPurchaseAtriibut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "PurchasedGames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "PurchasedGames");
        }
    }
}
