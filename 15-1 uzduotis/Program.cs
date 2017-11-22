using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = { 7, 8, 3, 9, 10 };
            // string[] markes = { "audi", "bmw", "jaguar", "nissan", "porshe" "volvo" };

            string[] markes = new string[3];
            markes[0] = "audi";
            markes[1] = "bmw";
            markes[2] = "volkswagen";

            char[] abecele = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            Console.WriteLine("masyvu dydziai");
            Console.WriteLine("pazymiai:" + pazymiai.Length);
            
            Console.WriteLine("pazymiu masyvo");
            Console.WriteLine("pirma reiksme: " + pazymiai.First());
            Console.WriteLine("paskutine reiksme: " + pazymiai.Last());

            Console.WriteLine("markes:" + markes.Length);
            Console.WriteLine("markiu masyvo");
            Console.WriteLine("pirma reiksme: " + pazymiai.First());
            Console.WriteLine("paskutine reiksme: " + pazymiai.Last());

            Console.WriteLine("abecele:" + abecele.Length);
            Console.WriteLine("abeceles masyvo");
            Console.WriteLine("pirma reiksme: " + pazymiai.First());
            Console.WriteLine("paskutine reiksme: " + pazymiai.Last());

            // naujas pvz 

            Console.WriteLine(" ");

            var skaiciai = new int[5];
                Console.WriteLine("Iveskite penkis skaicius");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 +": ");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.ReadLine();
        }
        
    }
}
