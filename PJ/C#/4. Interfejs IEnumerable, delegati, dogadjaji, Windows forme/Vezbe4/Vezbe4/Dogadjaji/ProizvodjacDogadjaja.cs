using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji
{
    class ProizvodjacDogadjaja
    {
        // promenljivu broj menjamo isključivo kroz property
        // da bismo tu ispitali promenu i pozvali event
        private int broj;
        // deklaracija delegata
        public delegate void ObradaPromeneBroja(int broj);
        // instanca događaja za navedeni tip delegata
        public event ObradaPromeneBroja PromenaBroja;
        
        // funkcija za poziv event-a, proverava da li je event instanciran
        // ako jeste poziva ga
        protected virtual void BrojPromenjen()
        {
            if (PromenaBroja != null)
            {
                PromenaBroja(broj);
            }
            else
            {
                Console.WriteLine("Nema event handlera!");
            }
        }

        // konstruktor postavlja broj samo preko property-ja da bi mogla
        // da se prati promena vrednosti broja
        public ProizvodjacDogadjaja(int n)
        {
            Broj = n;
        }


        public int Broj
        {
            get
            {
                return this.broj;
            }
            set
            {
                // ako broj dobija novu vrednost zove se funkcija za 
                // "okidanje" event-a
                if (this.broj != value)
                {
                    this.broj = value;
                    BrojPromenjen();
                }
            }
        }
    }
}
