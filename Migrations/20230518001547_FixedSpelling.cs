using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameNightWithFriends.Migrations
{
    public partial class FixedSpelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PLayers_GameNights_GameNightId",
                table: "PLayers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PLayers",
                table: "PLayers");

            migrationBuilder.RenameTable(
                name: "PLayers",
                newName: "Players");

            migrationBuilder.RenameIndex(
                name: "IX_PLayers_GameNightId",
                table: "Players",
                newName: "IX_Players_GameNightId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_GameNights_GameNightId",
                table: "Players",
                column: "GameNightId",
                principalTable: "GameNights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_GameNights_GameNightId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "PLayers");

            migrationBuilder.RenameIndex(
                name: "IX_Players_GameNightId",
                table: "PLayers",
                newName: "IX_PLayers_GameNightId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PLayers",
                table: "PLayers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PLayers_GameNights_GameNightId",
                table: "PLayers",
                column: "GameNightId",
                principalTable: "GameNights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
