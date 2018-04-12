using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EsportEvent.Data.Migrations
{
    public partial class minorChangses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Players_PlayerUserName",
                table: "PlayerGames");

            migrationBuilder.DropIndex(
                name: "IX_PlayerGames_PlayerUserName",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "PlayerUserName",
                table: "PlayerGames");

            migrationBuilder.AlterColumn<string>(
                name: "PlayerId",
                table: "PlayerGames",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "GameName",
                table: "Matches",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_PlayerId",
                table: "PlayerGames",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_GameName",
                table: "Matches",
                column: "GameName");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Games_GameName",
                table: "Matches",
                column: "GameName",
                principalTable: "Games",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_Players_PlayerId",
                table: "PlayerGames",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Games_GameName",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Players_PlayerId",
                table: "PlayerGames");

            migrationBuilder.DropIndex(
                name: "IX_PlayerGames_PlayerId",
                table: "PlayerGames");

            migrationBuilder.DropIndex(
                name: "IX_Matches_GameName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "GameName",
                table: "Matches");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerId",
                table: "PlayerGames",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlayerUserName",
                table: "PlayerGames",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_PlayerUserName",
                table: "PlayerGames",
                column: "PlayerUserName");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_Players_PlayerUserName",
                table: "PlayerGames",
                column: "PlayerUserName",
                principalTable: "Players",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
