using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorProperties
{
    // Po konvenciji interfejsi u C# imaju prefix "I" ispred naziva
    interface IIterator
    {
        // Podrazumeva se da su sve metode interfejsa public abstract, ali ukoliko to pokušamo da 
        // eksplicitno zadamo kompajler će prijaviti grešku
        
        // void DodajElement(Object element);
        // Umesto prethodne metode možemo da definišemo apstraktno svojstvo 
        // koje ima samo set deo. 
        Object NoviElement { set; }

        // void StampajTrenutni();
        // Umesto prethodne metode možemo da definišemo apstraktno svojstvo 
        // koje ima samo get deo. 
        Object TrenutniElement { get; }

        // bool ImaJos(); 
        // Umesto prethodne metode možemo da definišemo apstraktno svojstvo 
        // koje ima samo get deo. 
        bool ImaJos { get; }

        void Sledeci();
        void NaPocetak();
    }
}
