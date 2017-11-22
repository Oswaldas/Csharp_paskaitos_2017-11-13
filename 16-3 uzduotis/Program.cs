using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            double kuro_kiekis_100 = 6.5;
            double[] keliones = { 13, 13, 13, 13, 25, 25, 25, 25, 200, 200 };
            /* trumpiausia kelione;
             */
            var trumpiausia = keliones[0];
            foreach (var kelione in keliones)
            {
                if (kelione < trumpiausia)
                {
                    trumpiausia = kelione;
                }
            }
            Console.WriteLine("trumpiausia kelione: " + trumpiausia);
            /* ilgiausia kelione;
             */
            var ilgiausia = keliones[0];
            foreach (var kelione in keliones)
            {
                if (kelione > ilgiausia)
                {
                    ilgiausia = kelione;
                }
            }
            Console.WriteLine("ilgiausia kelione: " + ilgiausia);
            /* kuro_kiekis;
             */
            double suma = 0.0;

            foreach (var kelione in keliones)
            {
                suma += kelione;
            }
            var sanaudos = suma * (kuro_kiekis_100 / 100);

            Console.WriteLine("visas nuvaziuotas atstumas: " + suma);
            Console.WriteLine("kelionems vidutiniskai sunaudoto kuro kiekis: " + sanaudos);
            Console.ReadLine();
        }
    }
}
