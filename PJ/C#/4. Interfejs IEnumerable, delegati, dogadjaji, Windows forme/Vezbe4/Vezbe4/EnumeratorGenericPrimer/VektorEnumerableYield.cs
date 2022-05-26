using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorGenericPrimer
{
    // Klasa koja implementira interfejs IEnumerable<T> ima metodu GetEnumerator() 
    // iz tog interfejsa i metodu GetEnumerator() iz interfejsa IEnumerable.
    // Za razliku od klase VektorEnumerable ovde se obe metode GetEnumerator() 
    // implementiraju jednostavnije - korišćenjem ključne reči yield.
    class VektorEnumerableYield<T> : IEnumerable<T>
    {
        private T[] vektor;
        private int trenutniBrojElemenata;

        public VektorEnumerableYield(int kapacitet)
        {
            trenutniBrojElemenata = 0;
            vektor = new T[kapacitet];
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

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < trenutniBrojElemenata; i++)
                yield return vektor[i];
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < trenutniBrojElemenata; i++)
                yield return vektor[i];
        }
    }
}
