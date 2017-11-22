using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius: ");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("({0} + {1} + {2}) / 3 = {3}",
                pirmas, antras, trecias, ( pirmas + antras + trecias ) / 3);
            Console.ReadLine();
            /* arba */
            Console.WriteLine("iveskite tris skaicius: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            float vidurkis = (a + b + c) / 3;
            Console.WriteLine("Skaiciu {0},{1},{2} vidurkis yra {3}", a, b, c, Math.Round(vidurkis, 2));
            Console.ReadLine();
        }
    }
}
