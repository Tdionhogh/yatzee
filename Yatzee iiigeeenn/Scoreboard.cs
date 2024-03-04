using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzee_iiigeeenn
{

    public class Scoreboard
    {
        
            private int[] player1score;
        private int[] player2score;

        public Scoreboard(int[] player1score, int[] player2score)
        {
            this.player1score = player1score;
            this.player2score = player2score;
        }


        public void PrintScoreboard()
        {
            Console.WriteLine(" Scoreboard ");

            Console.WriteLine("1             \t" + player1score[0] + "\t\t" + player2score[0]);
            Console.WriteLine("2             \t" + player1score[1] + "\t\t" + player2score[1]);
            Console.WriteLine("3             \t" + player1score[2] + "\t\t" + player2score[2]);
            Console.WriteLine("4             \t" + player1score[3] + "\t\t" + player2score[3]);
            Console.WriteLine("5             \t" + player1score[4] + "\t\t" + player2score[4]);
            Console.WriteLine("6             \t" + player1score[5] + "\t\t" + player2score[5]);
            Console.WriteLine("sum           \t" + player1score[6] + "\t\t" + player2score[6]);
            Console.WriteLine("bonus         \t" + player1score[7] + "\t\t" + player2score[7]);
            Console.WriteLine("3 ens         \t" + player1score[8] + "\t\t" + player2score[8]);
            Console.WriteLine("4 ens         \t" + player1score[9] + "\t\t" + player2score[9]);
            Console.WriteLine("fuldt hus     \t" + player1score[10] + "\t\t" + player2score[10]);
            Console.WriteLine("Lille straight\t" + player1score[11] + "\t\t" + player2score[11]);
            Console.WriteLine("Stor straight \t" + player1score[12] + "\t\t" + player2score[12]);
            Console.WriteLine("Chance        \t" + player1score[13] + "\t\t" + player2score[13]);
            Console.WriteLine("yatzee        \t" + player1score[14] + "\t\t" + player2score[14]);
            Console.WriteLine("Samlet score  \t" + player1score[15] + "\t\t" + player2score[15]);
        }
    }
}





