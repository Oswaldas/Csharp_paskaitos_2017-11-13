using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Parduotuve
{
    class Parduotuve
    {
        // propg
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Preke> Prekes { get; private set; } // visu prekiu sarasas
        // ctorg

        public Parduotuve(string pavadinimas, string adresas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Prekes = new List<Preke>(); // sugeneruojam prakes is listo
            //SugeneruotiPrelkes();
            Console.WriteLine("1. Generuoti prekes");
            Console.WriteLine("2. Suvesti prekes");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1: SugeneruotiPrekes(); break;
                case 2: SuvestiPrekes(); break;

                default: SugeneruotiPrekes(); break;
            }
        }

        public Parduotuve(string pavadinimas, string adresas, List<Preke> prekes)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Prekes = prekes;
        }

        public void SugeneruotiPrekes()
        {
            var rnd = new Random();
            var kiekPrekiu = rnd.Next(1,20);
            var sakinys =
                "Lorem ipsum dolor sit amet consectetur adipiscing elit Donec sed porttitor ante Donec in nisi gravida ante pellentesque mattis et";
            var zodziai = sakinys.Split(' ');

            //var zodziai = new string[]
            for (int i = 0; i < kiekPrekiu; i++)
            {
                var pavadinimas = zodziai[rnd.Next(zodziai.Length)];
                //"Lorem", "ipsum", "dolor", "sit", "amet", "consectetur", "adipiscing", "elit", "Donec", "sed", "porttitor", "ante", "Donec", "in", "nisi", "gravida", "ante", "pellentesque", "mattis", "et",
                var kodas = rnd.Next(10000, 100000).ToString(); // ToString - nes kintamasis yra string tipo
                var kaina = rnd.Next(50, 100);
                var savikaina = rnd.Next(1, 50);
                var kiekis = rnd.Next(1, 100);
                var preke = new Preke(pavadinimas, kodas, kaina, savikaina, kiekis);
                Prekes.Add(preke);
            }
        }
        // parduotuves isvedimo metodas
        public void Isvedimas() 
        {
            Console.WriteLine("Pavadinimas: " + Pavadinimas);
            Console.WriteLine("Adresas: " + Adresas);
            Console.WriteLine("Prekiu kiekis: " + Prekes.Count); // kiek susigeneravo is listo
            Console.WriteLine();

            foreach (var preke in Prekes)
            {
                // naudojamas metodas yra prekes klaseje
                preke.Isvedimas();
            }

            Console.WriteLine("Skaiciavimai: ");
            Console.WriteLine("Visu prekiu kainu suma: " + KainuSuma());
            Console.WriteLine("Visu prekiu savikainu suma: " + SavikainuSuma());
            Console.WriteLine("Visu prekiu pajamos: " + Pajamos());
            Console.WriteLine("Visu prekiu pelnas: " + BendrasPelnas());
            Console.WriteLine("Maziausias prekiu kiekis: ");
            MaziausiasKiekis().Isvedimas();
            /*var maziausiaskiekis = MaziausiasKiekis();
            maziausiaskiekis.Isvedimas();
            */
            Console.WriteLine("Didziausias prekiu kiekis: ");
            DidziausiasKiekis().Isvedimas();
            Console.WriteLine("Pigiausia preke: ");
            PigiausiaPreke().Isvedimas();
            Console.WriteLine("Brangiausia preke: ");
            BrangiausiaPreke().Isvedimas();
        }
        public void SuvestiPrekes()
        {
            Console.WriteLine("Kiek prekiu suvesti?");
            var kiekSuvesti = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiekSuvesti; i++)
            {
                Console.WriteLine("{0}-oji PREKE", i +1);
                Console.Write("Pavadinimas: ");
                var pavadinimas = Console.ReadLine();
                Console.Write("Kodas: ");
                var kodas = Console.ReadLine();
                Console.Write("Kaina: ");
                var kaina = Convert.ToDouble(Console.ReadLine());
                Console.Write("Savikaina: ");
                var savikaina = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kiekis: ");
                var kiekis = Convert.ToInt32(Console.ReadLine());

                var preke = new Preke(pavadinimas, kodas, kaina, savikaina, kiekis);
                Prekes.Add(preke);

            }
        }
        //parduotuves metodai:
        //visu prekiu kainu suma, savikainu suma, pajamos, pelnas, kurios prekes maziausiai, daugiausiai, pigiausia, brangiausia,
        //kainu suma
        public double KainuSuma()
        {
            var suma = 0.0;
            foreach (var preke in Prekes)
            {
                suma += preke.Kaina;
            }
            return suma;
        }
        // savikainu suma
        public double SavikainuSuma()
        {
            var suma = 0.0;
            foreach (var preke in Prekes)
            {
                suma += preke.Savikaina;
            }
            return suma;
        }
        // pajamos
        public double Pajamos()
        {
            var suma = 0.0;
            foreach (var preke in Prekes)
            {
                suma += preke.Kaina * preke.Kiekis;
            }
            return suma;
        }
        // pelnas
        public double BendrasPelnas()
        {
            var suma = 0.0;
            foreach (var preke in Prekes)
            {
                suma += preke.PelnasPardavusKieki();
                //suma += (preke.Kaina * preke.Kiekis) - (preke.Savikaina * preke.Kiekis);
            }
            return suma;
        }
        // maziausias kiekis
        public Preke MaziausiasKiekis()
        {
            var maziausias = Prekes[0];
            foreach (var preke in Prekes)
            {
                if (preke.Kiekis < maziausias.Kiekis)
                {
                    maziausias = preke;
                }
            }
            return maziausias;
        }
        // didziausias kiekis
        public Preke DidziausiasKiekis()
        {
            var didziausias = Prekes[0];
            foreach (var preke in Prekes)
            {
                if (preke.Kiekis > didziausias.Kiekis)
                {
                    didziausias = preke;
                }
            }
            return didziausias;
        }
        // pigiausia preke
        public Preke PigiausiaPreke()
        {
            var pigiausia = Prekes[0];
            foreach (var preke in Prekes)
            {
                if (preke.Kaina < pigiausia.Kaina)
                {
                    pigiausia = preke;
                }
            }
            return pigiausia;
        }
        // brangiausia preke
        public Preke BrangiausiaPreke()
        {
            var brangiausia = Prekes[0];
            foreach (var preke in Prekes)
            {
                if (preke.Kaina > brangiausia.Kaina)
                {
                    brangiausia = preke;
                }
            }
            return brangiausia;
        }
    }
}
