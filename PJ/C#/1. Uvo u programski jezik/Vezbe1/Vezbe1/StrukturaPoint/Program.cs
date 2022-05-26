using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturaPoint
{
    class Program
    {
        static void Main(string[] args)
        {
     		Point[] points = new Point[100];
            // Ako radimo sa strukturama kreiranje objekata u petlji nije potrebno
            // i možemo samo da odradimo dodelu vrednosti postojećim objektima
            // dovoljno je 
            for (int i = 0; i < 100; i++) 
            { 
                points[i].x = i; 
                points[i].y = i; 
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("(" + points[i].x + ", " + points[i].y + ")");
            } 
        }
    }
}
