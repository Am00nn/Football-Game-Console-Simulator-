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

            Console.WriteLine("\n *****Coin toss ******");

            string StartingTeam = PerformCoinToss();
            Console.WriteLine($"\n {StartingTeam} will start the game ");
            StartSecondHalves(StartingTeam);

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

        public void StartSecondHalves(string startingTeam)
        {

            if (startingTeam == T1.TeamName)
            {
                PlayHalf("First Half", true);
                PlayHalf("Second Half", false);
            }
            else
            {
                PlayHalf("First Half", false);
                PlayHalf("Second Half", true);
            }
        }

        public void PlayHalf(string halfename, bool isTeam1Starting)
        {


            Console.WriteLine($"/n-----------------{halfename}------------ ");

            for (int turn = 1; turn <= 5; turn++)
            {
                if (isTeam1Starting)
                {
                    Turn(T1, T2, turn);
                }
                else
                {
                    Turn(T2, T2, turn);

                }

                isTeam1Starting = !isTeam1Starting;
            }




        }

        public void Turn(Team attacking, Team defending, int turn)
        {
            Console.WriteLine($"\n--- Turn {turn} ---");

            Console.WriteLine($"Attacking Team: {attacking.TeamName} vs Defending Team: {defending.TeamName}");

            int powerOfAttacking = attacking.Attack();

            int powerOfDefending = defending.Defense();

            Console.WriteLine($"{attacking.TeamName} Attack Power: {powerOfAttacking}");

            Console.WriteLine($"{defending.TeamName} Defense Power: {powerOfDefending}");


            int defenseBonus = random.Next(1, 21);
            Console.WriteLine($"{defending.TeamName} Defense Bonus: {defenseBonus}");

            if (powerOfAttacking > powerOfDefending + defenseBonus)
            {

                Console.WriteLine(" Goal!!!");

                if (attacking == T1)
                {
                    T1Score++;
                }
                else
                {
                    T2Score++;
                }
            }
            else
            {

                Console.WriteLine("Defended!");
            }


            Console.WriteLine($"\n Score:");

            Console.WriteLine($"{T1.TeamName}: {T1Score} | {T2.TeamName}: {T2Score}\n");

            Console.WriteLine("----------------------------\n");
        }




    }



        
 }
