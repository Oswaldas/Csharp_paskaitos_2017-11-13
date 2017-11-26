using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var darbuotojas = new Darbuotojas("Jonas", "Jonaitis", 20, 500, 1);
            darbuotojas.Isvedimas();
            Console.WriteLine();

            var policininkas = new Policininkas("Petras", "Petraitis", 30, 600, 1, 100, 20);
            policininkas.Isvedimas();
            Console.WriteLine();

            var gaisrininkas = new Gaisrininkas("Antanas", "Antanaitis", 25, 450, 1, 50, 1500);
            gaisrininkas.Isvedimas();
            Console.WriteLine();

            var medikas = new Medikas("Juozas", "Juozaitis", 35, 800, 0.6, 200, 0.4, 400);
            medikas.Isvedimas();
            Console.WriteLine();
        }
    }
}
