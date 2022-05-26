using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojevi
{
    // Osnovna apstraktna klasa
    abstract class KompleksniBroj
    {
        // Zadaju se 2 apstrakne metode bez ulaženja u detalje njihove implementacije
        // Apstraktne metode ne mogu biti privatne
        abstract protected float Moduo();

        abstract public void Stampaj();

        // Zadaje se i jedna metoda sa implementacijom koja može da poziva neke od apstraktnih metoda
        public bool VeciOd(KompleksniBroj broj)
        {
            return this.Moduo() > broj.Moduo();
        }
    }
}
