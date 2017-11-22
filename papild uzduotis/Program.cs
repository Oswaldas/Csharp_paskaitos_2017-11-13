using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papild_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Iveskite du skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            { Console.WriteLine("SKaičiai lygus"); }
            else
            { Console.WriteLine("SKaičiai nelygus"); }


            Console.WriteLine("Iveskite 1 skaicius");
            var c = Convert.ToInt32(Console.ReadLine());
            if (c % 2 == 0)
            { Console.WriteLine("Skaicius lyginis"); }
            else { Console.WriteLine("Skaicius nelyginis"); }


            Console.WriteLine("Iveskite 1 skaicius");
            var d = Convert.ToInt32(Console.ReadLine());
            if (d > 0)
            { Console.WriteLine("Skaicius teigiamas"); }
            else if (d < 0) { Console.WriteLine("Skaicius nelyginis"); }
            else { Console.WriteLine("Skaicius =0"); }

            */

            Console.WriteLine("Iveskite metus");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a % 400 == 0 || (a % 100 != 0 && a % 4 == 0))
            {
                Console.WriteLine("keliamieji");
            }
            else
            {
                Console.WriteLine("nekeliamieji");
            }
            Console.ReadLine();
        }
    }
}
