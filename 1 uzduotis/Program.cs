using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 0;
           

            while (skaicius > 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (skaicius % i == 0) ;
                }
                    Console.WriteLine(skaicius);
            }
            Console.ReadLine();
            /*
             var skaicius = 0;
            var tikrina = 0;
            var reiksme = 0;

            while (skaicius > 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (skaicius % i == 0) { tikrina += 1; }
                }
                if (reiksme == 10)
                    Console.WriteLine(skaicius);
            }
            Console.ReadLine();
             */
        }
    }
}
