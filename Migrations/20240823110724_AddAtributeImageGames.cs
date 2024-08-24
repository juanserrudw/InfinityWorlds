using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace infiniteworlds_fronted.Migrations
{
    /// <inheritdoc />
    public partial class AddAtributeImageGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFilePath",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFilePath",
                table: "Games");
        }
    }
}
