using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
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

        public void DodajElement(Object element)
        {
            if (brojElemenata < vektor.Length)
                vektor[brojElemenata++] = element;
            else
                Console.WriteLine("Nema mesta u nizu!");
        }

        public bool ImaJos()
        {
            return tekuci < brojElemenata && tekuci >= 0;
        }

        public void Sledeci()
        {
            tekuci++;
        }

        public void StampajTrenutni()
        {
            if (tekuci < 0)
            {
                Console.WriteLine("Iterator nije inicijalizovan!");
            }
            else if (tekuci >= brojElemenata)
            {
                Console.WriteLine("Iterator je došao do kraja!");
            }
            else
            {
                Console.WriteLine(vektor[tekuci]);
            }
        }

        // Prethodnu metodu možemo da implementiramo na sledeća 2 načina:
        // 1. Metoda koja eksplicitno implementira metodu interfejsa
        //void IIterator.StampajTrenutni()
        //{
        //    Console.WriteLine("Eksplicitna implementacija - metoda interfejsa");
        //    if (tekuci < 0)
        //    {
        //        Console.WriteLine("Iterator nije inicijalizovan!");
        //    }
        //    else if (tekuci >= brojElemenata)
        //    {
        //        Console.WriteLine("Iterator je došao do kraja!");
        //    }
        //    else
        //    {
        //        Console.WriteLine(vektor[tekuci]);
        //    }
        //}

        // 2. Metoda koja implicitno implementira metodu interfejsa
        //public void StampajTrenutni()
        //{
        //    Console.WriteLine("Implicitna implementacija - metoda klase");
        //    if (tekuci < 0)
        //    {
        //        Console.WriteLine("Iterator nije inicijalizovan!");
        //    }
        //    else if (tekuci >= brojElemenata)
        //    {
        //        Console.WriteLine("Iterator je došao do kraja!");
        //    }
        //    else
        //    {
        //        Console.WriteLine(vektor[tekuci]);
        //    }
        //}
        
        // Implicitna i eksplicitna implementacija metode interfejsa mogu da postoje istovremeno. 
        // U tom slučaju sledeći kod poziva implicitnu metodu (promenljiva ima tip klase)
        // VektorIterator i = new VektorIterator(3);
        // ...
        // i.StampajTrenutni();
        // 
        // Sledeći kod poziva eksplicitnu metodu (promenljiva ima tip interfejsa)
        // IIterator i = new VektorIterator(3);
        // ...
        // i.StampajTrenutni();
        // Eksplicitna implementacija interfejsa je korisna kada klasa implementira više od jednog interfejsa


        public void NaPocetak()
        {
            if (brojElemenata > 0)
                tekuci = 0;
            else
                Console.WriteLine("Nema elemenata u nizu!");
        }
    }
}
