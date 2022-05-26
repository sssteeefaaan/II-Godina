using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompleksniBrojeviIOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 5.5f;
            KompleksniBroj k1 = a;
            Console.WriteLine("Float " + a + " konvertovan u kompleksni broj " + k1);
            Console.WriteLine();

            KompleksniBroj k2 = new KompleksniBroj(3.8f, 9.5f);
            float b = (float)k2;
            Console.WriteLine("Kompleksni broj " + k2 + " konvertovan u float " + b);
            Console.WriteLine();

            Console.WriteLine("Kompleksni broj " + k1 
                + " preinkrementiran u naredbi za štampu " + ++k1);
            Console.WriteLine();

            Console.WriteLine("Kompleksni broj " + k2
                + " postinkrementiran u naredbi za štampu " + k2++);
            Console.WriteLine("Naredna provera istog kompleksnog broja " + k2);
            Console.WriteLine();

            Console.WriteLine("Zbir kompleksnih brojeva " + k1 + " i " + k2 
                + " je " + (k1 + k2));
            Console.WriteLine();

            Console.WriteLine("Rezultat poređenja " + k1 + " == " + k2
                + " je " + (k1 == k2));
            Console.WriteLine();

            Console.WriteLine("Rezultat poređenja " + k1 + " < " + k2
                + " je " + (k1 < k2));
            Console.WriteLine();

            Console.WriteLine("Rezultat poređenja " + k1 + " >= " + k2
                + " je " + (k1 >= k2));
            Console.WriteLine();
        }
    }
}
