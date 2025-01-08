using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Library.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTableNameToGalleryItemTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GalleryItemsToTagsJoinTable");

            migrationBuilder.DropColumn(
                name: "TagIDS",
                table: "Gallery");

            migrationBuilder.CreateTable(
                name: "GalleryItemTags",
                columns: table => new
                {
                    GalleryItemsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryItemTags", x => new { x.GalleryItemsID, x.TagsID });
                    table.ForeignKey(
                        name: "FK_GalleryItemTags_Gallery_GalleryItemsID",
                        column: x => x.GalleryItemsID,
                        principalTable: "Gallery",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GalleryItemTags_Tags_TagsID",
                        column: x => x.TagsID,
                        principalTable: "Tags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GalleryItemTags_TagsID",
                table: "GalleryItemTags",
                column: "TagsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GalleryItemTags");

            migrationBuilder.AddColumn<string>(
                name: "TagIDS",
                table: "Gallery",
                type: "nvarchar(max)",
                nullable: true);

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
                        name: "FK_GalleryItemsToTagsJoinTable_Tags_TagsID",
                        column: x => x.TagsID,
                        principalTable: "Tags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GalleryItemsToTagsJoinTable_TagsID",
                table: "GalleryItemsToTagsJoinTable",
                column: "TagsID");
        }
    }
}
