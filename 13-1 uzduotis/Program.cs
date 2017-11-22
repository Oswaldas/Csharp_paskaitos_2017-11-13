using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int pasirinkimas;
            do
            {
                Console.WriteLine("pasirinkite megstamiausia gyvuna: 1 - suo, 2 - kate, 3 - banginis");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());

                if (pasirinkimas < 1 || pasirinkimas > 3)
                {
                    Console.WriteLine("blogai ivesta, nepazistate skaiciu");
                }
            } while (pasirinkimas < 1 || pasirinkimas > 3);

            Console.WriteLine("pasirinkimas: " + pasirinkimas);
            Console.ReadLine();
        }
        
    }
}
