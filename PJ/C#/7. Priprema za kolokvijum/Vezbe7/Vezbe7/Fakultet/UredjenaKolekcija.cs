using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultet
{
    public class UredjenaKolekcija : Kolekcija, IUredjivac
    {
        private Smer smer;

        public UredjenaKolekcija(int maxBroj)
            : base(maxBroj)
        {
            smer = Smer.Neuredjeno;
        }

        public void Uredi(Smer smer)
        {
            if (smer != Smer.Neuredjeno)
            {
                for (int i = 0; i < trenutniBroj - 1; i++)
                {
                    // iSelect je indeks selektovanog elementa za koji pretpostavljamo 
                    // da je manji ili veći (zavisno od parametra smer) od svih elemenata koji
                    // ga slede. 
                    int iSelect = i;
                    for (int j = i + 1; j < trenutniBroj; j++)
                    {
                        if (smer == Smer.Rastuci && niz[iSelect] > niz[j]
                            || smer == Smer.Opadajuci && niz[iSelect] < niz[j])
                            iSelect = j;
                    }
                    if (iSelect != i)
                    {
                        Student pom = niz[iSelect];
                        niz[iSelect] = niz[i];
                        niz[i] = pom;
                    }
                }
                this.smer = smer;
            }
        }
    }
}
