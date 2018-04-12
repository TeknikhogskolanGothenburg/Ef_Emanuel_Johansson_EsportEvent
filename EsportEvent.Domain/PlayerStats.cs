using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportEvent.Domain
{
    public class PlayerStats
    {
        public PlayerStats()
        {

        }
        public int Id { get; set; }

        public int MatchId { get; set; }
        public Match Match { get; set; }

        public int PlayerGameId { get; set; }
        public PlayerGame PlayerGame { get; set; }

        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }

    }
}
