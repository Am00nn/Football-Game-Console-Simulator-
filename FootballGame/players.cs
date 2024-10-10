using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class players
    {
        public string PlayerName { get; set; }
        public string PlayerPosition { get; set; }
        public int PlayerPower { get; set; }

        public players(string PlayerName, string PlayerPosition, int PlayerPower)
        {


            this.PlayerName = PlayerName;
            this.PlayerPosition = PlayerPosition;
            this.PlayerPower = PlayerPower;

        }





    }
}
