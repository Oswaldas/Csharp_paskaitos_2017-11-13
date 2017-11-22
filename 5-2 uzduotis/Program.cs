using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite savo amziu: ");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("jus galite balsuoti");
            }
            Console.ReadLine();
        }
    }
}
