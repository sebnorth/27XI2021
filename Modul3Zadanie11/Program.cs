using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj wartość zmiennej n: ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            uint suma = 0; 

            for (uint i = 0; i < n-1; i++)
            {
                Console.Write("{0} + ", 2 * i + 1);
                suma += (2 * i + 1);
            }

            Console.Write("{0} = ", 2 * (n-1) + 1);
            suma += (2 * (n-1) + 1);
            Console.WriteLine(suma);
            Console.ReadKey();

}

    }
}
