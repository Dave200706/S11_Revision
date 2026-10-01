using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PresseMots.Migrations
{
    /// <inheritdoc />
    public partial class AjoutStoryTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StoryTags",
                table: "StoryTags");

            migrationBuilder.DropColumn(
                name: "StoryId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Stories");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StoryTags",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoryTags",
                table: "StoryTags",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StoryTags_StoryId",
                table: "StoryTags",
                column: "StoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StoryTags",
                table: "StoryTags");

            migrationBuilder.DropIndex(
                name: "IX_StoryTags_StoryId",
                table: "StoryTags");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StoryTags");

            migrationBuilder.AddColumn<int>(
                name: "StoryId",
                table: "Tags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Stories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoryTags",
                table: "StoryTags",
                columns: new[] { "StoryId", "TagsId" });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 1,
                column: "TagId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "Id",
                keyValue: 2,
                column: "TagId",
                value: 0);
        }
    }
}
