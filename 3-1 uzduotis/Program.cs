using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4;
            var b = 5;
            var suma = a + b;
            var skirtumas = a - b;
            var daugyba = a * b;
            var dalyba = a / b;
            Console.WriteLine("{0} + {1} = {2}", a, b, suma);
            Console.WriteLine("{0} - {1} = {2}", a, b, skirtumas);
            Console.WriteLine("{0} * {1} = {2}", a, b, daugyba);
            Console.WriteLine("{0} / {1} = {2}", a, b, dalyba);
            Console.ReadLine();

            // 2 budas

            var c = 9;
            var d = 7;
            Console.WriteLine("{0} + {1} = {2}", c, d, c + d);
            Console.WriteLine("{0} - {1} = {2}", c, d, c - d);
            Console.WriteLine("{0} * {1} = {2}", c, d, c * d);
            Console.WriteLine("{0} / {1} = {2}", c, d, c / d);
            Console.ReadLine();

        }
    }
}
