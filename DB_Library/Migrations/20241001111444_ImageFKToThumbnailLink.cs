using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Library.Migrations
{
    /// <inheritdoc />
    public partial class ImageFKToThumbnailLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbnailLink",
                table: "Gallery");

            migrationBuilder.AddColumn<Guid>(
                name: "ThumbnailLinkID",
                table: "Gallery",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Gallery_ThumbnailLinkID",
                table: "Gallery",
                column: "ThumbnailLinkID");

            migrationBuilder.AddForeignKey(
                name: "FK_Gallery_ImageLinks_ThumbnailLinkID",
                table: "Gallery",
                column: "ThumbnailLinkID",
                principalTable: "ImageLinks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gallery_ImageLinks_ThumbnailLinkID",
                table: "Gallery");

            migrationBuilder.DropIndex(
                name: "IX_Gallery_ThumbnailLinkID",
                table: "Gallery");

            migrationBuilder.DropColumn(
                name: "ThumbnailLinkID",
                table: "Gallery");

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailLink",
                table: "Gallery",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
