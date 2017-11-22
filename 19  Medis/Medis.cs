using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19__Medis
{
    class Medis
    {
        public string Rusis { get; private set; }
        public int Amzius { get; private set; }
        public int Aukstis { get; private set; }
       

        public Medis(string rusis, int amzius, int aukstis)
        {
            Rusis = rusis;
            Amzius = amzius;
            Aukstis = aukstis;
        }

        // isvedimo metodas

        public void Isvedimas()
        {
            Console.WriteLine("Medis {0}, kuriam yra {1} m. isaugo iki {2} m. aukscio.", Rusis, Amzius, Aukstis);
            Console.WriteLine();
        }

        public double Centimetrai()
        {
            var aukstis = Aukstis * 100;
            return aukstis;
        }

        public double Dienos()
        {
            var amziusdienomis = Amzius * 365;
            return amziusdienomis;
        }
    }
}
