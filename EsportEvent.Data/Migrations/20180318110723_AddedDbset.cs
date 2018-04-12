using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EsportEvent.Data.Migrations
{
    public partial class AddedDbset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Team_Team1Name_Team1GameName",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Team_Team2Name_Team2GameName",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Tournament_TournamentName_TournamentGameName",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Team_WinnerName_WinnerGameName",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerStats_Match_MatchId",
                table: "PlayerStats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Match",
                table: "Match");

            migrationBuilder.RenameTable(
                name: "Match",
                newName: "Matches");

            migrationBuilder.RenameIndex(
                name: "IX_Match_WinnerName_WinnerGameName",
                table: "Matches",
                newName: "IX_Matches_WinnerName_WinnerGameName");

            migrationBuilder.RenameIndex(
                name: "IX_Match_TournamentName_TournamentGameName",
                table: "Matches",
                newName: "IX_Matches_TournamentName_TournamentGameName");

            migrationBuilder.RenameIndex(
                name: "IX_Match_Team2Name_Team2GameName",
                table: "Matches",
                newName: "IX_Matches_Team2Name_Team2GameName");

            migrationBuilder.RenameIndex(
                name: "IX_Match_Team1Name_Team1GameName",
                table: "Matches",
                newName: "IX_Matches_Team1Name_Team1GameName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matches",
                table: "Matches",
                column: "Id");

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
                name: "FK_PlayerStats_Matches_MatchId",
                table: "PlayerStats",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_PlayerStats_Matches_MatchId",
                table: "PlayerStats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matches",
                table: "Matches");

            migrationBuilder.RenameTable(
                name: "Matches",
                newName: "Match");

            migrationBuilder.RenameIndex(
                name: "IX_Matches_WinnerName_WinnerGameName",
                table: "Match",
                newName: "IX_Match_WinnerName_WinnerGameName");

            migrationBuilder.RenameIndex(
                name: "IX_Matches_TournamentName_TournamentGameName",
                table: "Match",
                newName: "IX_Match_TournamentName_TournamentGameName");

            migrationBuilder.RenameIndex(
                name: "IX_Matches_Team2Name_Team2GameName",
                table: "Match",
                newName: "IX_Match_Team2Name_Team2GameName");

            migrationBuilder.RenameIndex(
                name: "IX_Matches_Team1Name_Team1GameName",
                table: "Match",
                newName: "IX_Match_Team1Name_Team1GameName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Match",
                table: "Match",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Team_Team1Name_Team1GameName",
                table: "Match",
                columns: new[] { "Team1Name", "Team1GameName" },
                principalTable: "Team",
                principalColumns: new[] { "Name", "GameName" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Team_Team2Name_Team2GameName",
                table: "Match",
                columns: new[] { "Team2Name", "Team2GameName" },
                principalTable: "Team",
                principalColumns: new[] { "Name", "GameName" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Tournament_TournamentName_TournamentGameName",
                table: "Match",
                columns: new[] { "TournamentName", "TournamentGameName" },
                principalTable: "Tournament",
                principalColumns: new[] { "Name", "GameName" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Team_WinnerName_WinnerGameName",
                table: "Match",
                columns: new[] { "WinnerName", "WinnerGameName" },
                principalTable: "Team",
                principalColumns: new[] { "Name", "GameName" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerStats_Match_MatchId",
                table: "PlayerStats",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
