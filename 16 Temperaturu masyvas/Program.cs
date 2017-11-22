using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Temperaturu_masyvas
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturos = { -30, 14.5, 18.5, 20.4};

            /* zemiausia tem;
             */

            var zemiausia = temperaturos[0];
            foreach (var temperatura in temperaturos)
            {
                if (temperatura < zemiausia)
                {
                    zemiausia = temperatura;
                }
            }
            Console.WriteLine("zemiausia temperatura: " + zemiausia);

            /* didziausia temp;
             */

            var auksciausia = temperaturos[0];
            foreach (var temperatura in temperaturos)
            {
                if (temperatura > auksciausia)
                {
                   auksciausia = temperatura;
                }
            }
            Console.WriteLine("auksciausia temperatura: " + auksciausia);

            /* vidurkis temp;
             */
            double suma = 0.0;
            
            foreach (var temperatura in temperaturos)
            {
                suma += temperatura;
            }
            var vidurkis = suma / temperaturos.Length;

            Console.WriteLine("temperatur vidurkis: " + vidurkis);

            /* temp maziau uz vidurki kiekis;
             */

            var zemesniu_kiekis = 0;
            foreach (var temperatura in temperaturos)
            {
                if (temperatura < vidurkis)
                {
                    zemesniu_kiekis++;
                }
            }
            Console.WriteLine("zemesniu uz vidurki temperaturu kiekis: " + zemesniu_kiekis);

            /*temp daugiau uz vidurki kiekis;
            */

           var aukstesniu_kiekis = 0;
            foreach (var temperatura in temperaturos)
            {
                if (temperatura > vidurkis)
                {
                    aukstesniu_kiekis++;
                }
            }
            Console.WriteLine("aukstesniu uz vidurki temperaturu kiekis: " + aukstesniu_kiekis);
        }
    }
}
