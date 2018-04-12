using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportEvent.Domain
{
    public class TeamMatch
    {
        public TeamMatch()
        {
        }

        public Team Team { get; set; }
        public int TeamId { get; set; }

        public Match Match { get; set; }
        public int MatchId { get; set; }

    }
}
