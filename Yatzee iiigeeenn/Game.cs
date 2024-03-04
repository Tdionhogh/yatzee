using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

    namespace Yatzee_iiigeeenn
    {
    public class Game
    {
        private Scoreboard scoreboard;

        public Game(Scoreboard scoreboard)
        {
            this.scoreboard = scoreboard;
        }

        public void StartGame()
        {
            Console.WriteLine("Bedste Yatzy spil 2024!");
        }

        public void RunGameLoop()
        {
            bool gameOver = false;

            while (!gameOver)
            {
                Console.WriteLine("Vælg en handling:");
                Console.WriteLine("1. Spil en runde");
                Console.WriteLine("2. Scoreboard");
                Console.WriteLine("3. Afslut spil");

                // Læs brugerinput
                string input = Console.ReadLine();

                Dice dice = new Dice();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Næste runde");

                        // Rul alle terninger
                        int[] diceValues = dice.RollAllDice();

                        // Vis resultatet
                        Console.WriteLine("Du fik: " + string.Join(",", diceValues));

                        // Spilleren kan vælge at gemme nogle terninger og kaste igen
                        Console.WriteLine("Vil du gemme nogle terninger og kaste igen (ja/nej)");
                        string choice = Console.ReadLine();

                        if (choice.ToLower() == "ja")
                        {
                            // Vælg hvilke terninger der skal gemmes
                            Console.WriteLine("Indtast numrene på de terninger du vil gemme (f.eks. 1 3 5)");
                            string keepDiceInput = Console.ReadLine();
                            string[] keepDiceIndices = keepDiceInput.Split(' ');

                            // Opret et nyt array til at holde gemte terninger
                            int[] keptDice = new int[keepDiceIndices.Length];

                            // Gem de valgte terninger i det nye array
                            for (int i = 0; i < keepDiceIndices.Length; i++)
                            {
                                int index = int.Parse(keepDiceIndices[i]) - 1;
                                keptDice[i] = diceValues[index];
                            }

                            // Antallet af terninger, der skal kastes igen
                            int numDiceToRoll = 5 - keptDice.Length;

                            // Rul resterende terninger
                            int[] remainingDiceValues = dice.Roll(numDiceToRoll);

                            // Vis resultatet af de gemte terninger og de nye terninger
                            Console.WriteLine("Du gemte: " + string.Join(",", keptDice));
                            Console.WriteLine("De resterende terninger: " + string.Join(",", remainingDiceValues));

                            // Opdater scoreboard
                            Scoreboard.UpdateScoreboard(keptDice, remainingDiceValues);
                        }
                        break;

                    case "2":
                        Console.WriteLine("Scoreboard");
                        // Vis scoreboard
                        Console.WriteLine("Viser scoreboard...");
                        scoreboard.PrintScoreboard();
                        break;

                    case "3":
                        Console.WriteLine("Spillet afsluttes");
                        gameOver = true;
                        break;

                    default:
                        Console.WriteLine("Ugyldigt valg. Prøv igen");
                        break;
                }
            }

            EndGame();
        }

        public void EndGame()
        {
            Console.WriteLine("Tak for spillet");
        }
    }
  

}
