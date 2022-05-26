using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Biblioteka
    {
        private Dictionary<Autor, List<Knjiga>> katalog;

        public Biblioteka()
        {
            katalog = new Dictionary<Autor, List<Knjiga>>();
        }

        public void DodajKnjigu(Knjiga knjiga)
        {
            foreach (Autor a in knjiga.Autori)
            {
                List<Knjiga> knjigeAutora;
                if (!katalog.TryGetValue(a, out knjigeAutora))
                {
                    knjigeAutora = new List<Knjiga>();
                    katalog.Add(a, knjigeAutora);
                }
                knjigeAutora.Add(knjiga);
            }
        }

        public List<Knjiga> PronadjiKnjigeAutora(Autor a)
        {
            List<Knjiga> rezultat;
            if (!katalog.TryGetValue(a, out rezultat))
            {
                Console.WriteLine("U biblioteci ne postoji nijedna knjiga autora: " + a);
                return new List<Knjiga>();
            }
            return rezultat;
        }
    }
}
