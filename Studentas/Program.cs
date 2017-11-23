using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentas
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentas = new Studentas("Haris", "Poteris", "Floperis ryzas", 113, 
            new List<int>
            {
                7,8,9,6,4
            }, 
            new List<int>
            {
                7,10,9,7,5
            }, 
            new List<int>
            {
                7,9,9,5,8
            });

            studentas.Isvedimas();
        }
    }
}
