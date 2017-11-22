using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var rezultatas = "";
            var ivedimas = "";

            while (ivedimas != "exit") // kol neivede exit
            {
                Console.WriteLine("iveskite zodi: arba exit");
                ivedimas = Console.ReadLine();
                if (ivedimas != "exit")
                {
                    rezultatas += ivedimas + " ";
                }
                Console.WriteLine(rezultatas);
            }
            
        } 
                            
    }
}
