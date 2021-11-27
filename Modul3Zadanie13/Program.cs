using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3Zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wysokość figury liczbowej: ");
            uint n = Convert.ToUInt32(Console.ReadLine());

            /* s+k = n => s = n-k
             * 1 wiersz (n-1) spacji 1 krzyżyk
             * 2 wiersz (n-2) spacji 2 krzyżyk
             * ...
             * n wierszy (n-n=0) spacji n krzyżyków
            */

            for (int k = 1; k <= n; k++)
            {
                // pętla rysujaca spacje
                for (int s = 1; s <= n-k; s++)
                {
                    Console.Write(" ");
                }

                //// pętla rysująca krzyżyki
                //for (int i = 1; i <= k; i++)
                //{
                //    Console.Write("X");
                //}

                // 1 krzyżyk
                Console.Write("X");
                // k - 2 spacji
                for (int i = 1; i <= k-2; i++)
                {
                    Console.Write(" ");
                }

                // 1 krzyżyk 
                Console.Write("X");

                // przejście do nowej linii
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
