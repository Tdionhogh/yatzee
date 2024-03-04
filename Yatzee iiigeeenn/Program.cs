namespace Yatzee_iiigeeenn
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // Opret en instans af Scoreboard-klassen
            int[] player1Scores = new int[16]; // Initialisér scoreboard for spiller 1
            int[] player2Scores = new int[16]; // Initialisér scoreboard for spiller 2
            Scoreboard scoreboard = new Scoreboard(player1Scores, player2Scores);

            // Opret en instans af Game-klassen og tilføj scoreboard
            Game yatzeegame = new Game(scoreboard);

            // Start spillet
            yatzeegame.StartGame();

            // Kør spillets løkke
            yatzeegame.RunGameLoop();

            // Spillet er afsluttet
            Console.WriteLine("Spillet er afsluttet");
        }
    }

  
    }





