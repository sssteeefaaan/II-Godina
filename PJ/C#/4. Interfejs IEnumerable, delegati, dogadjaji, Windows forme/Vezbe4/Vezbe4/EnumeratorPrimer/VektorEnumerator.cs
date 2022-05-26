using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorPrimer
{

    // Klasa koja implementira interfejs IEnumerator ima property Current i 
    // metode MoveNext() i Reset() iz tog interfejsa. 
    class VektorEnumerator : IEnumerator
    {
        private Object[] vektor;
        private int trenutniBrojElemenata;
        private int tekuci;

        public VektorEnumerator(int kapacitet)
        {
            trenutniBrojElemenata = 0;
            tekuci = -1;
            vektor = new Object[kapacitet];
        }

        public VektorEnumerator(Object[] vektor, int trenutniBrojElemenata)
        {
            this.trenutniBrojElemenata = trenutniBrojElemenata;
            tekuci = -1;
            this.vektor = vektor;
        }

        public void DodajElement(Object element)
        {
            if (trenutniBrojElemenata < vektor.Length)
            {
                vektor[trenutniBrojElemenata++] = element;
            }
            else
                throw new Exception("Vektor je pun");
        }

        object IEnumerator.Current
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

        bool IEnumerator.MoveNext()
        {
            if (tekuci < trenutniBrojElemenata - 1)
            {
                tekuci++;
                return true;
            }
            else
                return false;

        }

        void IEnumerator.Reset()
        {
            tekuci = -1;
        }
    }
}
