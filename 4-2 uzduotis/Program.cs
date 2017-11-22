using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite simboli:");
            var simbolis = Console.ReadLine();
            Console.WriteLine(simbolis + simbolis + simbolis);
            Console.WriteLine(simbolis + simbolis + simbolis);
            Console.WriteLine(simbolis + simbolis + simbolis);
            Console.ReadLine();
            /* arba */
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.ReadLine();

        }
    }
}
