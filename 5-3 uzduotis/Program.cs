using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite bet koki teigiama skaiciu: ");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("A tu durns, ka cia rasineji nesamones, sakiau teigiama!");
            }
            if (a > 0)
            {
                Console.WriteLine("maladiec, saunuolis, tu tikras genijus!");
            }
            if (a % 2 == 0)
            {
                Console.WriteLine("skaicius yra lyginis");
            }
            if (a / 4 == 0)
            {
                Console.WriteLine("skaicius dalinasi is 4");
            }
            if (a > 10)
            {
                Console.WriteLine("skaicius  > 10");
            }
            Console.ReadLine();
        }
    }
}
