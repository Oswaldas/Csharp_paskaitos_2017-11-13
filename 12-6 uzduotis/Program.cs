using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var slaptas = rnd.Next(1,50); // [1 - 50)
            var spejimas = 0;
            var atsitiktinisskaicius = Convert.ToInt32(Console.ReadLine());

            while (spejimas != slaptas)
            {
                Console.WriteLine("Atspekite skaiciu nuo 0 iki 50: ");
                spejimas = Convert.ToInt32(Console.ReadLine());

                if (slaptas > spejimas)
                {
                    
                    Console.WriteLine("slaptas skaicius yra didesnis");
                }
                else if (slaptas < spejimas)
                {
                    Console.WriteLine("slaptas skaicius yra mazesnis");
                }
                else
                {
                    Console.WriteLine("sveikinu, jus atspejote");
                }
                
            }
            Console.ReadLine();
        }
    }
}
