using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite du skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            if (a > b || a == 0)
            {
                Console.WriteLine(a + " daugiau uz b arba = 0");
            }
            if (b > a || b == 5)
            {
                Console.WriteLine(b + " daugiau uz a arba = 5");
            }
            if (a > b && a == 20)
            {
                Console.WriteLine(a + " daugiau uz a arba = 5");
            }
            if (a > b && a < 100)
            {
                Console.WriteLine(a + " yra maziausias");
            }
            else
            {
                Console.WriteLine(" skaiciai yra lygus");
            }
                Console.ReadLine();
            }
        }
    }

