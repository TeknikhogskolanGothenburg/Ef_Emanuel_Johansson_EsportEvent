using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EsportEvent.Domain;
using Microsoft.EntityFrameworkCore;

namespace EsportEvent.Data
{
    public class PlayerGameRepo : GenericEsportRepo<PlayerGame, EsportEventContext>
    {
        public override void Add(PlayerGame playerGame)
        {
            PlayerRepo pr = new PlayerRepo();
            TeamRepo tr = new TeamRepo();
            GameRepo gr = new GameRepo();

            if (null != pr.FindBy(p => p.UserName == playerGame.Player.UserName).FirstOrDefault())
            {
                pr.Add(playerGame.Player);
                pr.Save();
            }

            if (null != tr.FindBy(p => p.Id == playerGame.Team.Id).FirstOrDefault())
            {
                tr.Add(playerGame.Team);
                tr.Save();
            }
            if (null != gr.FindBy(g => g.Name == playerGame.GameName).FirstOrDefault())
            {
                gr.Add(playerGame.Game);
                gr.Save();
            }
            
                Context.PlayerGames.Add(new PlayerGame
                {
                    GameName=playerGame.GameName,
                    PlayerNickName=playerGame.PlayerNickName,
                    PlayerRole=playerGame.PlayerRole,
                    PlayerUserName=playerGame.PlayerUserName,
                    Player=playerGame.Player,
                    
                });

            Save();
            
        }

        //Jag har valt att göra denna async då jag tror att admin till mintt program kommer att söka efter spelare många 
        //Gånger undet dens arbetsdag. Därför vill jag att detta ska kunna ske snabbt och att programmet kan jobba med annat
        //under tiden som den hämta detta från en extern databas. 
        public override async Task<ICollection<PlayerGame>> GetAllAsync()
        {
             return await Context.PlayerGames
                  .Include(g => g.Game)
                  .Include(t => t.Team)
                  .Include(p => p.Player)
                  .ThenInclude(p => p.Games).ToListAsync();
        }

        public override void Update(PlayerGame playerGame)
        {
            PlayerRepo pr = new PlayerRepo();
            TeamRepo tr = new TeamRepo();
            GameRepo gr = new GameRepo();

            if (null != pr.FindBy(p => p.UserName == playerGame.Player.UserName).FirstOrDefault())
            {
                pr.Add(playerGame.Player);
                pr.Save();
            }

            if (null != tr.FindBy(p => p.Id == playerGame.Team.Id).FirstOrDefault())
            {
                tr.Add(playerGame.Team);
                tr.Save();
            }
            if (null != gr.FindBy(g => g.Name == playerGame.GameName).FirstOrDefault())
            {
                gr.Add(playerGame.Game);
                gr.Save();
            }

            Context.PlayerGames.Update(playerGame);
            Save();
                
        }

    }
}
