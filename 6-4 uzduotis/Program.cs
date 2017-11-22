using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite gauta pazimi:");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a == 10)
            {
                Console.WriteLine("Puikiai");
            }
            else if (a == 8 && a == 9)
            {
                Console.WriteLine("Labai gerai");
            }
            else if (a >= 5 && a <= 7)
            {
                Console.WriteLine("Patenkinamai");
            }
            else if (a >= 3 && a <= 4)
            {
                Console.WriteLine("Prastai");
            }
            else if (a < 2)
            {
                Console.WriteLine("l.blogai");
            }
            Console.ReadLine();
        }
    }
}
