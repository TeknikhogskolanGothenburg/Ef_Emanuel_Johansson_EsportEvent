using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EsportEvent.Data.Migrations
{
    public partial class TeamMatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournament_TournamentId",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Team",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TournamentId",
                table: "Matches",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Team_MatchId",
                table: "Team",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Tournament_TournamentId",
                table: "Matches",
                column: "TournamentId",
                principalTable: "Tournament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Matches_MatchId",
                table: "Team",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournament_TournamentId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Matches_MatchId",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_MatchId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Team");

            migrationBuilder.AlterColumn<int>(
                name: "TournamentId",
                table: "Matches",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Tournament_TournamentId",
                table: "Matches",
                column: "TournamentId",
                principalTable: "Tournament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
