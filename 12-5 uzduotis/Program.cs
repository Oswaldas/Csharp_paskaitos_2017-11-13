using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 1;
            
            while (skaicius % 9 != 0) 
            {
                Console.WriteLine("iveskite nauja skaiciu");
                skaicius = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine("skaicius dalinasi is 9, pabaiga");
            Console.ReadLine();
        }
    }
}
