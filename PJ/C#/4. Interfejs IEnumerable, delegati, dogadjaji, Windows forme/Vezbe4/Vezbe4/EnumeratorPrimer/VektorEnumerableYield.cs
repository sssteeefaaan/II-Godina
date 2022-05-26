using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorPrimer
{
    // Klasa koja implementira interfejs IEnumerable ima metodu GetEnumerator() 
    // iz tog interfejsa. Za razliku od klase VektorEnumerable ovde se metoda
    // GetEnumerator() implementira jednostavnije - korišćenjem ključne reči yield.
    // Kompajler na osnovu yield ključne reči generiše IEnumerator u međukodu. 
    class VektorEnumerableYield : IEnumerable
    {
        private Object[] vektor;
        private int trenutniBrojElemenata;

        public VektorEnumerableYield(int kapacitet)
        {
            trenutniBrojElemenata = 0;
            vektor = new Object[kapacitet];
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < trenutniBrojElemenata; i++)
                yield return vektor[i];
        }
    }
}
