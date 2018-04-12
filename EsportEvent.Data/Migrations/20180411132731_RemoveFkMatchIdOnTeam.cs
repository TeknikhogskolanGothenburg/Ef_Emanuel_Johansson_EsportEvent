using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EsportEvent.Data.Migrations
{
    public partial class RemoveFkMatchIdOnTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
              name: "FK_Team_Matches_MatchId",
              table: "Team");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
