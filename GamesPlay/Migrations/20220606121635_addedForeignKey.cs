using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesPlay.Migrations
{
    public partial class addedForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Games_GameId1",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_GameId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_GameId1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "GameId1",
                table: "Comments");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Games_GameId",
                table: "Comments",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Games_GameId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "GameId1",
                table: "Comments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_GameId1",
                table: "Comments",
                column: "GameId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Games_GameId1",
                table: "Comments",
                column: "GameId1",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_GameId",
                table: "Comments",
                column: "GameId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
