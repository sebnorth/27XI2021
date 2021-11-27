using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3Zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wysokość figury liczbowej: ");
            uint h = Convert.ToUInt32(Console.ReadLine());

            for (int i = 1; i <= h ; i++) // h - numer wiersza
            {
                for (int k = 1; k <= i; k++) // k - numer znaku
                {
                    Console.Write("{0,4} ", i*k);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
