using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* program sprawdza czy n jest pierwsza
             * def. liczby pierwszej: 
             * dzieli się przez 1, przez samą siebie 
             * i nie ma więcej dzielników
           */

            Console.WriteLine("Podaj n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int licznikDzielnikow = 0;
            int i = 1;

            while (i<=n)
            {
                if (n%i==0)
                {
                    licznikDzielnikow++;
                }

                i++;
            }

            if (licznikDzielnikow == 2)
            {
                Console.WriteLine("Liczba {0} jest pierwsza.", n);
            }
            else {

                Console.WriteLine("Liczba {0} nie jest pierwsza.", n);
            }

            Console.ReadKey();
        }
    }
}
