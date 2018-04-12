﻿// <auto-generated />
using EsportEvent.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EsportEvent.Data.Migrations
{
    [DbContext(typeof(EsportEventContext))]
    [Migration("20180318105746_initfullTableDiagram")]
    partial class initfullTableDiagram
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EsportEvent.Domain.Game", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Publisher");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<int>("Tournaments");

                    b.HasKey("Name");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("EsportEvent.Domain.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("GamePlayed");

                    b.Property<string>("Team1GameName");

                    b.Property<string>("Team1Name");

                    b.Property<string>("Team2GameName");

                    b.Property<string>("Team2Name");

                    b.Property<string>("TournamentGameName");

                    b.Property<string>("TournamentName");

                    b.Property<string>("WinnerGameName");

                    b.Property<string>("WinnerName");

                    b.HasKey("Id");

                    b.HasIndex("Team1Name", "Team1GameName");

                    b.HasIndex("Team2Name", "Team2GameName");

                    b.HasIndex("TournamentName", "TournamentGameName");

                    b.HasIndex("WinnerName", "WinnerGameName");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("EsportEvent.Domain.Player", b =>
                {
                    b.Property<string>("UserName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("UserName");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("EsportEvent.Domain.PlayerGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GameId");

                    b.Property<string>("GameName");

                    b.Property<int>("PlayerId");

                    b.Property<string>("PlayerNickName");

                    b.Property<string>("PlayerRole");

                    b.Property<string>("PlayerUserName");

                    b.Property<string>("TeamGameName");

                    b.Property<string>("TeamName");

                    b.HasKey("Id");

                    b.HasIndex("GameName");

                    b.HasIndex("PlayerUserName");

                    b.HasIndex("TeamName", "TeamGameName");

                    b.ToTable("PlayerGames");
                });

            modelBuilder.Entity("EsportEvent.Domain.PlayerStats", b =>
                {
                    b.Property<int>("MatchId");

                    b.Property<int>("PlayerGameId");

                    b.Property<int>("Assists");

                    b.Property<int>("Deaths");

                    b.Property<int>("Kills");

                    b.HasKey("MatchId", "PlayerGameId");

                    b.HasIndex("MatchId")
                        .IsUnique();

                    b.ToTable("PlayerStats");
                });

            modelBuilder.Entity("EsportEvent.Domain.Team", b =>
                {
                    b.Property<string>("Name");

                    b.Property<string>("GameName");

                    b.Property<string>("TournamentGameName");

                    b.Property<string>("TournamentName");

                    b.HasKey("Name", "GameName");

                    b.HasIndex("TournamentName", "TournamentGameName");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("EsportEvent.Domain.Tournament", b =>
                {
                    b.Property<string>("Name");

                    b.Property<string>("GameName");

                    b.HasKey("Name", "GameName");

                    b.ToTable("Tournament");
                });

            modelBuilder.Entity("EsportEvent.Domain.Match", b =>
                {
                    b.HasOne("EsportEvent.Domain.Team", "Team1")
                        .WithMany()
                        .HasForeignKey("Team1Name", "Team1GameName");

                    b.HasOne("EsportEvent.Domain.Team", "Team2")
                        .WithMany()
                        .HasForeignKey("Team2Name", "Team2GameName");

                    b.HasOne("EsportEvent.Domain.Tournament")
                        .WithMany("Matches")
                        .HasForeignKey("TournamentName", "TournamentGameName");

                    b.HasOne("EsportEvent.Domain.Team", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerName", "WinnerGameName");
                });

            modelBuilder.Entity("EsportEvent.Domain.PlayerGame", b =>
                {
                    b.HasOne("EsportEvent.Domain.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameName");

                    b.HasOne("EsportEvent.Domain.Player", "Player")
                        .WithMany("Games")
                        .HasForeignKey("PlayerUserName");

                    b.HasOne("EsportEvent.Domain.Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamName", "TeamGameName");
                });

            modelBuilder.Entity("EsportEvent.Domain.PlayerStats", b =>
                {
                    b.HasOne("EsportEvent.Domain.Match")
                        .WithOne("PlayerStats")
                        .HasForeignKey("EsportEvent.Domain.PlayerStats", "MatchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EsportEvent.Domain.Team", b =>
                {
                    b.HasOne("EsportEvent.Domain.Tournament")
                        .WithMany("Teams")
                        .HasForeignKey("TournamentName", "TournamentGameName");
                });
#pragma warning restore 612, 618
        }
    }
}
