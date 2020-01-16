using Kolokwium2Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2Sample.DAL
{
    public interface IDbLayer
    {
        IEnumerable<Player> GetPlayers();
        IEnumerable<Team> GetTeams();
        void AddNewPlayer(Player newPlayer);

    }
}
