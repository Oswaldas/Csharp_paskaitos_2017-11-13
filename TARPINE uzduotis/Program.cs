using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARPINE_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek darbuotojas gali iškepti kepalų per valandą");
            var kepal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek darbuotojų turi kepykla ");
            var darb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vieno kepalo savikaina ");
            var savkainas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vieno kepalo pardavimo kaina ");
            var parkainas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kiek kepykla turi tą dieną užsakymų ");
            var uzsk = Convert.ToInt32(Console.ReadLine());

            //Suskaičiuoti kiek kepykla per vieną darbo dieną spės iškepti duonos kepalų.
            var perdiena = 8 * kepal * darb;
            Console.WriteLine("kepykla per vieną darbo dieną spės iškepti duonos kepalų " + perdiena);

            //Apskaičiuoti visų kepalų savikainą, gautas pajamas pardavus ir iš to gauto pelno dalį.
            var savikaina = perdiena * savkainas;
            var pajamos = perdiena * parkainas;
            var pelnas = pajamos - savikaina;
            Console.WriteLine("Pelnas " + pelnas);

            //Patikrinti ar kepykla spės iškepti visus tos dienos užsakymus. 
            //Jei ne, suskaičiuoti kiek kepalų nespės iškepti.
            if (perdiena >= uzsk)
            {
                Console.WriteLine("Uzsakymas bus atliktas ");
            }
            else
            {
                Console.WriteLine("Uzsakymas bus neatliktas, truks " + (uzsk - perdiena));
            }

        }
    }
}
