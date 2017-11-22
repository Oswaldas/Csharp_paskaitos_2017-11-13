using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> primilziai = new List<double>();
            // kviesti metodus CIA
            var programa = new Program();
            programa.Ivedimas(primilziai);
            programa.Isvedimas(primilziai);
            Console.WriteLine();
            Console.WriteLine("Maziausias: " + programa.Maziausias(primilziai) + " l.");
            Console.WriteLine("Didziausias: " + programa.Didziausias(primilziai) + " l.");
            Console.WriteLine("Vidutinis: " + programa.Vidutinis(primilziai) + " l.");
            programa.DuDidziausi(primilziai);
        }

        // ivedimo metodas
        public void Ivedimas(List<double> primilziai)
        {
            Console.WriteLine("iveskite primilziu kieki: ");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("iveskite {0} galvijo dienos primilzi litrais: ", i + 1);
                primilziai.Add(Convert.ToDouble(Console.ReadLine()));
            }

        }
        // isvedimo metodas
        public void Isvedimas(List<double> primilziai)
        {
            foreach (var primilzis in primilziai)
            {
                Console.WriteLine(primilzis + " l");
            }

        }

        // min, max, acerage, metodai
        public double Maziausias(List<double> primilziai)

        {
            return primilziai.Min();
        }
        public double Didziausias(List<double> primilziai)

        {
            return primilziai.Max();
        }
        public double Vidutinis(List<double> primilziai)

        {
            return primilziai.Average();
        }

        public void DuDidziausi(List<double> primilziai)
        {
            var didziausias1 = Didziausias(primilziai);
            var didziausias2 = Maziausias(primilziai);

            foreach (var primilzis in primilziai)
            {
                if (didziausias2 < didziausias1 && didziausias2 < primilzis && didziausias1 != primilzis)
                {
                    didziausias2 = primilzis;
                }
            }
            
            Console.WriteLine("Didziausias primilzis :" + didziausias1 + " l.");
            Console.WriteLine("Antras didziausias primilzis :" + didziausias2 + " l.");
           
        }
    }
}
