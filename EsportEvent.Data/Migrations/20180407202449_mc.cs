using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EsportEvent.Data.Migrations
{
    public partial class mc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_Team1GameName_Team1Name",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_Team2GameName_Team2Name",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournament_TournamentGameName_TournamentName",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Team_WinnerGameName_WinnerName",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Players_PlayerId",
                table: "PlayerGames");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Team_TeamGameName_TeamName",
                table: "PlayerGames");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Games_GameName",
                table: "Team");

            migrationBuilder.DropForeignKey(
                name: "FK_Tournament_Games_GameName",
                table: "Tournament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerStats",
                table: "PlayerStats");

            migrationBuilder.DropIndex(
                name: "IX_PlayerGames_PlayerId",
                table: "PlayerGames");

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
                name: "IX_Matches_TournamentGameName_TournamentName",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_WinnerGameName_WinnerName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "TeamGameName",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "Team1GameName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Team1Id",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Team1Name",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Team2GameName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Team2Id",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Team2Name",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "TournamentGameName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "TournamentName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "WinnerGameName",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "WinnerName",
                table: "Matches");

            migrationBuilder.RenameColumn(
                name: "TeamName",
                table: "PlayerGames",
                newName: "PlayerUserName");

            migrationBuilder.RenameColumn(
                name: "WinnerId",
                table: "Matches",
                newName: "TeamId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tournament",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "GameName",
                table: "Tournament",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Tournament",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Team",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "GameName",
                table: "Team",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Team",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Team",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PlayerStats",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "PlayerGames",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TournamentId",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerStats",
                table: "PlayerStats",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_GameName",
                table: "Tournament",
                column: "GameName");

            migrationBuilder.CreateIndex(
                name: "IX_Team_GameName",
                table: "Team",
                column: "GameName");

            migrationBuilder.CreateIndex(
                name: "IX_Team_MatchId",
                table: "Team",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStats_MatchId",
                table: "PlayerStats",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_PlayerUserName",
                table: "PlayerGames",
                column: "PlayerUserName");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_TeamId",
                table: "PlayerGames",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TournamentId",
                table: "Matches",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Tournament_TournamentId",
                table: "Matches",
                column: "TournamentId",
                principalTable: "Tournament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_Players_PlayerUserName",
                table: "PlayerGames",
                column: "PlayerUserName",
                principalTable: "Players",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_Team_TeamId",
                table: "PlayerGames",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Games_GameName",
                table: "Team",
                column: "GameName",
                principalTable: "Games",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Matches_MatchId",
                table: "Team",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tournament_Games_GameName",
                table: "Tournament",
                column: "GameName",
                principalTable: "Games",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournament_TournamentId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Players_PlayerUserName",
                table: "PlayerGames");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Team_TeamId",
                table: "PlayerGames");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Games_GameName",
                table: "Team");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Matches_MatchId",
                table: "Team");

            migrationBuilder.DropForeignKey(
                name: "FK_Tournament_Games_GameName",
                table: "Tournament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament");

            migrationBuilder.DropIndex(
                name: "IX_Tournament_GameName",
                table: "Tournament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_GameName",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Team_MatchId",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerStats",
                table: "PlayerStats");

            migrationBuilder.DropIndex(
                name: "IX_PlayerStats_MatchId",
                table: "PlayerStats");

            migrationBuilder.DropIndex(
                name: "IX_PlayerGames_PlayerUserName",
                table: "PlayerGames");

            migrationBuilder.DropIndex(
                name: "IX_PlayerGames_TeamId",
                table: "PlayerGames");

            migrationBuilder.DropIndex(
                name: "IX_Matches_TournamentId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Tournament");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PlayerStats");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "TournamentId",
                table: "Matches");

            migrationBuilder.RenameColumn(
                name: "PlayerUserName",
                table: "PlayerGames",
                newName: "TeamName");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Matches",
                newName: "WinnerId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tournament",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GameName",
                table: "Tournament",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Team",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GameName",
                table: "Team",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlayerId",
                table: "PlayerGames",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeamGameName",
                table: "PlayerGames",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team1GameName",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Team1Id",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Team1Name",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team2GameName",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Team2Id",
                table: "Matches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Team2Name",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TournamentGameName",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TournamentName",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WinnerGameName",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WinnerName",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament",
                columns: new[] { "GameName", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                columns: new[] { "GameName", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerStats",
                table: "PlayerStats",
                columns: new[] { "MatchId", "PlayerGameId" });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_PlayerId",
                table: "PlayerGames",
                column: "PlayerId");

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
                name: "IX_Matches_TournamentGameName_TournamentName",
                table: "Matches",
                columns: new[] { "TournamentGameName", "TournamentName" });

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
                name: "FK_Matches_Tournament_TournamentGameName_TournamentName",
                table: "Matches",
                columns: new[] { "TournamentGameName", "TournamentName" },
                principalTable: "Tournament",
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
                name: "FK_PlayerGames_Players_PlayerId",
                table: "PlayerGames",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "UserName",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Tournament_Games_GameName",
                table: "Tournament",
                column: "GameName",
                principalTable: "Games",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
