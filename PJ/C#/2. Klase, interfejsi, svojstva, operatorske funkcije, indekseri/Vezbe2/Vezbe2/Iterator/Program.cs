using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
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

            v1.DodajElement(i);
            v1.DodajElement(f);
            v1.DodajElement(d);
            v1.DodajElement(s);

            v1.StampajTrenutni();
            if (v1.ImaJos())
                Console.WriteLine("Ima još elemenata.");
            else
                Console.WriteLine("Nema više elemenata!");

            v1.NaPocetak();
            while (v1.ImaJos())
            {
                v1.StampajTrenutni();
                v1.Sledeci();
            }
        }
    }
}
