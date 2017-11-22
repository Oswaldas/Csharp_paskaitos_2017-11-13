using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite pasirinkimo nr: \n {1} - PC, \n {2} - Laptop, \n {3} - Tablet ");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            var a = 1;
            var b = 2;
            var c = 3;

            switch (skaicius)
            {
                case 1:
                    Console.WriteLine("stacionariu komp. galite naudotis tik namie");
                    break;
                case 2:
                    Console.WriteLine("nesiojamu komp galite naudotis visur");
                    break;
                case 3:
                    Console.WriteLine("plansete galite naudotis kur tik norit bet napatogi");
                    break;
                default:
                    Console.WriteLine("tokio pasirinkimo nera");
                    break;
            }
            Console.ReadLine();
        }
    }
}
