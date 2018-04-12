using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EsportEvent.Data.Migrations
{
    public partial class FK_Tema_TeamMatch_Mod_3nd_try : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TeamMatch_TeamId",
                table: "TeamMatch",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMatch_Matches_MatchId",
                table: "TeamMatch",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMatch_Team_TeamId",
                table: "TeamMatch",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMatch_Matches_MatchId",
                table: "TeamMatch");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMatch_Team_TeamId",
                table: "TeamMatch");

            migrationBuilder.DropIndex(
                name: "IX_TeamMatch_TeamId",
                table: "TeamMatch");
        }
    }
}
