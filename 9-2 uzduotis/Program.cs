using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite gyvuno rusi");
            var a = Console.ReadLine();
            
            switch (a)
            {
                case "suo":
                    Console.WriteLine("tai suo");
                    break;
                case "kate":
                    Console.WriteLine("tai kate");
                    break;
                case "ziurkenas":
                    Console.WriteLine("tai ziurkenas");
                    break;
                case "triusis":
                    Console.WriteLine("tai triusis");
                    break;
                case "papuga":
                    Console.WriteLine("tai papuga");
                    break;
                default:
                    Console.WriteLine("nezinau tokio padaro");
                    break;
            }
            Console.ReadLine();
        }
    }
}
