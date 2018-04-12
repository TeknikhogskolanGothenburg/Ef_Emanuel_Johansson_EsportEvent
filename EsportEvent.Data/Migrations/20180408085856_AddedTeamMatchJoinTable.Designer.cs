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
    [Migration("20180408085856_AddedTeamMatchJoinTable")]
    partial class AddedTeamMatchJoinTable
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

                    b.Property<DateTime>("GameDay");

                    b.Property<string>("GameName");

                    b.Property<int>("TeamId");

                    b.Property<int?>("TournamentId");

                    b.HasKey("Id");

                    b.HasIndex("GameName");

                    b.HasIndex("TournamentId");

                    b.ToTable("Matches");
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

                    b.Property<string>("GameName");

                    b.Property<string>("PlayerNickName");

                    b.Property<string>("PlayerRole");

                    b.Property<string>("PlayerUserName");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("GameName");

                    b.HasIndex("PlayerUserName");

                    b.HasIndex("TeamId");

                    b.ToTable("PlayerGames");
                });

            modelBuilder.Entity("EsportEvent.Domain.PlayerStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Assists");

                    b.Property<int>("Deaths");

                    b.Property<int>("Kills");

                    b.Property<int>("MatchId");

                    b.Property<int>("PlayerGameId");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("PlayerGameId");

                    b.ToTable("PlayerStats");
                });

            modelBuilder.Entity("EsportEvent.Domain.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GameName");

                    b.Property<int?>("MatchId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("GameName");

                    b.HasIndex("MatchId");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("EsportEvent.Domain.TeamMatch", b =>
                {
                    b.Property<int>("MatchId");

                    b.Property<int>("TeamId");

                    b.HasKey("MatchId", "TeamId");

                    b.ToTable("TeamMatch");
                });

            modelBuilder.Entity("EsportEvent.Domain.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GameName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("GameName");

                    b.ToTable("Tournament");
                });

            modelBuilder.Entity("EsportEvent.Domain.Match", b =>
                {
                    b.HasOne("EsportEvent.Domain.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameName");

                    b.HasOne("EsportEvent.Domain.Tournament")
                        .WithMany("Matches")
                        .HasForeignKey("TournamentId");
                });

            modelBuilder.Entity("EsportEvent.Domain.PlayerGame", b =>
                {
                    b.HasOne("EsportEvent.Domain.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameName");

                    b.HasOne("EsportEvent.Domain.Player", "Player")
                        .WithMany("Games")
                        .HasForeignKey("PlayerUserName");

                    b.HasOne("EsportEvent.Domain.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EsportEvent.Domain.PlayerStats", b =>
                {
                    b.HasOne("EsportEvent.Domain.Match", "Match")
                        .WithMany("PlayerStats")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EsportEvent.Domain.PlayerGame", "PlayerGame")
                        .WithMany()
                        .HasForeignKey("PlayerGameId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EsportEvent.Domain.Team", b =>
                {
                    b.HasOne("EsportEvent.Domain.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameName");

                    b.HasOne("EsportEvent.Domain.Match")
                        .WithMany("Team")
                        .HasForeignKey("MatchId");
                });

            modelBuilder.Entity("EsportEvent.Domain.Tournament", b =>
                {
                    b.HasOne("EsportEvent.Domain.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameName");
                });
#pragma warning restore 612, 618
        }
    }
}
