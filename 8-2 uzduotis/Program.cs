using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            if (a < b && a < c)
            {
                Console.WriteLine(a + " yra maziausias");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b + " yra maziausias");
            }
            else if (c < a && c < b)
            {
                Console.WriteLine(c + " yra maziausias");
            }
            else
            {
                Console.WriteLine(" skaiciai yra lygus");
            }
            Console.ReadLine();
        }
    }
}
