using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTipovi
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            //Console.WriteLine(a.Value); // ovo bi generisalo izuzetak
            
            // Pravilan način za rad sa nullable tipovima
            if (a.HasValue)
                Console.WriteLine("a = " + a.Value);
            else
                Console.WriteLine("Vrednost a je null");

            a = 5;
            if (a.HasValue)
                Console.WriteLine("a = " + a.Value);
            else
                Console.WriteLine("Vrednost a je null");

            a += 6;
            if (a.HasValue)
                Console.WriteLine("a = " + a.Value);
            else
                Console.WriteLine("Vrednost a je null");

            // Dodela vrednosti iz nullable tipa "običnom" tipu
            int b;
            // 1.Kompajler prijavljuje grešku
            //b = a; 

            // 2.Radi, ali ako nullable promenljivoj nije dodeljena vrednost dolazi do izuzetka
            b = (int)a;
            Console.WriteLine("b = " + b);

            // 3.Ispravan način
            if (a.HasValue)
            {
                int c = a.Value;
                Console.WriteLine("c = " + c);
            }
        }
    }
}
