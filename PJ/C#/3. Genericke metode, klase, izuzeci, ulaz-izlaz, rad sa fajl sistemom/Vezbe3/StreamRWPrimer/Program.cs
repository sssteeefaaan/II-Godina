using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamRWPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] imena = new string[] { "Petar Petrović", "Jovana Jovanović" };
            int[] brojevi = new int[] { 1, 2, 3 };
            using (StreamWriter sw = new StreamWriter("imena.txt"))
            {
                //foreach (string s in imena)
                foreach (int s in brojevi)
                {
                    sw.WriteLine(s);
                }
            }

            // Čitanje iz fajla linija po linija.
            string linija = "";
            using (StreamReader sr = new StreamReader("imena.txt"))
            {
                while ((linija = sr.ReadLine()) != null)
                {
                    int i; // = Int32.Parse(linija); // može da baci izuzetak ako parsiranje nije moguće
                    if (int.TryParse(linija, out i))  // bezbedni način za parsiranje
                        Console.WriteLine(i);  
                }
            }
        }
    }
}
