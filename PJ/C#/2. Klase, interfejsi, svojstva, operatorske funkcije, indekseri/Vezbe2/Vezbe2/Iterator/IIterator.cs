using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    // Po konvenciji interfejsi u C# imaju prefix I ispred naziva
    interface IIterator
    {
        // Podrazumeva se da su sve metode interfejsa public abstract, ali ukoliko to pokušamo da 
        // eksplicitno zadamo kompajler će prijaviti grešku
        void DodajElement(Object element);
        void StampajTrenutni();
        bool ImaJos();
        void Sledeci();
        void NaPocetak();

    }
}
