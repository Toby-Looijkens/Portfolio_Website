using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Library.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTagsTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DownloadFileLinks_Gallery_GalleryItemID",
                table: "DownloadFileLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_GalleryItemsToTagsJoinTable_Tag_TagsID",
                table: "GalleryItemsToTagsJoinTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DownloadFileLinks",
                table: "DownloadFileLinks");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "DownloadFileLinks",
                newName: "DownloadableFileLinks");

            migrationBuilder.RenameIndex(
                name: "IX_DownloadFileLinks_GalleryItemID",
                table: "DownloadableFileLinks",
                newName: "IX_DownloadableFileLinks_GalleryItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DownloadableFileLinks",
                table: "DownloadableFileLinks",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DownloadableFileLinks_Gallery_GalleryItemID",
                table: "DownloadableFileLinks",
                column: "GalleryItemID",
                principalTable: "Gallery",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_GalleryItemsToTagsJoinTable_Tags_TagsID",
                table: "GalleryItemsToTagsJoinTable",
                column: "TagsID",
                principalTable: "Tags",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DownloadableFileLinks_Gallery_GalleryItemID",
                table: "DownloadableFileLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_GalleryItemsToTagsJoinTable_Tags_TagsID",
                table: "GalleryItemsToTagsJoinTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DownloadableFileLinks",
                table: "DownloadableFileLinks");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameTable(
                name: "DownloadableFileLinks",
                newName: "DownloadFileLinks");

            migrationBuilder.RenameIndex(
                name: "IX_DownloadableFileLinks_GalleryItemID",
                table: "DownloadFileLinks",
                newName: "IX_DownloadFileLinks_GalleryItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DownloadFileLinks",
                table: "DownloadFileLinks",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DownloadFileLinks_Gallery_GalleryItemID",
                table: "DownloadFileLinks",
                column: "GalleryItemID",
                principalTable: "Gallery",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_GalleryItemsToTagsJoinTable_Tag_TagsID",
                table: "GalleryItemsToTagsJoinTable",
                column: "TagsID",
                principalTable: "Tag",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
