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
    public class MatchRepo : GenericEsportRepo<Match, EsportEventContext>
    {


        public override ICollection<Match> GetAll()
        {
            return Context.Matches
                .Include(t => t.Game)
                .Include(p => p.PlayerStats)
                .Include(t => t.Teams)
                .ToList();               
        }

        public override Task<ICollection<Match>> GetAllAsync()
        {
            return base.GetAllAsync();
        }
        public override ICollection<Match> FindBy(Expression<Func<Match, bool>> predicate)
        {
            return base.FindBy(predicate);
        }
        public override Task<ICollection<Match>> FindByAsync(Expression<Func<Match, bool>> predicate)
        {
            return base.FindByAsync(predicate);
        }

        //__________________________________________________________________

        public override void Add(Match entity)
        {
            TeamMatchRepo teamMatch = new TeamMatchRepo();
            var match = new Match
            {
                GameName = entity.GameName,
                GameDay = entity.GameDay,
                TournamentId = entity.TournamentId
            };

            Context.Add(match);

            Save();
            teamMatch.AddRange(new List<TeamMatch>
            {
                new TeamMatch{MatchId=match.Id, TeamId = entity.Teams[0].Id},
                new TeamMatch{MatchId=match.Id, TeamId = entity.Teams[1].Id }
            });
            teamMatch.Save();
        }

        public override async void AddAsync(Match entity)
        {
            TeamMatchRepo teamMatch = new TeamMatchRepo();
           await Context.AddAsync(new Match
            {
                GameName = entity.GameName,
                GameDay = entity.GameDay,
                TournamentId = entity.Id,
            });
            SaveAsync();

            Task.WaitAll();
             teamMatch.AddRangeAsync(new List<TeamMatch>
            {
                new TeamMatch{MatchId=entity.Id, TeamId=entity.Teams[0].Id},
                new TeamMatch{MatchId=entity.Id, TeamId = entity.Teams[1].Id }
            });
        }

        public override void AddRange(ICollection<Match> entities)
        {
            var list = entities.ToList();

            for (int i = 0; i < entities.Count; i++)
            {
                TeamMatchRepo teamMatch = new TeamMatchRepo();
                Context.Add(new Match
                {
                    GameName = list[i].GameName,
                    GameDay = list[i].GameDay,
                    TournamentId = list[i].Id,
                });
                Save();
                teamMatch.AddRange(new List<TeamMatch>
            {
                new TeamMatch{MatchId=list[i].Id, TeamId=list[i].Teams[0].Id},
                new TeamMatch{MatchId=list[i].Id, TeamId = list[i].Teams[1].Id }
            });
            }
        }

        public override async void AddRangeAsync(ICollection<Match> entities)
        {
            var list = entities.ToList();

            for (int i = 0; i < entities.Count; i++)
            {
                TeamMatchRepo teamMatch = new TeamMatchRepo();
                await Context.AddAsync(new Match
                {
                    GameName = list[i].GameName,
                    GameDay = list[i].GameDay,
                    TournamentId = list[i].Id,
                });
                Save();
                Task.WaitAll();
                teamMatch.AddRange(new List<TeamMatch>
                {
                    new TeamMatch{MatchId=list[i].Id, TeamId=list[i].Teams[0].Id},
                    new TeamMatch{MatchId=list[i].Id, TeamId = list[i].Teams[1].Id }
                 });
            }
        }

    }
}
