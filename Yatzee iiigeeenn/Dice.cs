using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzee_iiigeeenn
{
    public class Dice
    {
        private Random random;

        public Dice()
        {
            random = new Random();
        }

        // simulerer terningkast ved tilfældig generering af tal imellem 1-6
        public int Roll()
        {
            return random.Next(1, 7);
        }

        // simulerer rul med alle terninger og værdier gemt i array
        public int[] RollAllDice()
        {
            int[] diceValues = new int[5]; // array oprettes til at gemme værdierne

            // rul hver terning og gem værdi
            for (int i = 0; i < 5; i++)
            {
                diceValues[i] = Roll(); // Roll bruges til at rulle terninger.
            }

            return diceValues; // returnerer array med værdierne af terningerne.
        }

        // kan rulle et givent antal terninger.
        public int[] Roll(int numDice)
        {
            int[] diceValues = new int[numDice];

            for (int i = 0; i < numDice; i++)
            {
                diceValues[i] = Roll();
            }

            return diceValues; // returnerer array med værdier
        }
    }
}

