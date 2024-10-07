using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Library.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DownloadLink_Gallery_GalleryItemID",
                table: "DownloadLink");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageLink_Gallery_GalleryItemID",
                table: "ImageLink");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageLink",
                table: "ImageLink");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DownloadLink",
                table: "DownloadLink");

            migrationBuilder.RenameTable(
                name: "ImageLink",
                newName: "ImageLinks");

            migrationBuilder.RenameTable(
                name: "DownloadLink",
                newName: "DownloadLinks");

            migrationBuilder.RenameIndex(
                name: "IX_ImageLink_GalleryItemID",
                table: "ImageLinks",
                newName: "IX_ImageLinks_GalleryItemID");

            migrationBuilder.RenameIndex(
                name: "IX_DownloadLink_GalleryItemID",
                table: "DownloadLinks",
                newName: "IX_DownloadLinks_GalleryItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageLinks",
                table: "ImageLinks",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DownloadLinks",
                table: "DownloadLinks",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DownloadLinks_Gallery_GalleryItemID",
                table: "DownloadLinks",
                column: "GalleryItemID",
                principalTable: "Gallery",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageLinks_Gallery_GalleryItemID",
                table: "ImageLinks",
                column: "GalleryItemID",
                principalTable: "Gallery",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DownloadLinks_Gallery_GalleryItemID",
                table: "DownloadLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageLinks_Gallery_GalleryItemID",
                table: "ImageLinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageLinks",
                table: "ImageLinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DownloadLinks",
                table: "DownloadLinks");

            migrationBuilder.RenameTable(
                name: "ImageLinks",
                newName: "ImageLink");

            migrationBuilder.RenameTable(
                name: "DownloadLinks",
                newName: "DownloadLink");

            migrationBuilder.RenameIndex(
                name: "IX_ImageLinks_GalleryItemID",
                table: "ImageLink",
                newName: "IX_ImageLink_GalleryItemID");

            migrationBuilder.RenameIndex(
                name: "IX_DownloadLinks_GalleryItemID",
                table: "DownloadLink",
                newName: "IX_DownloadLink_GalleryItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageLink",
                table: "ImageLink",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DownloadLink",
                table: "DownloadLink",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DownloadLink_Gallery_GalleryItemID",
                table: "DownloadLink",
                column: "GalleryItemID",
                principalTable: "Gallery",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageLink_Gallery_GalleryItemID",
                table: "ImageLink",
                column: "GalleryItemID",
                principalTable: "Gallery",
                principalColumn: "ID");
        }
    }
}
