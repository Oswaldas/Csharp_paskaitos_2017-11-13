using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite teigiama skaiciu: ");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------");
            if (skaicius > 0)
            {
                while (skaicius > 0)
                {
                    Console.WriteLine(skaicius);
                    skaicius--;
                }
            }
            else
            {
                Console.WriteLine("skaicius neigiamas");
            }
               Console.ReadLine(); 
        }
       
    }
}
