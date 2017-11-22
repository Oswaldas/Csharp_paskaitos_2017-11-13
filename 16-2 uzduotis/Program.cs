using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = {4, 5, 6, 7, 7, 8, 8, 9, 9, 10 };
            /* geriausias pazimys;
             */
            
            var geriausias = pazymiai[0];
            foreach (var paz in pazymiai)
            {
                if (paz > geriausias)
                {
                    geriausias = paz;
                }
            }
            Console.WriteLine("geriausias pazimys: " + geriausias);

            /* kiek mokiniu gavo geriausia pazimi;
             */
            var geriausiu_kiekis = 0;
            foreach (var paz in pazymiai)
            {
                if (paz == geriausias)
                {
                    geriausiu_kiekis++;
                }
            }
            Console.WriteLine("geriausia pazymi gavusiu mokiniu skaicius: " + geriausiu_kiekis);

            /* kiek mokiniu gavo neigiama pazimi;
             */
            var neigiamu_kiekis = 0;
            foreach (var paz in pazymiai)
            {
                if (paz <= 4)
                {
                    neigiamu_kiekis++;
                }
            }
            Console.WriteLine("neigiama pazymi gavusiu mokiniu skaicius: " + neigiamu_kiekis);

            /* pazymiu vidurkis;
             */
            double suma = 0.0;

            foreach (var paz in pazymiai)
            {
                suma += paz;
            }
            var vidurkis = suma / pazymiai.Length;

            Console.WriteLine("pazymiu vidurkis: " + vidurkis);
            Console.ReadLine();
        }
        
    }
}
