using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3Zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj kraniec przedziału a: ");
            uint a = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Podaj kraniec przedziału b: ");
            uint b = Convert.ToUInt32(Console.ReadLine());

            // trzy zmienne i,j,k oznaczające długości boków trójkąta
            for (uint i = a; i <= b; i++)
            {
                for (uint j = i; j <= b; j++)
                {
                    for (uint k = j+1; k<=b; k++)
                    {
                        if (i*i + j*j == k*k)
                        {
                            Console.WriteLine("{0} {1} {2}",i,j,k);
                        }
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
