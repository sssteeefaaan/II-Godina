using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultet
{
    public class Kolekcija
    {
        protected int maxBroj, trenutniBroj;
        protected Student[] niz;

        public Kolekcija(int maxBroj)
        {
            this.maxBroj = maxBroj;
            this.trenutniBroj = 0;
            niz = new Student[maxBroj];
        }

        public void Dodaj(Student s)
        {
            if (trenutniBroj < maxBroj)
            {
                this.niz[trenutniBroj] = s;
                trenutniBroj++;
            }
            else
            {
                throw new Exception("Kolekcija je puna!");
            }
        }

        public void Stampa()
        {
            for (int i = 0; i < trenutniBroj; i++)
                Console.WriteLine(niz[i]);
        }
    }
}
