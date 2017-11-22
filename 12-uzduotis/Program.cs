using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite neigiama skaiciu: ");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius < 0)
            {
                while (skaicius <= 0)
                {
                    Console.Write(skaicius + " ");
                    skaicius++;
                } 
            }
            else
            {
                Console.WriteLine("skaicius teigiamas");
            }
            Console.ReadLine();
        }
    }
}
