using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesPlay.Migrations
{
    public partial class addedconnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Comments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_GameId",
                table: "Comments",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Games_GameId",
                table: "Comments",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Games_GameId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_GameId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Comments");
        }
    }
}
