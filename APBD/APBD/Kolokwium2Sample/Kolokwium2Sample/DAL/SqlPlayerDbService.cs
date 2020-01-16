using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium2Sample.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2Sample.DAL
{
    public class SqlPlayerDbService : IDbLayer
    {
        private readonly PlayerDbContext _context;

        public SqlPlayerDbService(PlayerDbContext context)
        {
            _context = context;
        }

        public void AddNewPlayer(Player newPlayer)
        {
            _context.Add(newPlayer);
            _context.SaveChanges();
        }

        public IEnumerable<Player> GetPlayers()
        {
            return _context.Players
                            .Include(p => p.Team)
                            .OrderBy(p => p.LastName)
                            .ThenBy(p => p.FirstName)
                            .ToList();
        }

        public IEnumerable<Team> GetTeams()
        {
            return _context.Teams.ToList();
        }
    }
}
