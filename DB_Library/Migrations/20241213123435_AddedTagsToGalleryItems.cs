using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Library.Migrations
{
    /// <inheritdoc />
    public partial class AddedTagsToGalleryItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DownloadLinks_Gallery_GalleryItemID",
                table: "DownloadLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_Gallery_ImageLinks_ThumbnailLinkID",
                table: "Gallery");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageLinks_Gallery_GalleryItemID",
                table: "ImageLinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageLinks",
                table: "ImageLinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DownloadLinks",
                table: "DownloadLinks");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "ImageLinks");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "DownloadLinks");

            migrationBuilder.RenameTable(
                name: "ImageLinks",
                newName: "ImageFileLinks");

            migrationBuilder.RenameTable(
                name: "DownloadLinks",
                newName: "DownloadFileLinks");

            migrationBuilder.RenameColumn(
                name: "ThumbnailLinkID",
                table: "Gallery",
                newName: "ThumbnailID");

            migrationBuilder.RenameIndex(
                name: "IX_Gallery_ThumbnailLinkID",
                table: "Gallery",
                newName: "IX_Gallery_ThumbnailID");

            migrationBuilder.RenameIndex(
                name: "IX_ImageLinks_GalleryItemID",
                table: "ImageFileLinks",
                newName: "IX_ImageFileLinks_GalleryItemID");

            migrationBuilder.RenameIndex(
                name: "IX_DownloadLinks_GalleryItemID",
                table: "DownloadFileLinks",
                newName: "IX_DownloadFileLinks_GalleryItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageFileLinks",
                table: "ImageFileLinks",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DownloadFileLinks",
                table: "DownloadFileLinks",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GalleryItemsToTagsJoinTable",
                columns: table => new
                {
                    GalleryItemsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryItemsToTagsJoinTable", x => new { x.GalleryItemsID, x.TagsID });
                    table.ForeignKey(
                        name: "FK_GalleryItemsToTagsJoinTable_Gallery_GalleryItemsID",
                        column: x => x.GalleryItemsID,
                        principalTable: "Gallery",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GalleryItemsToTagsJoinTable_Tag_TagsID",
                        column: x => x.TagsID,
                        principalTable: "Tag",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GalleryItemsToTagsJoinTable_TagsID",
                table: "GalleryItemsToTagsJoinTable",
                column: "TagsID");

            migrationBuilder.AddForeignKey(
                name: "FK_DownloadFileLinks_Gallery_GalleryItemID",
                table: "DownloadFileLinks",
                column: "GalleryItemID",
                principalTable: "Gallery",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Gallery_ImageFileLinks_ThumbnailID",
                table: "Gallery",
                column: "ThumbnailID",
                principalTable: "ImageFileLinks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFileLinks_Gallery_GalleryItemID",
                table: "ImageFileLinks",
                column: "GalleryItemID",
                principalTable: "Gallery",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DownloadFileLinks_Gallery_GalleryItemID",
                table: "DownloadFileLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_Gallery_ImageFileLinks_ThumbnailID",
                table: "Gallery");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageFileLinks_Gallery_GalleryItemID",
                table: "ImageFileLinks");

            migrationBuilder.DropTable(
                name: "GalleryItemsToTagsJoinTable");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageFileLinks",
                table: "ImageFileLinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DownloadFileLinks",
                table: "DownloadFileLinks");

            migrationBuilder.RenameTable(
                name: "ImageFileLinks",
                newName: "ImageLinks");

            migrationBuilder.RenameTable(
                name: "DownloadFileLinks",
                newName: "DownloadLinks");

            migrationBuilder.RenameColumn(
                name: "ThumbnailID",
                table: "Gallery",
                newName: "ThumbnailLinkID");

            migrationBuilder.RenameIndex(
                name: "IX_Gallery_ThumbnailID",
                table: "Gallery",
                newName: "IX_Gallery_ThumbnailLinkID");

            migrationBuilder.RenameIndex(
                name: "IX_ImageFileLinks_GalleryItemID",
                table: "ImageLinks",
                newName: "IX_ImageLinks_GalleryItemID");

            migrationBuilder.RenameIndex(
                name: "IX_DownloadFileLinks_GalleryItemID",
                table: "DownloadLinks",
                newName: "IX_DownloadLinks_GalleryItemID");

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "ImageLinks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "DownloadLinks",
                type: "nvarchar(max)",
                nullable: true);

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
                name: "FK_Gallery_ImageLinks_ThumbnailLinkID",
                table: "Gallery",
                column: "ThumbnailLinkID",
                principalTable: "ImageLinks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageLinks_Gallery_GalleryItemID",
                table: "ImageLinks",
                column: "GalleryItemID",
                principalTable: "Gallery",
                principalColumn: "ID");
        }
    }
}
