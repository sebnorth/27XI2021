using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int iloczyn = 1;
            int i = 1;

            // 1*2*3*... * n
            while (i<=n)
            {
                iloczyn = iloczyn * i;
                i++;
            }

            Console.WriteLine("n silnia wynosi: {0}", iloczyn);
            Console.ReadKey();

        }
    }
}
