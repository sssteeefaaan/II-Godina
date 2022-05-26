using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            IIterator v1 = new VektorIterator(4);
            int i = 10;
            float f = 20.2f;
            double d = 30.33;
            String s = "blabla";

            v1.NoviElement = i;
            v1.NoviElement = f;
            v1.NoviElement = d;
            v1.NoviElement = s;

            Console.WriteLine(v1.TrenutniElement);
            if (v1.ImaJos)
                Console.WriteLine("Ima još elemenata.");
            else
                Console.WriteLine("Nema više elemenata!");

            v1.NaPocetak();
            while (v1.ImaJos)
            {
                Console.WriteLine(v1.TrenutniElement);
                v1.Sledeci();
            }
        }
    }
}
