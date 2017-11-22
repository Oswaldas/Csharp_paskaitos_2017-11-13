using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19__Medis
{
    class Program
    {
        static void Main(string[] args)
        {
            var medis = new Medis("Azuolas", 30, 6);
            medis.Isvedimas();

            var programa = new Program();
            Console.WriteLine("Medzio aukstis: " + medis.Centimetrai() + " cm.");
            Console.WriteLine("Medzio amzius dienomis yra apytiksliai: " + medis.Dienos() + " d.");

        } // main metodo pabaiga
    }
}
