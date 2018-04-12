using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportEvent.Domain
{
   public class Player
    {
        public Player()
        {
            Games = new List<PlayerGame>();
        }
        public string UserName { get; set; }
        public string Name { get; set; }
        public List<PlayerGame> Games { get; set; }
        
    }
}
