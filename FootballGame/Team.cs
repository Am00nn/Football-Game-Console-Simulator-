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

        public void PlayersList()

        {

            string[] PlayersPostions = { "Forward", "Midfielder", "Defender", "Goalkeeper" };


            Random random = new Random();

            int x = 0;

            string[] PlayerName = { "Ali", " Ahmead", "Sulaman", "Salim", "Max", "Mahmoud", "Mohammed", "David", "Khaled", "Tareq", "Wael" };

            for (int i = 0; i < players.Length; i++)
            {


                string playerName = PlayerName[i];
                int power = random.Next(1, 101);

                string position = PlayersPostions[x];

                x++;
                if (x >= PlayersPostions.Length)
                {
                    x = 0;
                }



                players[i] = new players(playerName, position, power);

            }




        }


        public int Attack()

        {
            int Skilllevels = 0;
            foreach (var player in players)
            {


                if (player.PlayerPosition == "Forward" || player.PlayerPosition == "Midfielder")
                {

                    Skilllevels += player.PlayerPower;
                }


            }

            return Skilllevels;

        }


        public int Defense()

        {
            int Skilllevels = 0;
            foreach (var player in players)
            {


                if (player.PlayerPosition == "Defender" || player.PlayerPosition == "Goalkeeper")
                {

                    Skilllevels += player.PlayerPower;
                }


            }

            return Skilllevels;

        }

    }
}  
