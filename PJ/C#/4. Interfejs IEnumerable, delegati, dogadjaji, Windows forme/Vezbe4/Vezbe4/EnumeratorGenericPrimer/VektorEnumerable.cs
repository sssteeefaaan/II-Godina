using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorGenericPrimer
{
    // Klasa koja implementira interfejs IEnumerable<T> ima metodu GetEnumerator() 
    // iz tog interfejsa i metodu GetEnumerator() iz interfejsa IEnumerable. 
    // Obe metode vraćaju instancu klase VektorEnumerator<T> koja 
    // implementira interfejs IEnumerator. 
    class VektorEnumerable<T> : IEnumerable<T>
    {
        private T[] vektor;
        private int trenutniBrojElemenata;


        public VektorEnumerable(int kapacitet)
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

        // Eksplicitno implementira generički interfejs IEnumerable<T>.
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new VektorEnumerator<T>(vektor, trenutniBrojElemenata);
        }

        // Eksplicitno implementira negenerički interfejs IEnumerable.
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new VektorEnumerator<T>(vektor, trenutniBrojElemenata);
        }
    }
}
