using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Pavyzdziai
{
    class Medikas:Darbuotojas
    {
        public double Kysis { get; private set; }
        public double Alga2 { get; private set; }
        public double Etatas2 { get; private set; }

        public Medikas(string vardas, string pavarde, int amzius, double alga, double etatas, double kysis, double alga2, double etatas2)
            : base(vardas, pavarde, amzius, alga, etatas)
        {
            Kysis = kysis;
            Alga2 = alga2;
            Etatas2 = etatas2;
        }

        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Gauna kysio {0}, be to dirba papildomai {2} etato ir gauna {1} algos", Kysis, Etatas2, Alga2);
            Console.WriteLine();
        }
    }
}
