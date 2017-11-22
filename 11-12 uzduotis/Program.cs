using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite fibonaci skaiciu");
            var f = Convert.ToInt32(Console.ReadLine());
            var a = 0;
            var b = 1;
            var c = 0;
       //     var sum = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
                       
            for (int i = 2; i < f; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
           //     sum += c;

            }
            Console.WriteLine(".........");
            Console.ReadLine();
        }
    }
}
