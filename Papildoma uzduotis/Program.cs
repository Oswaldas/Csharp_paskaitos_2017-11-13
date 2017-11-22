using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papildoma_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // susikurti zodziu sarasa rasti ilgiausia zodi, (string yra char masyvas, tai ant to zodzio galime naudoti ZODIS.length)
            // rasti trumpiausia zodi
            //trumpiasia ir ilgiausia zodzius isvesti i ekrana nurodant kiek raidziu kiekviena is ju sudaro

            List<string> zodziai = new List<string>
            {
                "medis",
                "upe",
                "pasikiskiakopusteliaudamas",
                "dramblys",
                "zuikis",
            };
            var trumpiausias = zodziai[0];
            var ilgiausias = zodziai[0];
            foreach (var zodis in zodziai)
            {
                if (zodis.Length < trumpiausias.Length)
                {
                    trumpiausias = zodis;
                }
                if (zodis.Length > ilgiausias.Length)
                {
                    ilgiausias = zodis;
                }
                Console.WriteLine("trumpiausias zodis: " + trumpiausias, + trumpiausias.Length);
                Console.WriteLine("ilgiausias zodis: " + ilgiausias);
                
            }
        }
    }
}