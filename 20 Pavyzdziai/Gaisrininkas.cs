using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Pavyzdziai
{
    class Gaisrininkas: Darbuotojas
    {
        public double Kysis { get; private set; }
        public int UzgesinoGaisru { get; private set; }

        public Gaisrininkas(string vardas, string pavarde, int amzius, double alga, double etatas, double kysis, int uzgesinoGaisru)
            : base(vardas, pavarde, amzius, alga, etatas)
        {
            Kysis = kysis;
            UzgesinoGaisru = uzgesinoGaisru;
        }

        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Gauna kysio {0} ir siemet uzgesino {1} gaisru ", Kysis, UzgesinoGaisru);
            Console.WriteLine();
        }
    }
}
