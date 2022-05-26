using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoriscenjeDelegata
{
    class Program
    {
        // deklaracija delegata
        public delegate void StampajString(string s);

        public static void StampajNaKonzolu(string str)
        {
            Console.WriteLine("Vrednost stringa je: {0}", str);
        }

        public static void StampajUFajl(string str)
        {
            using (StreamWriter sw = new StreamWriter("message.txt", true))
                sw.WriteLine("Vrednost stringa je: {0}", str);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            // jedna instanca delegata
            StampajString instancaDelegata = new StampajString(StampajNaKonzolu);
            // dodavanje druge instance delegata
            instancaDelegata += new StampajString(StampajUFajl);
            // pozivaju se obe instance delegata
            instancaDelegata("Zdravo!");
            Console.ReadKey();
        }
    }
}
