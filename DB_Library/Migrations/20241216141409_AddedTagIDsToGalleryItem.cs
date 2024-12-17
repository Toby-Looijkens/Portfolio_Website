using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Library.Migrations
{
    /// <inheritdoc />
    public partial class AddedTagIDsToGalleryItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TagIDS",
                table: "Gallery",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TagIDS",
                table: "Gallery");
        }
    }
}
