using EsportEvent.Data;
using EsportEvent.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsportEvent.Database
{
    public class SingelObj
    {

        public void Add(Game game)
        {
            var context = new EsportEventContext();
            context.Games.Add(game);
            context.SaveChanges();
        }

        public void Add(Player player)
        {
            var context = new EsportEventContext();
            context.Players.Add(player);
            context.SaveChanges();
        }

        public void Add(PlayerGame PlayerToGame)
        {
            var context = new EsportEventContext();
            context.PlayerGames.Add(PlayerToGame);
            context.SaveChanges();
        }
        public void Add(Match match)
        {
            var context = new EsportEventContext();
            context.Matches.Add(match);
            context.SaveChanges();
        }

        //public void Add(PlayerStats playerStats)
        //{
        //    var context = new EsportEventContext();
        //    context.PlayerStats.Add(playerStats);
        //    context.SaveChanges();
        //}

        public void Add(Team team)
        {
            var context = new EsportEventContext();
            context.Team.Add(team);
            context.SaveChanges();
        }

        public void Add(Tournament tournament)
        {
            var context = new EsportEventContext();
            context.Tournament.Add(tournament);
            context.SaveChanges();
        }




        public void Delete(Game game)
        {
            var context = new EsportEventContext();
            context.Games.Remove(game);
            context.SaveChanges();
        }

        public void Delete(Match match)
        {
            var context = new EsportEventContext();
            context.Matches.Remove(match);
            context.SaveChanges();
        }

        public void Delete(Player player)
        {
            var context = new EsportEventContext();
            context.Players.Remove(player);
            context.SaveChanges();
        }

        public void Delete(PlayerGame playerGame)
        {
            var context = new EsportEventContext();
            context.PlayerGames.Remove(playerGame);
            context.SaveChanges();
        }
    
        //public void Delete(PlayerStats playerStats)
        //{
        //    var context = new EsportEventContext();
        //    context.PlayerStats.Remove(playerStats);
        //    context.SaveChanges();
        //}

        public void Delete(Team team)
        {
            var context = new EsportEventContext();
            context.Team.Remove(team);
            context.SaveChanges();
        }

        public void Delete(Tournament tournament)
        {
            var context = new EsportEventContext();
            context.Tournament.Remove(tournament);
            context.SaveChanges();
        }


        public List<Game> GetGames(string gameSearch)
        {
            using (var context = new EsportEventContext())
            {
                return context.Games.FromSql("SELECT * FROM Games")
                    .Where(m => m.Name.Contains(gameSearch))
                    .OrderByDescending(m => m.Name).ToList();
            }
        }

        public List<Match> GetMatch()
        {
            return null; 
        }
        public List<Player> GetPlayer() { return null; }
        public List<PlayerGame> GetPlayerGames() { return null; }
        public List<PlayerStats> GetPlayerStats() { return null; }

        public List<Team> GetTeam(string teamSearch, string gameSearch)
        {
            return null;
        }
        public List<Tournament> GetTournament() { return null; }



    }
}

