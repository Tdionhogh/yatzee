using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Yatzee_iiigeeenn
{

    public class Rules_and_calculator
    {
        public int CountOnes(int[] diceValues)
        {
            return CountSpecificValue(diceValues, 1);
        }

        public int CountTwos(int[] diceValues)
        {
            return CountSpecificValue(diceValues, 2);
        }

        public int CountThrees(int[] diceValues)
        {
            return CountSpecificValue(diceValues, 3);
        }

        public int CountFours(int[] diceValues)
        {
            return CountSpecificValue(diceValues, 4);
        }

        public int CountFives(int[] diceValues)
        {
            return CountSpecificValue(diceValues, 5);
        }

        public int CountSixes(int[] diceValues)
        {
            return CountSpecificValue(diceValues, 6);
        }

        private int CountSpecificValue(int[] diceValues, int value)
        {
            return diceValues.Count(d => d == value) * value;
        }

        public int ThreeOfAKind(int[] diceValues)
        {
            if (HasnumberOfAKind(diceValues, 3))
            {
                return diceValues.Sum();
            }
            return 0;
        }

        public int FourOfAKind(int[] diceValues)
        {
            if (HasnumberOfAKind(diceValues, 4))
            {
                return diceValues.Sum();
            }
            return 0;
        }

        public int FullHouse(int[] diceValues)
        {
            Array.Sort(diceValues);

            bool hasThreeOfAKind = false;
            bool hasPair = false;

            for (int i = 0; i < diceValues.Length - 1; i++)
            {
                if (diceValues[i] == diceValues[i + 1])
                {
                    if (i < diceValues.Length - 2 && diceValues[i + 1] == diceValues[i + 2])
                    {
                        hasThreeOfAKind = true;
                    }
                    else if (!hasPair)
                    {
                        hasPair = true;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

            if (hasThreeOfAKind && hasPair)
            {
                return 25;
            }
            return 0;
        }

        public int SmallStraight(int[] diceValues)
        {
            Array.Sort(diceValues);

            for (int i = 0; i < diceValues.Length - 1; i++)
            {
                if (diceValues[i] + 1 != diceValues[i + 1])
                {
                    return 0;
                }
            }
            return 15;
        }

        public int LargeStraight(int[] diceValues)
        {
            Array.Sort(diceValues);

            if ((diceValues[0] == 1 && diceValues[4] == 5) || (diceValues[0] == 2 && diceValues[4] == 6))
            {
                return 20;
            }
            return 0;
        }

        public int Chance(int[] diceValues)
        {
            return diceValues.Sum();
        }

        public int Yatzee(int[] diceValues)
        {
            int firstValue = diceValues[0];

            foreach (int value in diceValues)
            {
                if (value != firstValue)
                {
                    return 0;
                }
            }
            return 50;
        }
        
        private bool HasnumberOfAKind(int[] diceValues, int numberOfAkind)
        {
            foreach (int value in diceValues)
            {
                if (diceValues.Count(v => v == value) >= numberOfAKind)
                {
                    return true;
                }

            }
            return false;

        }
    }
}


    
