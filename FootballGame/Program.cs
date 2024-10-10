namespace FootballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Soccer Game Simulator!");
            Console.Write("\nEnter name for Team 1: ");
            string team1Name = Console.ReadLine();

            Console.Write("Enter name for Team 2: ");
            string team2Name = Console.ReadLine();

            Team team1 = new Team(team1Name);
            Team team2 = new Team(team2Name);
            
            Game game = new(team1, team2);
            team1.PlayersList(true);
            team2.PlayersList(false);

            team1.displayTeam();
            Console.WriteLine();
            team2.displayTeam();
            game.InitiateGame();
            game.DisplayFinalScore();
        }
    }
}
