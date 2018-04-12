using EsportEvent.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EsportEvent.Data
{
    public class PlayerRepo : GenericEsportRepo<Player, EsportEventContext>
    {
        public override void Delete(Player player)
        {
            Context.PlayerGames.RemoveRange(player.Games);
            Context.Players.Remove(player);
            Context.SaveChanges();
        }

        public override void DeleteRange(ICollection<Player> entities)
        {

        }

        public override ICollection<Player> FindBy(Expression<Func<Player, bool>> predicate)
        {
            return Context.Players.Where(predicate)
                   .Include(g => g.Games)
                   .ThenInclude(t => t.Team)
                   .ToList();
        }

        public override async Task<ICollection<Player>> FindByAsync(Expression<Func<Player, bool>> predicate)
        {
            return await Context.Players.Where(predicate)
                   .Include(g => g.Games)
                   .ThenInclude(t => t.Team)
                   .ToListAsync();


        }

        public override ICollection<Player> GetAll()
        {
            return Context.Players
                .Include(g => g.Games)
                .ThenInclude(t => t.Team)
                .ToList();
                
        }

        public async override Task<ICollection<Player>> GetAllAsync()
        {
            return await Context.Players
                .Include(g => g.Games)
                .ThenInclude(t => t.Team)
                .ToListAsync();
        }

        public override void Update(Player entity)
        {
            Context.Update(new Player {Name=entity.Name, UserName=entity.UserName });
        }

        public override void UpdateRange(ICollection<Player> entities)
        {
            List<Player> players = entities.ToList();
            for (int i = 0; i< entities.Count; i++)
            {
                Context.Update(new Player { Name = players[i].Name, UserName = players[i].UserName });
            }
        }
    }
}

