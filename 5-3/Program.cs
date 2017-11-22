using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite temperatura)");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
                Console.WriteLine("žiauriai šalta");
            else if (a < 10)
                Console.WriteLine("labai šalta");
            else if (a < 20)
                Console.WriteLine("šalta");
            else if (a < 30)
                Console.WriteLine("normali temperatūra");
            else if (a < 40)
                Console.WriteLine("karšta");
            else if (a > 40)
                Console.WriteLine("visiškai degina");
            Console.ReadLine();
        }
       
    }
}
