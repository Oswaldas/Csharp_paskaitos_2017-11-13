using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite savo varda:");
            var vardas = Console.ReadLine();
            Console.WriteLine("iveskite savo amziu: ");
            var amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("jusu vardas: {0}, o amzius: {1} ", vardas, amzius);
            Console.ReadLine();
        }
    }
}
