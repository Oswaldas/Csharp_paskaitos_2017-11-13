using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pazymiai = new List<int>();
            var rnd = new Random();
            Console.WriteLine("kiek studentu pazymiu norite suvesti i sarasa?");
            var kiek = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("iveskite skaiciu: ");
                pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("maziausias skaicius: " + pazymiai.Min());
            Console.WriteLine("didziausias skaicius: " + pazymiai.Max());
            Console.WriteLine("vidurkis: " + pazymiai.Average());
            Console.WriteLine("atsitiktinis skaicius is gautu pazymiu: " + pazymiai[rnd.Next(pazymiai.Count)]);
        }
    }
}
