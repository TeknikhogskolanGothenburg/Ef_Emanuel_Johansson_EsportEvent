using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportEvent.Domain
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GameName { get; set; }
        public Game Game { get; set; }
        public List<Match> Matches { get; set; }
    }
}
