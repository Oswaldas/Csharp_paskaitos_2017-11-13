using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite pradini skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite paskutini skaiciu");
            var b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                for (int i = a; i < b; i++)
                {
                    Console.WriteLine(i + " " + i * i);
                }
            }

            Console.ReadLine();
        }
    }
}