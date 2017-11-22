using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite egzamino rezultata (0-100)");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a == 100)
            {
                Console.WriteLine("Sveikiname surinkote max");
            }
            else if (a >= 80)
            {
                Console.WriteLine("surinkote 80 arba daugiau");
            }
            else if (a >= 50)
            {
                Console.WriteLine("surinkote 50 arba daugiau");
            }
            else if (a >= 20)
            {
                Console.WriteLine("nekazka brolau, liudeselis");
            }
            else if (a < 20)
            {
                Console.WriteLine("siaubas, kartok kursa");
            }
            Console.ReadLine();
        }
    }
}
