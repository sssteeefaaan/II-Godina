using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorPrimer
{
    // Klasa koja implementira interfejs IEnumerable ima metodu GetEnumerator() 
    // iz tog interfejsa. Ta metoda vraća instancu klase VektorEnumerator koja 
    // implementira interfejs IEnumerator. 
    class VektorEnumerable : IEnumerable
    {
        private Object[] vektor;
        private int trenutniBrojElemenata;

        public VektorEnumerable(int kapacitet)
        {
            trenutniBrojElemenata = 0;
            vektor = new Object[kapacitet];
        }

        public void DodajElement(object element)
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
            return new VektorEnumerator(vektor, trenutniBrojElemenata);
        }

    }
}
