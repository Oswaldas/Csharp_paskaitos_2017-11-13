using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>();
            // atsitiktiniu skaiciu generavimui
            var rnd = new Random();
            // kiek skaiciu noresite sugeneruoti
            var kiekSugeneruoti = rnd.Next(1, 101); // [1-100)

            // sudedam norima kieki atsitiktiniu skaiciu

            for (int i = 0; i < kiekSugeneruoti; i++)
            {
                // generuojam atsitiktiniu skaiciu ir ji dedam i sarasa
                skaiciai.Add(rnd.Next(1, 101));

                // isvedam katik  ideta skaiciu
                Console.Write(skaiciai[i] + " ");
            }
            Console.WriteLine("maziausias skaicius: " + skaiciai.Min());
            Console.WriteLine("didziausias skaicius: " + skaiciai.Max());

            var vidurkis = skaiciai.Average();
            var zenesnisUzVIdurki = 0;
            Console.WriteLine("vidurkis: " + skaiciai.Average());

            foreach (var skaicius in skaiciai)
            {
                if (skaicius < vidurkis)
                {
                    zenesnisUzVIdurki++;
                }
            }
            Console.WriteLine("skaiciu mazesniu uz vidurki kiekis: " + zenesnisUzVIdurki);

            var suma = 0;
            Console.WriteLine("vidurkis: " + skaiciai.Average());

            foreach (var skaicius in skaiciai)
            {
                if (skaicius % 2 == 0)
                {
                     suma += skaicius;
                }
            }
            Console.WriteLine("lyginiu skaiciu suma: " + suma);
            Console.ReadLine();
        }
    }
}
