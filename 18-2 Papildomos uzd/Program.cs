using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2_Papildomos_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> atlyginimai = new List<double>();
            var programa = new Program();
            programa.Ivedimas(atlyginimai);
            programa.Isvedimas(atlyginimai);

            Console.WriteLine("Maziausia alga: " + programa.MaziausiaAlga(atlyginimai));
            Console.WriteLine("Didziausia alga: " + programa.DidziausiaAlga(atlyginimai));
            Console.WriteLine("Vidutine alga: " + programa.VidutineAlga(atlyginimai));
            Console.WriteLine("atlyginimu didesniu uz vidurki kiekis: " + programa.DaugiauUzVidurki(atlyginimai));
            Console.WriteLine("atlyginimu didesniu uz 1500 kiekis: " + programa.DaugiauUzX(atlyginimai, 1500));
            programa.TrysDidziausios(atlyginimai);
            Console.WriteLine("Penktas didziausias atlyginimas :" + programa.PenktaDidziausia(atlyginimai));
        }

        public void Ivedimas(List<double> atlyginimai)
        {
            /* 1 paklausti kiek atlyginimu norima suvesti
             * 2 sukti cikla nuo 0 iki nurodyto kiekio
             * 2-1 cikle isvesti "iveskite i-aji skaiciu"
             * 2-2 ivesti ir ikelti i sarasa skaiciu
             */
            Console.WriteLine("Kiek atlyginimu norite suvesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("iveskite {0}-aji skaiciu: ", i + 1);
                atlyginimai.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }
        public void Isvedimas(List<double> atlyginimai)
        {
            foreach (var atlyginimas in atlyginimai)
            {
                Console.Write("[{0}]", atlyginimas);
            }
            Console.WriteLine("");

        }
        public double MaziausiaAlga(List<double> atlyginimai)
        {
            //foreach (var atlyginimas in atlyginimai)
            //{
            //    if (MaziausiaAlga < atlyginimas)
            //    {

            //    }
            //    Console.Write("Maziausia alga", MaziausiaAlga);
            //}
            //Console.WriteLine("");
            return atlyginimai.Min();

        }

        public double DidziausiaAlga(List<double> atlyginimai)
        {
            return atlyginimai.Max();

        }

        public double VidutineAlga(List<double> atlyginimai)
        {
            return atlyginimai.Average();

        }

        // randame kiek algu yra daugiau uz vidurki:
        // du kintamieji - vidurkis, kiekiui saugoti (kiek kintamuju atitinka salyga)

        public int DaugiauUzVidurki(List<double> atlyginimai)
        {
            var vidurkis = atlyginimai.Average();
            var daugiauUzVidurki = 0;

            foreach (var atlyginimas in atlyginimai)
            {
                if (atlyginimas > vidurkis)
                {
                    daugiauUzVidurki++;
                }
            }

            return daugiauUzVidurki;
        }

        // rasti kiek algu yra daugiau uz 1500 eu

        public int DaugiauUzX(List<double> atlyginimai, double daugiauUz)
        {
            var kiekis = 0;
            
            foreach (var atlyginimas in atlyginimai)
            {
                if (atlyginimas > daugiauUz)
                {
                    kiekis++;
                }
            }

            return kiekis;
        }

        // rasti tris didziausias algas

        public void TrysDidziausios(List<double> atlyginimai)
        {
            double didziausias1 = DidziausiaAlga(atlyginimai);
            double didziausias2 = 0;
            double didziausias3 = 0;

            foreach (var atlyginimas in atlyginimai)
            {
                if (atlyginimas < didziausias1 && didziausias2 < atlyginimas)
                {
                    didziausias2 = atlyginimas;
                }
                if (atlyginimas < didziausias1 && atlyginimas < didziausias2 && didziausias3 < atlyginimas)
                {
                    atlyginimai.Sort();
                    atlyginimai.Reverse();
                    didziausias3 = atlyginimai[2];
                }
            }
            // foreach (var atlyginimas in atlyginimai)
            // {
            //if (didziausias2 < didziausias1 && didziausias2 < atlyginimas && didziausias1 != atlyginimas)
            //{
            // didziausias2 = atlyginimas;
            //}
            //if (didziausias3 < didziausias1 && didziausias3 < atlyginimas && didziausias1 != atlyginimas && didziausias2 != atlyginimas)
            //{
            //didziausias3 = atlyginimas;
            //}
            //}

            Console.WriteLine("Didziausias atlyginimas :" + didziausias1 + " eur");
            Console.WriteLine("Antras didziausias atlyginimas :" + didziausias2 + " eur");
            Console.WriteLine("Trecias didziausias atlyginimas :" + atlyginimai[2] + " eur");
        }
        // rasti penkta didziausias alga
        public double PenktaDidziausia(List<double> atlyginimai)
        {
            atlyginimai.Sort();
            atlyginimai.Reverse();
            return atlyginimai[4];
        }
    }
}
