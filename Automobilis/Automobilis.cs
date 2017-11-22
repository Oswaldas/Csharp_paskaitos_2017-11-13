using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_pvz
{
    class Automobilis
    {
        public string Marke { get; private set; }
        public string Modelis { get; private set; }
        public int Metai { get; private set; }
        public double DarbinisTuris { get; private set; }
        public int Galia { get; private set; }
        public int Rida { get; private set; }

        public Automobilis(string marke, string modelis, int metai, double darbinisturis, int galia, int rida)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            DarbinisTuris = darbinisturis;
            Galia = galia;
            Rida = rida;
        }
        // isvedimo metodas

            
        public void Isvedimas()
        {
            Console.WriteLine("Masina {0}{1}({2} m.). {3}, {4} kw, nuvaziaves {5}", Marke, Modelis, Metai, DarbinisTuris, Galia, Rida);
            Console.WriteLine();
        }

        
    }
}
