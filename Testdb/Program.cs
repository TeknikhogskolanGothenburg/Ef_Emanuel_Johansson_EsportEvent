using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsportEvent.Data;
using EsportEvent.Domain;

namespace Testdb
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameRepo = new GameRepo();
            var matchRepo = new MatchRepo();
                var playerGameRepo = new PlayerGameRepo();
            var playerRepo = new PlayerRepo();
                var playerStats = new PlayerStatsRepo();
            var teamRepo = new TeamRepo();
            var teamMatchReop = new TeamMatchRepo();
            var TournamentRepo = new TournamentRepo();
           

        }
    }
}
           
