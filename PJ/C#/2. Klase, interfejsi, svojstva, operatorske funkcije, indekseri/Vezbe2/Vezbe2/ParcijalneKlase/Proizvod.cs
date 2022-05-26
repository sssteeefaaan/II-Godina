using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcijalneKlase
{
    // Implementacija klase može zbog bolje čitljivosti biti podeljena u više različitih fajlova. 
    // U svim fajlovima se piše deklaracija klase sa ključnom rečju partial. 
    // Svi delovi klase moraju biti u okviru istog namespace-a
    partial class Proizvod
    {
        private int sifra;
        private string naziv;

        public Proizvod(int sifra, string naziv, float cena, float kolicina)
        {
            this.sifra = sifra;
            this.naziv = naziv;
            // Članovi klase definisani u jednom delu klase su ravnopravno dostupni u svim ostalim
            // delovima klase. 
            this.cena = cena;
            this.kolicina = kolicina;
        }

    }
}
