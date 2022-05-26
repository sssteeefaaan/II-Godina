using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligoni
{
    class Program
    {
        static void Main(string[] args)
        {
            Poligon kvadrat = new Poligon(4, 2.0);

            //Tacka t = new Tacka();
            //t.X = -1;
            //t.Y = 0;
            //kvadrat[2] = t;

            for (int i = 0; i < 4; i++)
                Console.WriteLine(kvadrat[i]);
        }
    }
}
