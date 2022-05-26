using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[100];
            for (int i = 0; i < 100; i++)
            {
                // Ako radimo sa klasama imamo 100 dodatnih poziva operatora new
                // Kod struktura bi samo bilo potrebno da odradimo dodelu vrednosti
                points[i] = new Point(i, i);
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("(" + points[i].x + ", " + points[i].y + ")");
            } 
        }
    }
}
