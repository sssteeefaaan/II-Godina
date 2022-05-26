using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ObicniReturn: ");
            Console.WriteLine(ObicniReturn());
            Console.WriteLine(ObicniReturn());
            Console.WriteLine(ObicniReturn());

            Console.WriteLine("YieldReturn: ");
            foreach (int i in YieldReturn())
            {
                Console.WriteLine(i);
            }
        }

        static int ObicniReturn()
        {
            return 1;
            // sve linije koda ispod ove su "unreachable" i nikada neće biti izvršene
            return 2;
            return 3;
        }

        static IEnumerable<int> YieldReturn()
        {
            // početna tačka izvršenja prve iteracije
            yield return 1; // izlazak iz metode posle prve iteracije

            // početna tačka izvršenja druge iteracije
            yield return 2; // izlazak iz metode posle druge iteracije

            // početna tačka izvršenja treće iteracije
            yield return 3; // izlazak iz metode posle treće iteracije, tj konačan izlazak iz metode
        }
    }
}
