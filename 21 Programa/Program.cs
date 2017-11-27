using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            public static String GetRandomString()
            {
                var allowedChars = "ABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
                var length = 30;

                var chars = new char[length];
                var rd = new Random();

                for (var i = 0; i < length; i++)
                {
                    chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
                }

                return new String(chars);
            }
        }
    }
}
