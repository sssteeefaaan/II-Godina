using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorProperties
{
    class VektorIterator : IIterator
    {
        private Object[] vektor;
        private int brojElemenata;
        private int tekuci;

        public VektorIterator(int brojElemenata)
        {
            this.brojElemenata = 0;
            tekuci = -1;
            vektor = new Object[brojElemenata];
        }

        public Object NoviElement
        {
            set
            {
                if (brojElemenata < vektor.Length)
                    vektor[brojElemenata++] = value;
                else
                    Console.WriteLine("Nema mesta u nizu!");
            }
        }

        public bool ImaJos
        {
            get
            {
                return tekuci < brojElemenata && tekuci >= 0;
            }
        }

        public void Sledeci()
        {
            tekuci++;
        }

        public Object TrenutniElement
        {
            get
            {
                if (tekuci < 0)
                {
                    Console.WriteLine("Iterator nije inicijalizovan!");
                    return null;
                }
                else if (tekuci >= brojElemenata)
                {
                    Console.WriteLine("Iterator je došao do kraja!");
                    return null;
                }
                else
                {
                    return vektor[tekuci];
                }
            }
        }

        public void NaPocetak()
        {
            if (brojElemenata > 0)
                tekuci = 0;
            else
                Console.WriteLine("Nema elemenata u nizu!");
        }
    }
}
