using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila
{
    class Kamion : IVozilo
    {
        // Naredna 3 atributa se dodaju zbog property-ja koje nameće interfejs IVozilo.
        private string naziv; 
        private int serijskiBroj;
        private float maksimalnaBrzina;
        // Ovaj atribut se eksplicitno traži u zadatku. 
        private float nosivost;

        
        public string Naziv { get {return naziv;} }
        public int SerijskiBroj { get { return serijskiBroj; } }
        public float MaksimalnaBrzina { get { return maksimalnaBrzina; } }

        // Konstruktor bez argumenata se ne traži u tekstu zadatka, ali je koristan kod
        // čitanja Kamiona iz fajla. Tada najpre kreiramo objekat Kamion ovim 
        // konstruktorom (nije nam važno koje su vrednosti atributa klase) pa onda 
        // odmah čitamo vrednosti atributa iz fajla. 
        public Kamion()
        {
        }

        public Kamion(string naziv, int serijskiBroj, float maksimalnaBrzina, float nosivost)
        {
            this.naziv = naziv;
            this.serijskiBroj = serijskiBroj;
            if (maksimalnaBrzina < 60 || maksimalnaBrzina > 130)
                throw new Exception("Maksimalna brzina od " + maksimalnaBrzina + " je van predviđenog opsega!");
            this.maksimalnaBrzina = maksimalnaBrzina;
            this.nosivost = nosivost;
        }

        public void Snimi(StreamWriter sw)
        {
            sw.WriteLine(this.naziv);
            sw.WriteLine(this.serijskiBroj);
            sw.WriteLine(this.maksimalnaBrzina);
            sw.WriteLine(this.nosivost);
        }


        public void Ucitaj(StreamReader sr)
        {
            this.naziv = sr.ReadLine();
            this.serijskiBroj = Int32.Parse(sr.ReadLine());
            // umesto Int32.Parse ravnopravno može da se koristi i int.Parse
            this.maksimalnaBrzina = Single.Parse(sr.ReadLine());
            // umesto Single.Parse ravnopravno može da se koristi i float.Parse
            if (maksimalnaBrzina < 60 || maksimalnaBrzina > 130)
                throw new Exception("Maksimalna brzina od " + maksimalnaBrzina + " je van predviđenog opsega!");
            this.nosivost = Single.Parse(sr.ReadLine());
        }

        public void ObradiUpozorenjeNosivost(float limitTezine)
        {
            if (this.nosivost > limitTezine)
                Console.WriteLine("Kamion " + this.naziv + ": \"Prekoračio sam nosivost puta!");
        }


    }
}
