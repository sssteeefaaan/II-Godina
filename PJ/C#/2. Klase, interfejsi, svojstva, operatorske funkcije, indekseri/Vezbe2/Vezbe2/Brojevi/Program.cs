using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elementi niza ne mogu biti tipa apstraktne klase jer apstraktne klase 
            // ne mogu da imaju svoje instance. 
            // Niz možemo da kreiramo kao niz podataka tipa apstraktne klase, jer je 
            // to u stvari niz pokazivača. 
            KompleksniBroj[] niz = new KompleksniBroj[4];
            niz[0] = new DekartovKompleksniBroj(1, 1);
            niz[1] = new PolarniKompleksniBroj(1, 1);
            niz[2] = new DekartovKompleksniBroj(2, 2);
            niz[3] = new PolarniKompleksniBroj(2, 2);

            // Štampamo niz pre sortiranja
            Console.WriteLine("Osnovni niz:");
            foreach (KompleksniBroj kb in niz)
            {
                kb.Stampaj();
                Console.WriteLine();
            }
            
            // Sortiramo niz
            for (int i = 0; i < niz.Length - 1; i++)
            {
                int iMin = i;
                for (int j = i + 1; j < niz.Length; j++)
                {
                    if (niz[iMin].VeciOd(niz[j]))
                        iMin = j;
                }
                if (iMin != i)
                {
                    KompleksniBroj tmp = niz[iMin];
                    niz[iMin] = niz[i];
                    niz[i] = tmp;
                }
            }

            // Štampamo niz posle sortiranja
            Console.WriteLine("Sortirani niz:");
            foreach (KompleksniBroj kb in niz)
            {
                kb.Stampaj();
                Console.WriteLine();
            }

        }
    }
}
