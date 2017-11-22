using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_pasibandymai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite teksta:");
            var tekstas = Console.ReadLine();
            Console.WriteLine("labas kompiuteri");
            Console.WriteLine(tekstas);
            Console.ReadLine();

            Console.WriteLine("iveskite skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32("25");
            Console.WriteLine(skaicius * 2);
            Console.ReadLine();

            /*int 2525; // int32
            short 25; // int16
            long 252525 // int64*/
        }
    }
}
