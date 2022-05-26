using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utakmice
{
    class Turnir : IFairPlay
    {
        int maxIskljucenja;
        List<Utakmica> utakmice;

        public Turnir()
        {
            utakmice = new List<Utakmica>();
        }

        public int MaxIskljucenja
        {
            get { return maxIskljucenja; }
        }

        public void Upis(String path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(maxIskljucenja);
                sw.WriteLine(utakmice.Count);
                foreach (Utakmica u in utakmice)
                    u.Upis(sw);
            }
        }

        public void Citanje(String path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                maxIskljucenja = int.Parse(sr.ReadLine());
                int brojUtakmica = int.Parse(sr.ReadLine());
                for (int i = 0; i < brojUtakmica; i++)
                {
                    FudbalskaUtakmica u = new FudbalskaUtakmica();
                    u.Citanje(sr);
                    utakmice.Add(u);
                }

            }
        }

        public void Izbaci()
        {
            for (int i = 0; i < utakmice.Count; i++)
            {
                if (utakmice[i].Iskljucenja > maxIskljucenja)
                {
                    utakmice.RemoveAt(i);
                    i--;
                }
            }
            
        }
    }
}
