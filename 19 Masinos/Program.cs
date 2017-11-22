using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Masinos
{
    class Program
    {
        static void Main(string[] args)
        {
            var automobilis = new Automobilis("Audi", "A4", 2015, 3.0, 248, 15000);
            automobilis.Isvedimas();

            var automobiliai = new List<Automobilis>
            {
                new Automobilis("Chevrolet", "Corvette Z06", 2013, 6.2, 340, 20000),
                new Automobilis("Maserati", "Gran Turismo S", 2010, 4.7, 328, 35000),
                new Automobilis("Lamborghini", "Huracan", 2014, 5.2, 455, 10000),
                new Automobilis("Ford", "GT", 2016, 3.5, 489, 25000),
            };

            var programa = new Program();
            programa.Isvedimas(automobiliai);
            Console.WriteLine();
            var naujausias = programa.NaujausiasAuto(automobiliai);
            Console.WriteLine("Naujausias auto:");
            naujausias.Isvedimas();
            Console.WriteLine();
            var seniausias = programa.SeniausiasAuto(automobiliai);
            Console.WriteLine("Seniausias auto:");
            seniausias.Isvedimas();
            Console.WriteLine();
            var galingiausias = programa.GalingiausiasAuto(automobiliai);
            Console.WriteLine("Galingiausias auto:");
            galingiausias.Isvedimas();
            Console.WriteLine();
            var maziausiaRida = programa.MaziausiaRidaAuto(automobiliai);
            Console.WriteLine("Maziausiai nuvaziaves auto:");
            maziausiaRida.Isvedimas();

        } // main metodo pabaiga

        // visa automobiliu sarasa isvesti i ekrana
        public void Isvedimas(List<Automobilis> automobiliai)
        {
            foreach (var auto in automobiliai)
            {
                auto.Isvedimas();
            }
        }

        // naujausias automobilis
        public Automobilis NaujausiasAuto(List<Automobilis> automobiliai)
        {
            /* 1. laikinas objektas, lygus pirmam nariui is saraso, cia bus atsakymas ir su situ objektu viska lyginsim
             * 2. eina per automobiliu sarasa
             * 2. 1. tikrinam ar dabartinis auto.metai yra naujesnis nei laikino objekto.metai
             * 2. 1. 1. prisiskiriam nauja reiksme jei taip
             * 3. grazinam gauta atsakyma
             */

            var laikinas = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (auto.Metai > laikinas.Metai)
                {
                    laikinas = auto;
                }
            }

            return laikinas;
        }

        // rasyti metodus:
        //  seniausias automobilis
        public Automobilis SeniausiasAuto(List<Automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (auto.Metai < laikinas.Metai)
                {
                    laikinas = auto;
                }
            }

            return laikinas;
        }
        //  didziausios galios automobilis
        public Automobilis GalingiausiasAuto(List<Automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (auto.Galia > laikinas.Galia)
                {
                    laikinas = auto;
                }
            }

            return laikinas;
        }
        //  kuris automobilis nuvaziaves maziausiai
        public Automobilis MaziausiaRidaAuto(List<Automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (auto.Rida < laikinas.Rida)
                {
                    laikinas = auto;
                }
            }

            return laikinas;
        }
    } // class Program pabaiga
}
