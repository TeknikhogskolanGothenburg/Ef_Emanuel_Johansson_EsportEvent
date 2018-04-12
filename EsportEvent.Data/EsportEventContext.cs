using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using EsportEvent.Domain;
using Microsoft.Extensions.Logging.Console;
using System;

namespace EsportEvent.Data
{
    public class EsportEventContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<PlayerGame> PlayerGames { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<PlayerStats> PlayerStats { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Tournament> Tournament { get; set; }
        public DbSet<TeamMatch> TeamMatch { get; set; }



        public static readonly LoggerFactory EsportloggerFactory
                = new LoggerFactory(new[]{
           new ConsoleLoggerProvider((category, level) => category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information, true)
                });

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasKey(m => new {m.Id });
            modelBuilder.Entity<Game>().HasKey(m => new { m.Name });
            modelBuilder.Entity<Player>().HasKey(p => new { p.UserName });
            modelBuilder.Entity<TeamMatch>().HasKey(tm => new {tm.MatchId, tm.TeamId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Egentligen inte önskligt att ha connectionstring hårdkodad på detta sätt.
            optionsBuilder
                .EnableSensitiveDataLogging()
                //.UseLoggerFactory(EsportloggerFactory)
                .UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = EsportTournament; Trusted_connection = True;");

        }

    }
}
