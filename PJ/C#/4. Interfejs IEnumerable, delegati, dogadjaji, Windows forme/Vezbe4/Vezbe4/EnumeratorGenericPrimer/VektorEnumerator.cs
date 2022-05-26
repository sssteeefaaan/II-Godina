using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorGenericPrimer
{
    // Klasa koja implementira generički interfejs IEnumerator<T> ima metode MoveNext() 
    // i Reset() iz tog interfejsa. Interfejs ima dva različita property-ja Current:
    // jedan vraća objekat tipa Object, a drugi objekat tipa T. 
    // Interfejs IEnumerator<T> nasleđuje interfejs IDisposable. Ako klasa ne sadrži 
    // eksterne resurse (kao što je slučaj ovde) Dispose metoda može da ostane prazna. 
    // Ako se npr. IEnumerator koristi za čitanje tekstualnog fajla (može da vraća liniju 
    // po liniju) onda se u Dispose metodi zatvara taj fajl. 
    class VektorEnumerator<T> : IEnumerator<T>
    {
        private T[] vektor;
        private int trenutniBrojElemenata;
        private int tekuci;

        public VektorEnumerator(int kapacitet)
        {
            trenutniBrojElemenata = 0;
            tekuci = -1;
            vektor = new T[kapacitet];
        }

        public VektorEnumerator(T[] vektor, int trenutniBrojElemenata)
        {
            this.trenutniBrojElemenata = trenutniBrojElemenata;
            tekuci = -1;
            this.vektor = vektor;
        }

        public void DodajElement(T element)
        {
            if (trenutniBrojElemenata < vektor.Length)
            {
                vektor[trenutniBrojElemenata++] = element;
            }
            else
                throw new Exception("Vektor je pun");
        }

        // Eksplicitno implementira generički interfejs IEnumerator<T>.
        T IEnumerator<T>.Current
        {
            get
            {
                if (tekuci == -1)
                    throw new Exception("Enumerator je resetovan. Pozovite prethodno MoveNext metodu. ");
                if (trenutniBrojElemenata < 1)
                    throw new Exception("Vektor je prazan");
                return vektor[tekuci];
            }
        }

        void IDisposable.Dispose()
        {
            // Ako nema unmanaged resursa za zatvaranje (fajl tokovi, konekcije sa
            // bazom podataka itd.) ova metoda može da ostane prazna. 
            // Ovde se samo štampa poruka da bismo proverili da se metoda 
            // poziva po izlasku iz foreach petlje. 
            Console.WriteLine("Izvršava se Dispose metod u klasi VektorEnumerator");
        }

        // Eksplicitno implementira negenerički interfejs IEnumerator.
        object System.Collections.IEnumerator.Current
        {
            get { return ((IEnumerator<T>)this).Current; }
        }

        bool System.Collections.IEnumerator.MoveNext()
        {
            if (tekuci < trenutniBrojElemenata - 1)
            {
                tekuci++;
                return true;
            }
            else
                return false;
        }

        void System.Collections.IEnumerator.Reset()
        {
            tekuci = -1;
        }
    }
}
