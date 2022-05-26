using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila
{
    class Automobil : IVozilo
    {
        // Naredna 3 atributa se dodaju zbog property-ja koje nameće interfejs IVozilo.
        private string naziv; 
        private int serijskiBroj;
        private float maksimalnaBrzina;
        // Ovaj atribut se eksplicitno traži u zadatku. 
        private int brojMesta;

        
        public string Naziv { get {return naziv;} }
        public int SerijskiBroj { get { return serijskiBroj; } }
        public float MaksimalnaBrzina { get { return maksimalnaBrzina; } }

        // Konstruktor bez argumenata se ne traži u tekstu zadatka, ali je koristan kod
        // čitanja Automobila iz fajla. Tada najpre kreiramo objekat Automobil ovim 
        // konstruktorom (nije nam važno koje su vrednosti atributa klase) pa onda 
        // odmah čitamo vrednosti atributa iz fajla. 
        public Automobil()
        {
        }

        public Automobil(string naziv, int serijskiBroj, float maksimalnaBrzina, int brojMesta)
        {
            this.naziv = naziv;
            this.serijskiBroj = serijskiBroj;
            if (maksimalnaBrzina < 90 || maksimalnaBrzina > 250)
                throw new Exception("Maksimalna brzina od " + maksimalnaBrzina + " je van predviđenog opsega!");
            this.maksimalnaBrzina = maksimalnaBrzina;
            this.brojMesta = brojMesta;
        }

        public void Snimi(StreamWriter sw)
        {
            sw.WriteLine(this.naziv);
            sw.WriteLine(this.serijskiBroj);
            sw.WriteLine(this.maksimalnaBrzina);
            sw.WriteLine(this.brojMesta);
        }


        public void Ucitaj(StreamReader sr)
        {
            this.naziv = sr.ReadLine();
            this.serijskiBroj = Int32.Parse(sr.ReadLine());
            // umesto Int32.Parse ravnopravno može da se koristi i int.Parse
            this.maksimalnaBrzina = Single.Parse(sr.ReadLine()); 
            // umesto Single.Parse ravnopravno može da se koristi i float.Parse
            if (maksimalnaBrzina < 90 || maksimalnaBrzina > 250)
                throw new Exception("Maksimalna brzina od " + maksimalnaBrzina + " je van predviđenog opsega!");
            this.brojMesta = Int32.Parse(sr.ReadLine());  
        }


    }
}
