using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var marke = "Porche";
            var modelis = "911";
            var metai = 2017;
            var rida = 15000;

            Console.WriteLine("Auttomobilio {0}{1}({2}m.) rida - {3} km.", marke, modelis, metai, rida);
            Console.ReadLine();

        }
    }
}
