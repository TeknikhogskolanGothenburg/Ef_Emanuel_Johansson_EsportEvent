using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportEvent.Domain
{
    public class PlayerGame
    {
        public PlayerGame()
        {

        }

        public int Id { get; set; }

        public string PlayerUserName { get; set; }
        public Player Player { get; set; }

        public string GameName { get; set; }
        public Game Game { get; set; }
   
        public int TeamId { get; set; }
        public Team Team {get; set;}

        public string PlayerNickName { get; set; }
        public string PlayerRole { get; set; }
    }
}
