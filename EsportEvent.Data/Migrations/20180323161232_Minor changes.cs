using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EsportEvent.Data.Migrations
{
    public partial class Minorchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournament_TournamentGameId_TournamentName",
                table: "Matches");

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

            migrationBuilder.DropIndex(
                name: "IX_Team_TournamentGameId_TournamentName",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Matches_TournamentGameId_TournamentName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Tournament");

            migrationBuilder.DropColumn(
                name: "TournamentGameId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "TournamentName",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "TournamentGameId",
                table: "Matches");

            migrationBuilder.AddColumn<string>(
                name: "GameName",
                table: "Tournament",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TournamentGameName",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament",
                columns: new[] { "GameName", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TournamentGameName_TournamentName",
                table: "Matches",
                columns: new[] { "TournamentGameName", "TournamentName" });

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Tournament_TournamentGameName_TournamentName",
                table: "Matches",
                columns: new[] { "TournamentGameName", "TournamentName" },
                principalTable: "Tournament",
                principalColumns: new[] { "GameName", "Name" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tournament_Games_GameName",
                table: "Tournament",
                column: "GameName",
                principalTable: "Games",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournament_TournamentGameName_TournamentName",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Tournament_Games_GameName",
                table: "Tournament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament");

            migrationBuilder.DropIndex(
                name: "IX_Matches_TournamentGameName_TournamentName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "GameName",
                table: "Tournament");

            migrationBuilder.DropColumn(
                name: "TournamentGameName",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Tournament",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TournamentGameId",
                table: "Team",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TournamentName",
                table: "Team",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TournamentGameId",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament",
                columns: new[] { "GameId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_Name",
                table: "Tournament",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Team_TournamentGameId_TournamentName",
                table: "Team",
                columns: new[] { "TournamentGameId", "TournamentName" });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TournamentGameId_TournamentName",
                table: "Matches",
                columns: new[] { "TournamentGameId", "TournamentName" });

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Tournament_TournamentGameId_TournamentName",
                table: "Matches",
                columns: new[] { "TournamentGameId", "TournamentName" },
                principalTable: "Tournament",
                principalColumns: new[] { "GameId", "Name" },
                onDelete: ReferentialAction.Restrict);

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
    }
}
