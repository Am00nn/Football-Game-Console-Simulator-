using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Game
    {
        public Team T1 { get; set; }
        public Team T2 { get; set; }

        public int T1Score = 0;
        public int T2Score = 0;
        public Random random;

        public Game(Team T1, Team T2)
        {

            this.T1 = T1;
            this.T2 = T2;
            random = new Random();

        }


        public void InitiateGame()
        {
                       
            Console.WriteLine("\n============= Coin toss ============");

            string StartingTeam = PerformCoinToss();
            Console.WriteLine($"\n {StartingTeam} will start the game ");
            StartGameHalves(StartingTeam);

        }

        public string PerformCoinToss()
        {
            int teamstart = random.Next(0, 2);
            if (teamstart == 0)
            {
                return T1.TeamName;

            }
            else
            {
                return T2.TeamName;

            }

        }

        public void StartGameHalves(string startingTeam)
        {

            bool flag_Team1 = (startingTeam == T1.TeamName);

            PlayHalf("First Half", flag_Team1);
            PlayHalf("Second Half", !flag_Team1);
        }

        public void PlayHalf(string halfName, bool Flag_Team1)
        {
            Console.WriteLine("\n============= " + halfName + " ============ ");


            for (int turn = 1; turn <= 5; turn++)
            {

                if (Flag_Team1)
                {
                    ExecuteTurn(T1, T2, turn);
                }
                else
                {
                    ExecuteTurn(T2, T1, turn);
                }


                Flag_Team1 = !Flag_Team1;
            }
        }

        public void ExecuteTurn(Team attacking, Team defending, int turn)
        {
            Console.WriteLine($"\n============= Turn {turn} ================");
            Console.WriteLine("Attacking Team: " + attacking.TeamName + " vs Defending Team: " + defending.TeamName);

            int attackPower = attacking.Attack();
            int defensePower = defending.Defense();

            Console.WriteLine($"\n{attacking.TeamName} Attack Power   {attackPower}");
            Console.WriteLine($"\n{defending.TeamName}   Defense Power:  {defensePower}");

            int defenseBonus = 15;

            if (attackPower > defensePower + defenseBonus)
            {

                Console.WriteLine("\nGoal");
                UpdateScore(attacking);
            }
            else
            {
                Console.WriteLine("\nDefended!");
            }

            DisplayCurrentScore();
        }

        public void UpdateScore(Team attacking)
        {
            if (attacking == T1)
            {
                T1Score++;
            }
            else
            {
                T2Score++;
            }
        }

        public void DisplayCurrentScore()
        {
            Console.WriteLine("\nScore:");
            Console.WriteLine(T1.TeamName + ": " + T1Score + " | " + T2.TeamName + ": " + T2Score);
            Console.WriteLine("================================\n");
        }

        public void DisplayFinalScore()
        {
            Console.WriteLine("\n====== Final Score ======");
            Console.WriteLine($"{T1.TeamName}: {T1Score} | {T2.TeamName}: {T2Score}");


            if (T1Score > T2Score)
            {
                Console.WriteLine($"\n {T1.TeamName} wins the game!");
            }
            else if (T2Score > T1Score)
            {
                Console.WriteLine($"\n {T2.TeamName} wins the game!");
            }
            else
            {
                Console.WriteLine("\n The game ends in a draw!");
            }

            Console.WriteLine("==========================\n");
        }




    }








        
 }
