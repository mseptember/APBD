using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2Sample.Models
{
    public class Team
    {
        public int IdTeam { get; set; }
        public string Name { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
