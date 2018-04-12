using System;
using System.Collections.Generic;

namespace EsportEvent.Domain
{
    public class Match
    {

        public Match()
        {
            Teams = new List<Team>();
        }

        public int Id { get; set; }

        public Game Game { get; set; }
        public string GameName { get; set; }

        public int TournamentId { get; set; }
        public DateTime GameDay { get; set; }
        public List<PlayerStats> PlayerStats { get; set; }
        public List<Team> Teams { get; set; }

    }
}