using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EsportEvent.Data.Migrations
{
    public partial class SomeMinorChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_Team1Name_Team1GameName",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_Team2Name_Team2GameName",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournament_TournamentName_TournamentGameName",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_WinnerName_WinnerGameName",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Team_TeamName_TeamGameName",
                table: "PlayerGames");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Tournament_TournamentName_TournamentGameName",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_TournamentName_TournamentGameName",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_PlayerStats_MatchId",
                table: "PlayerStats");

            migrationBuilder.DropIndex(
                name: "IX_PlayerGames_TeamName_TeamGameName",
                table: "PlayerGames");

            migrationBuilder.DropIndex(
                name: "IX_Matches_Team1Name_Team1GameName",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_Team2Name_Team2GameName",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_TournamentName_TournamentGameName",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_WinnerName_WinnerGameName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "GameName",
                table: "Tournament");

            migrationBuilder.DropColumn(
                name: "GameName",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "TournamentGameName",
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
                name: "TournamentGameName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "WinnerGameName",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Tournament",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Team",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TournamentGameId",
                table: "Team",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamGameId",
                table: "PlayerGames",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Team1GameId",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Team1Id",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Team2GameId",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Team2Id",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TournamentGameId",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WinnerGameId",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WinnerId",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament",
                columns: new[] { "GameId", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                columns: new[] { "GameId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_Name",
                table: "Tournament",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Team_Name",
                table: "Team",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Team_TournamentGameId_TournamentName",
                table: "Team",
                columns: new[] { "TournamentGameId", "TournamentName" });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStats_PlayerGameId",
                table: "PlayerStats",
                column: "PlayerGameId");

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
                name: "IX_Matches_TournamentGameId_TournamentName",
                table: "Matches",
                columns: new[] { "TournamentGameId", "TournamentName" });

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
                name: "FK_Matches_Tournament_TournamentGameId_TournamentName",
                table: "Matches",
                columns: new[] { "TournamentGameId", "TournamentName" },
                principalTable: "Tournament",
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
                name: "FK_PlayerStats_PlayerGames_PlayerGameId",
                table: "PlayerStats",
                column: "PlayerGameId",
                principalTable: "PlayerGames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Games_Name",
                table: "Team",
                column: "Name",
                principalTable: "Games",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Tournament_TournamentGameId_TournamentName",
                table: "Team",
                columns: new[] { "TournamentGameId", "TournamentName" },
                principalTable: "Tournament",
                principalColumns: new[] { "GameId", "Name" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tournament_Games_Name",
                table: "Tournament",
                column: "Name",
                principalTable: "Games",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_Team1GameId_Team1Name",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_Team2GameId_Team2Name",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournament_TournamentGameId_TournamentName",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_WinnerGameId_WinnerName",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Team_TeamGameId_TeamName",
                table: "PlayerGames");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerStats_PlayerGames_PlayerGameId",
                table: "PlayerStats");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Games_Name",
                table: "Team");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Tournament_TournamentGameId_TournamentName",
                table: "Team");

            migrationBuilder.DropForeignKey(
                name: "FK_Tournament_Games_Name",
                table: "Tournament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament");

            migrationBuilder.DropIndex(
                name: "IX_Tournament_Name",
                table: "Tournament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_Name",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_TournamentGameId_TournamentName",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_PlayerStats_PlayerGameId",
                table: "PlayerStats");

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
                name: "IX_Matches_TournamentGameId_TournamentName",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_WinnerGameId_WinnerName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Tournament");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "TournamentGameId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "TeamGameId",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "Team1GameId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Team1Id",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Team2GameId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Team2Id",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "TournamentGameId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "WinnerGameId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "WinnerId",
                table: "Matches");

            migrationBuilder.AddColumn<string>(
                name: "GameName",
                table: "Tournament",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GameName",
                table: "Team",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TournamentGameName",
                table: "Team",
                nullable: true);

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
                name: "TournamentGameName",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WinnerGameName",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament",
                columns: new[] { "Name", "GameName" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                columns: new[] { "Name", "GameName" });

            migrationBuilder.CreateIndex(
                name: "IX_Team_TournamentName_TournamentGameName",
                table: "Team",
                columns: new[] { "TournamentName", "TournamentGameName" });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStats_MatchId",
                table: "PlayerStats",
                column: "MatchId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_TeamName_TeamGameName",
                table: "PlayerGames",
                columns: new[] { "TeamName", "TeamGameName" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Team1Name_Team1GameName",
                table: "Matches",
                columns: new[] { "Team1Name", "Team1GameName" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_Team2Name_Team2GameName",
                table: "Matches",
                columns: new[] { "Team2Name", "Team2GameName" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TournamentName_TournamentGameName",
                table: "Matches",
                columns: new[] { "TournamentName", "TournamentGameName" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_WinnerName_WinnerGameName",
                table: "Matches",
                columns: new[] { "WinnerName", "WinnerGameName" });

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Team_Team1Name_Team1GameName",
                table: "Matches",
                columns: new[] { "Team1Name", "Team1GameName" },
                principalTable: "Team",
                principalColumns: new[] { "Name", "GameName" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Team_Team2Name_Team2GameName",
                table: "Matches",
                columns: new[] { "Team2Name", "Team2GameName" },
                principalTable: "Team",
                principalColumns: new[] { "Name", "GameName" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Tournament_TournamentName_TournamentGameName",
                table: "Matches",
                columns: new[] { "TournamentName", "TournamentGameName" },
                principalTable: "Tournament",
                principalColumns: new[] { "Name", "GameName" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Team_WinnerName_WinnerGameName",
                table: "Matches",
                columns: new[] { "WinnerName", "WinnerGameName" },
                principalTable: "Team",
                principalColumns: new[] { "Name", "GameName" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_Team_TeamName_TeamGameName",
                table: "PlayerGames",
                columns: new[] { "TeamName", "TeamGameName" },
                principalTable: "Team",
                principalColumns: new[] { "Name", "GameName" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Tournament_TournamentName_TournamentGameName",
                table: "Team",
                columns: new[] { "TournamentName", "TournamentGameName" },
                principalTable: "Tournament",
                principalColumns: new[] { "Name", "GameName" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
