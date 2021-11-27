using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int cyfra;
            int suma = 0;

            while (n>0)
            {
                cyfra = n % 10;
                suma += cyfra;
                n -= cyfra;
                n /= 10;

            }

            Console.WriteLine("Suma cyfr wynosi: {0}", suma);
        }
    }
}
