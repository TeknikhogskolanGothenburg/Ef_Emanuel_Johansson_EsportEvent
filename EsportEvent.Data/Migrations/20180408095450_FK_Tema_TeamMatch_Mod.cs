using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EsportEvent.Data.Migrations
{
    public partial class FK_Tema_TeamMatch_Mod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Team_Matches_MatchId",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_MatchId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Matches");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Team",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Team_MatchId",
                table: "Team",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Matches_MatchId",
                table: "Team",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
