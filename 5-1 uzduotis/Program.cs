using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris sveikuosius skaicius: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("a lygu b");
            }
            if (b == c)
            {
                Console.WriteLine("b lygu c");
            }
            if (a > b)
            {
                Console.WriteLine( "a yra daugiau uz b");
            }
            if (b > c * 2)
            {
                Console.WriteLine("b yra daugiau uz c * 2");
            }
            if (a % 2 == 0)
            {
                Console.WriteLine("a yra lyginis skaicius");
            }
            if (b % 2 != 0)
            {
                Console.WriteLine("b skaicius yra nelyginis");
            }
            if (c > 0)
            {
                Console.WriteLine("c skaicius yra teigiamas");
            }
            if (c < 0)
            {
                Console.WriteLine("c yra neigiamas");
            }
            Console.ReadLine();
        }
    }
}
