using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość zmiennej ile: " );
            short ile = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < ile; i++)
            {
                if (i != ile - 1)
                {
                    Console.Write("{0}, ", 7 * i);
                }
                else {
                    Console.Write("{0}", 7 * i);
                }
            }

            Console.ReadKey();

        }
    }
}
