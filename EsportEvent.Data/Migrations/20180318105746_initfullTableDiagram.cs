using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EsportEvent.Data.Migrations
{
    public partial class initfullTableDiagram : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Players_PlayerId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Players_PlayerId",
                table: "PlayerGames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerGames",
                table: "PlayerGames");

            migrationBuilder.DropIndex(
                name: "IX_Games_PlayerId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Games");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Players",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PlayerGames",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "PlayerUserName",
                table: "PlayerGames",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamGameName",
                table: "PlayerGames",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamName",
                table: "PlayerGames",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "UserName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerGames",
                table: "PlayerGames",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Tournament",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    GameName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournament", x => new { x.Name, x.GameName });
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    GameName = table.Column<string>(nullable: false),
                    TournamentGameName = table.Column<string>(nullable: true),
                    TournamentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => new { x.Name, x.GameName });
                    table.ForeignKey(
                        name: "FK_Team_Tournament_TournamentName_TournamentGameName",
                        columns: x => new { x.TournamentName, x.TournamentGameName },
                        principalTable: "Tournament",
                        principalColumns: new[] { "Name", "GameName" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GamePlayed = table.Column<DateTime>(nullable: false),
                    Team1GameName = table.Column<string>(nullable: true),
                    Team1Name = table.Column<string>(nullable: true),
                    Team2GameName = table.Column<string>(nullable: true),
                    Team2Name = table.Column<string>(nullable: true),
                    TournamentGameName = table.Column<string>(nullable: true),
                    TournamentName = table.Column<string>(nullable: true),
                    WinnerGameName = table.Column<string>(nullable: true),
                    WinnerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Match_Team_Team1Name_Team1GameName",
                        columns: x => new { x.Team1Name, x.Team1GameName },
                        principalTable: "Team",
                        principalColumns: new[] { "Name", "GameName" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Team_Team2Name_Team2GameName",
                        columns: x => new { x.Team2Name, x.Team2GameName },
                        principalTable: "Team",
                        principalColumns: new[] { "Name", "GameName" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Tournament_TournamentName_TournamentGameName",
                        columns: x => new { x.TournamentName, x.TournamentGameName },
                        principalTable: "Tournament",
                        principalColumns: new[] { "Name", "GameName" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Team_WinnerName_WinnerGameName",
                        columns: x => new { x.WinnerName, x.WinnerGameName },
                        principalTable: "Team",
                        principalColumns: new[] { "Name", "GameName" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerStats",
                columns: table => new
                {
                    MatchId = table.Column<int>(nullable: false),
                    PlayerGameId = table.Column<int>(nullable: false),
                    Assists = table.Column<int>(nullable: false),
                    Deaths = table.Column<int>(nullable: false),
                    Kills = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerStats", x => new { x.MatchId, x.PlayerGameId });
                    table.ForeignKey(
                        name: "FK_PlayerStats_Match_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Match",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_PlayerUserName",
                table: "PlayerGames",
                column: "PlayerUserName");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_TeamName_TeamGameName",
                table: "PlayerGames",
                columns: new[] { "TeamName", "TeamGameName" });

            migrationBuilder.CreateIndex(
                name: "IX_Match_Team1Name_Team1GameName",
                table: "Match",
                columns: new[] { "Team1Name", "Team1GameName" });

            migrationBuilder.CreateIndex(
                name: "IX_Match_Team2Name_Team2GameName",
                table: "Match",
                columns: new[] { "Team2Name", "Team2GameName" });

            migrationBuilder.CreateIndex(
                name: "IX_Match_TournamentName_TournamentGameName",
                table: "Match",
                columns: new[] { "TournamentName", "TournamentGameName" });

            migrationBuilder.CreateIndex(
                name: "IX_Match_WinnerName_WinnerGameName",
                table: "Match",
                columns: new[] { "WinnerName", "WinnerGameName" });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStats_MatchId",
                table: "PlayerStats",
                column: "MatchId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Team_TournamentName_TournamentGameName",
                table: "Team",
                columns: new[] { "TournamentName", "TournamentGameName" });

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_Players_PlayerUserName",
                table: "PlayerGames",
                column: "PlayerUserName",
                principalTable: "Players",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_Team_TeamName_TeamGameName",
                table: "PlayerGames",
                columns: new[] { "TeamName", "TeamGameName" },
                principalTable: "Team",
                principalColumns: new[] { "Name", "GameName" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Players_PlayerUserName",
                table: "PlayerGames");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Team_TeamName_TeamGameName",
                table: "PlayerGames");

            migrationBuilder.DropTable(
                name: "PlayerStats");

            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Tournament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerGames",
                table: "PlayerGames");

            migrationBuilder.DropIndex(
                name: "IX_PlayerGames_PlayerUserName",
                table: "PlayerGames");

            migrationBuilder.DropIndex(
                name: "IX_PlayerGames_TeamName_TeamGameName",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "PlayerUserName",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "TeamGameName",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "TeamName",
                table: "PlayerGames");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Players",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Games",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerGames",
                table: "PlayerGames",
                columns: new[] { "PlayerId", "GameId" });

            migrationBuilder.CreateIndex(
                name: "IX_Games_PlayerId",
                table: "Games",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Players_PlayerId",
                table: "Games",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_Players_PlayerId",
                table: "PlayerGames",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
