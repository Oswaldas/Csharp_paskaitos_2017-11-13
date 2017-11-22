using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite pasirinkimo nr: \n {1} - vanduo, \n {2} - kava, \n {3} - arbata ");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            var a = 1;
            var b = 2;
            var c = 3;

            switch (skaicius)
            {
                case 1:
                    Console.WriteLine("jus pasirinkote vandeni");
                    break;
                case 2:
                    Console.WriteLine("jus pasirinkote kava");
                    break;
                case 3:
                    Console.WriteLine("jus pasirinkote arbata");
                    break;
                default:
                    Console.WriteLine("apgailestaujame, bet, deja, tokio pasirinkimo nera");
                    break;
            }
            Console.ReadLine();
        }
    }
}
