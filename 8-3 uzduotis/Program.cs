using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite triju egzaminu rezultatus (0-10)");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (double)(a + b + c) / 3;
            if (vidurkis >= 8 && vidurkis <= 10)
            {
                Console.WriteLine("jus surinkote 8 arba daugiau" +vidurkis);
            }
           else if (vidurkis < 8 && vidurkis >= 5)
            {
                Console.WriteLine("jus daugiau negu 5, bet maziau negu 8 " +vidurkis);
            }
            else if (vidurkis < 5)
            {
                Console.WriteLine("surinkote neigiama bala < 5 " +vidurkis);
            }
            else
            {
                Console.WriteLine("nepatenka i rezius");
            }
            Console.ReadLine();
        }
    }
}
