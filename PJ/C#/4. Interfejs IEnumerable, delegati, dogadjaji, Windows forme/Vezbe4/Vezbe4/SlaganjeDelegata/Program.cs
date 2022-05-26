using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlaganjeDelegata
{
    delegate void DelegatStampa(string s);

    class Program
    {
        public static void Zdravo(string s)
        {
            Console.WriteLine("  Zdravo, {0}!", s);
        }

        public static void Dovidjenja(string s)
        {
            Console.WriteLine("  Doviđenja, {0}!", s);
        }

        public static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            DelegatStampa a, b, c, d;

            // Kreiranje delegata koji referencira metodu Zdravo
            a = new DelegatStampa(Zdravo);
            // Kreiranje delegata koji referencira metodu Dovidjenja
            b = new DelegatStampa(Dovidjenja);
            // Kreiranje delgata koji predstavlja "zbir" prethodna dva
            c = new DelegatStampa(Zdravo) + new DelegatStampa(Dovidjenja);
            // Uklanjanje jednog od delegata iz "zbira"
            d = c - a;

            Console.WriteLine("Poziv delegata a:");
            a("A");
            Console.WriteLine("Poziv delegata b:");
            b("B");
            Console.WriteLine("Poziv delegata c:");
            c("C");
            Console.WriteLine("Poziv delegata d:");
            d("D");
        }
    }
}
