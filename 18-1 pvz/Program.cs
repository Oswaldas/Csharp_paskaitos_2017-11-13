using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_1_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Pasisveikinti();
            programa.Pasisveikinti("Osvaldas");
            programa.Pasisveikinti("Osvaldas", "Brazas");
            programa.Atsisveikinti();
            programa.Atsisveikinti("Osvaldas");
            programa.Atsisveikinti("Osvaldas", "Brazas");
            StatinisMetodas();

            var sumos_ats = programa.Suma(4,5);
            Console.WriteLine(sumos_ats);

            Console.WriteLine(programa.Suma(7, 5));
            Console.WriteLine(programa.Skirtumas(7, 5));
            Console.WriteLine(programa.Daugyba(7, 5));
            Console.WriteLine(programa.Dalyba(7, 5));

            Console.WriteLine("Iveskite du skaicius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            var suma = programa.Suma(pirmas, antras);
            var skirtumas = programa.Skirtumas(pirmas, antras);
            var daugyba = programa.Daugyba(pirmas, antras);
            var dalyba = programa.Dalyba(pirmas, antras);

            Console.WriteLine("{0}+{1}={2}", pirmas, antras, suma);
            Console.WriteLine("{0}-{1}={2}", pirmas, antras, skirtumas);
            Console.WriteLine("{0}*{1}={2}", pirmas, antras, daugyba);
            Console.WriteLine("{0}/{1}={2}", pirmas, antras, dalyba);

            // Paprasyti vartotojo ivesti dvi staciakampio krastines, parasyti metodus: 
            // suskaiciuoti plota; suskaiciuoti perimetra; ats isvesti

            Console.WriteLine("Iveskite dvi staciakampio krastines: ");
            var pirma = Convert.ToInt32(Console.ReadLine());
            var antra = Convert.ToInt32(Console.ReadLine());

            var plotas = programa.Daugyba(pirma, antra);
            var perimetras = programa.Perimetras(pirma, antra);

            Console.WriteLine("{0}*{1}={2}", pirma, antra, plotas);
            Console.WriteLine("perimetras", pirma, antra, perimetras);
        }

        // rasysim cia
        /* 
         * pasiekiamumas tipas pavadinimas(parametrai)
         * {
         * kodas
         * }
         * */
        public void Pasisveikinti()
        {
            Console.WriteLine("Labas Krabas");
        }

        public void Pasisveikinti(string vardas)
        {
            Console.WriteLine("Labas," + vardas);
        }
        public void Pasisveikinti(string vardas, string pavarde)
        {
            Console.WriteLine("Labas," + vardas + " " + pavarde);
        }
        /* 
         *atsisveikinimas
         * */
        public void Atsisveikinti()
        {
            Console.WriteLine("Ate ate,");
        }
        public void Atsisveikinti(string vardas)
        {
            Console.WriteLine("Lik sveikas," + vardas);
        }
        public void Atsisveikinti(string vardas, string pavarde)
        {
            Console.WriteLine("Viso geriausio," + vardas + " " + pavarde);
        }
        /* 
         *statinis metodas
         * */
        public static void StatinisMetodas()
        {
        Console.WriteLine("statinis metodas");
        }
        /* 
         *statinis metodas
         * */
        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Skirtumas(int a, int b)
        {
            return a - b;
        }

        public int Daugyba(int a, int b)
        {
            return a * b;
        }

        public double Dalyba(int a, int b)
        {
            return (double)a % b;
        }

        public int Perimetras(int a, int b)
        {
            return (a+b)*2;
        }
    } // class Program skliausto pabaiga
}
