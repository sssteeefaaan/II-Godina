using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentiIOcene
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] niz = new Student[4];
            niz[0] = new Student("Petra", "Petrović", 15000, 88.5f);
            niz[1] = new Student("Jovana", "Jovanović", 15200, 98.0f);
            niz[2] = new Student("Marko", "Marković", 15300, 50.5f);
            niz[3] = new Student("Đorđe", "Đorđević", 15400, 93.0f);

            Console.WriteLine("Originalni niz:");
            foreach (Student s in niz)
                Console.WriteLine(s.Indeks + " " + s.Ime + " " + s.Prezime + " " + s.Ocena);
            // Svaki pristup property-ju za čitanje kao u prethodnoj liniji se izvršava kroz poziv 
            // getter-a. 

            niz[2].Poeni = 56.0f; // Pristup property-ju za upis se izvršava kroz poziv setter-a. 

            Console.WriteLine("Posle izmene:");
            foreach (Student s in niz)
                Console.WriteLine(s.Indeks + " " + s.Ime + " " + s.Prezime + " " + s.Ocena);
        }
    }
}
