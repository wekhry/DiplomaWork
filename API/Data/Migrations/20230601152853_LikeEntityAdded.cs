using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class LikeEntityAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Users",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    SourceUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    TargetUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.SourceUserId, x.TargetUserId });
                    table.ForeignKey(
                        name: "FK_Likes_Users_SourceUserId",
                        column: x => x.SourceUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Users_TargetUserId",
                        column: x => x.TargetUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AppUserId",
                table: "Users",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_TargetUserId",
                table: "Likes",
                column: "TargetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_AppUserId",
                table: "Users",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_AppUserId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Users_AppUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Users");
        }
    }
}
