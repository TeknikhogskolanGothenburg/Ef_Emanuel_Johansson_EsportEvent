using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EsportEvent.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerGames",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    PlayerId = table.Column<int>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Tournaments = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerGames", x => x.Name);
                    table.ForeignKey(
                        name: "FK_PlayerGames_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_PlayerId",
                table: "PlayerGames",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerGames");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
