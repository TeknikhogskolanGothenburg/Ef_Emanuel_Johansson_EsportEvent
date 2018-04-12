using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EsportEvent.Data.Migrations
{
    public partial class playerGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Players_PlayerId",
                table: "PlayerGames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerGames",
                table: "PlayerGames");

            migrationBuilder.RenameTable(
                name: "PlayerGames",
                newName: "Games");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerGames_PlayerId",
                table: "Games",
                newName: "IX_Games_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Name");

            migrationBuilder.CreateTable(
                name: "PlayerGames",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false),
                    GameId = table.Column<int>(nullable: false),
                    GameName = table.Column<string>(nullable: true),
                    PlayerNickName = table.Column<string>(nullable: true),
                    PlayerRole = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerGames", x => new { x.PlayerId, x.GameId });
                    table.ForeignKey(
                        name: "FK_PlayerGames_Games_GameName",
                        column: x => x.GameName,
                        principalTable: "Games",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerGames_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_GameName",
                table: "PlayerGames",
                column: "GameName");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Players_PlayerId",
                table: "Games",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Players_PlayerId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "PlayerGames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "PlayerGames");

            migrationBuilder.RenameIndex(
                name: "IX_Games_PlayerId",
                table: "PlayerGames",
                newName: "IX_PlayerGames_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerGames",
                table: "PlayerGames",
                column: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_Players_PlayerId",
                table: "PlayerGames",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
