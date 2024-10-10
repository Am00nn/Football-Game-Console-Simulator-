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

        public void PlayersList(bool isTeam1)

        {

            string[] PlayersPostions = { "Forward", "Midfielder", "Defender", "Goalkeeper" };


            Random random = new Random();

            int x = 0;

            string[] Team1_PlayersName = { "Ali", " Ahmead", "Sulaman", "Salim", "Max", "Mahmoud", "Mohammed", "David", "Khaled", "Tareq", "Wael" };
            string[] team2_PlayersName1 = { "Sami", " Khalil", "Saif", "Asaad", "Hilal", "Ibrahim", "Hisham ", "Talal", "Hossam", "Hammam", "AbdulMalik" };

            string[] selectedPlayerNames;

            if (isTeam1)
            {
                selectedPlayerNames = Team1_PlayersName;
            }
            else
            {
                selectedPlayerNames = team2_PlayersName1;
            }
            for (int i = 0; i < players.Length; i++)
            {


                string playerName = selectedPlayerNames[i];
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

        public void displayTeam()
        {
            Console.WriteLine($"Team {TeamName} :");
            Console.WriteLine();
            Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-10}", "No.", "Player Name", "Position", "Skill Level");
            Console.WriteLine(new string('-', 65));
            for (int i = 0; i < players.Length; i++)
            {

                var player = players[i];
                Console.WriteLine("{0,-5} {1,-25} {2,-15} {3,-10}", i + 1, player.PlayerName, player.PlayerPosition, player.PlayerPower);
            }
        }


    }
}  
