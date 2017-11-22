using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite viena skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine(a + " yra neigiamas");
            }
            else if (a > 0)
            {
                Console.WriteLine(a + " yra teigiamas");
            }
            else
            {
                Console.WriteLine(a + " = 0");
            }
            Console.ReadLine();
        }
    }
}
