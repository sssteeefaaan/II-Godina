using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proizvodi
{
    class Korpa : INaplata
    {
        private string valuta;
        private float limit;
        private List<Proizvod> proizvodi;

        public string Valuta
        {
            get { return valuta; }
        }

        public float Cena
        {
            get 
            {
                float toReturn = 0;
                foreach (Proizvod p in proizvodi)
                    toReturn += p.Cena;
                return toReturn;
            }
        }

        public float Limit
        {
            get { return limit; }
        }

        public void DodajProizvod(Proizvod p)
        {
            if (this.Cena + p.Cena <= limit)
                proizvodi.Add(p);
            else
                throw new Exception("Out of money!");
        }

        public void Upis(string fajl)
        {
            using (StreamWriter sw = new StreamWriter(fajl))
            {
                sw.WriteLine(valuta);
                sw.WriteLine(limit);
                sw.WriteLine(proizvodi.Count);
                foreach (Proizvod p in proizvodi)
                    p.Upis(sw);
            }
        }

        public void Citanje(string fajl)
        {
            using (StreamReader sr = new StreamReader(fajl))
            {
                valuta = sr.ReadLine();
                limit = int.Parse(sr.ReadLine());
                int broj = int.Parse(sr.ReadLine());
                proizvodi = new List<Proizvod>(broj);
                for (int i = 0; i < broj; i++)
                {
                    Proizvod p = new ProizvodNaMerenje();
                    p.Citanje(sr);
                    DodajProizvod(p);
                }
            }
        }

        public void Izbaci(Status statusZaIzbacivanje)
        {
            for (int i = 0; i < proizvodi.Count; i++)
            {
                if (proizvodi[i].Status == statusZaIzbacivanje)
                {
                    proizvodi.RemoveAt(i);
                    i--;
                }
            }

        }

    }
}
