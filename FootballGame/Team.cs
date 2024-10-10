using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Team
    {
        public string TeamName { get; set; }
        players[] players { get; set; }

        public Team(string teamName)
        {
            TeamName = teamName;
            players = new players[11];

        }
    }
}  
