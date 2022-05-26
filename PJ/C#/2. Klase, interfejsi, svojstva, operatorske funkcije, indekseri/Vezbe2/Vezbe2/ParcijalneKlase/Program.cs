using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcijalneKlase
{
    class Program
    {
        static void Main(string[] args)
        {
            Proizvod p1 = new Proizvod(1111, "Bela čokolada", 121, 100);
            Proizvod p2 = new Proizvod(2222, "Crna čokolada", 133, 100);

            p1.Stampaj();
            Console.WriteLine();
            p2.Stampaj();
            Console.WriteLine();
        }
    }
}
