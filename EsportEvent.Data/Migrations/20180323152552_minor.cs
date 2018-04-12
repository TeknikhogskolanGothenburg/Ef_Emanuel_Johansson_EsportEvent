using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EsportEvent.Data.Migrations
{
    public partial class minor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_Team1GameId_Team1Name",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_Team2GameId_Team2Name",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_WinnerGameId_WinnerName",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Team_TeamGameId_TeamName",
                table: "PlayerGames");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Games_Name",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_Name",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_PlayerGames_TeamGameId_TeamName",
                table: "PlayerGames");

            migrationBuilder.DropIndex(
                name: "IX_Matches_Team1GameId_Team1Name",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_Team2GameId_Team2Name",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_WinnerGameId_WinnerName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "TeamGameId",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "Team1GameId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Team2GameId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "WinnerGameId",
                table: "Matches");

            migrationBuilder.AddColumn<string>(
                name: "GameName",
                table: "Team",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeamGameName",
                table: "PlayerGames",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team1GameName",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team2GameName",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WinnerGameName",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                columns: new[] { "GameName", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_TeamGameName_TeamName",
                table: "PlayerGames",
                columns: new[] { "TeamGameName", "TeamName" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Team1GameName_Team1Name",
                table: "Matches",
                columns: new[] { "Team1GameName", "Team1Name" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Team2GameName_Team2Name",
                table: "Matches",
                columns: new[] { "Team2GameName", "Team2Name" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_WinnerGameName_WinnerName",
                table: "Matches",
                columns: new[] { "WinnerGameName", "WinnerName" });

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Team_Team1GameName_Team1Name",
                table: "Matches",
                columns: new[] { "Team1GameName", "Team1Name" },
                principalTable: "Team",
                principalColumns: new[] { "GameName", "Name" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Team_Team2GameName_Team2Name",
                table: "Matches",
                columns: new[] { "Team2GameName", "Team2Name" },
                principalTable: "Team",
                principalColumns: new[] { "GameName", "Name" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Team_WinnerGameName_WinnerName",
                table: "Matches",
                columns: new[] { "WinnerGameName", "WinnerName" },
                principalTable: "Team",
                principalColumns: new[] { "GameName", "Name" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_Team_TeamGameName_TeamName",
                table: "PlayerGames",
                columns: new[] { "TeamGameName", "TeamName" },
                principalTable: "Team",
                principalColumns: new[] { "GameName", "Name" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Games_GameName",
                table: "Team",
                column: "GameName",
                principalTable: "Games",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_Team1GameName_Team1Name",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_Team2GameName_Team2Name",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_WinnerGameName_WinnerName",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Team_TeamGameName_TeamName",
                table: "PlayerGames");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Games_GameName",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_PlayerGames_TeamGameName_TeamName",
                table: "PlayerGames");

            migrationBuilder.DropIndex(
                name: "IX_Matches_Team1GameName_Team1Name",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_Team2GameName_Team2Name",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_WinnerGameName_WinnerName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "GameName",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "TeamGameName",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "Team1GameName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Team2GameName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "WinnerGameName",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Team",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "PlayerGames",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamGameId",
                table: "PlayerGames",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Team1GameId",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Team2GameId",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WinnerGameId",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                columns: new[] { "GameId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_Team_Name",
                table: "Team",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_TeamGameId_TeamName",
                table: "PlayerGames",
                columns: new[] { "TeamGameId", "TeamName" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Team1GameId_Team1Name",
                table: "Matches",
                columns: new[] { "Team1GameId", "Team1Name" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Team2GameId_Team2Name",
                table: "Matches",
                columns: new[] { "Team2GameId", "Team2Name" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_WinnerGameId_WinnerName",
                table: "Matches",
                columns: new[] { "WinnerGameId", "WinnerName" });

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Team_Team1GameId_Team1Name",
                table: "Matches",
                columns: new[] { "Team1GameId", "Team1Name" },
                principalTable: "Team",
                principalColumns: new[] { "GameId", "Name" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Team_Team2GameId_Team2Name",
                table: "Matches",
                columns: new[] { "Team2GameId", "Team2Name" },
                principalTable: "Team",
                principalColumns: new[] { "GameId", "Name" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Team_WinnerGameId_WinnerName",
                table: "Matches",
                columns: new[] { "WinnerGameId", "WinnerName" },
                principalTable: "Team",
                principalColumns: new[] { "GameId", "Name" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_Team_TeamGameId_TeamName",
                table: "PlayerGames",
                columns: new[] { "TeamGameId", "TeamName" },
                principalTable: "Team",
                principalColumns: new[] { "GameId", "Name" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Games_Name",
                table: "Team",
                column: "Name",
                principalTable: "Games",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
