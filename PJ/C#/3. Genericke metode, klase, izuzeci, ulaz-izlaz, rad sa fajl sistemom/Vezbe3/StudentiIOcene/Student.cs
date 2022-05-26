using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentiIOcene
{
    public class Student
    {
        // Privatni atribut klase
        private String ime;

        // Odgovarajući property za navedeni atribut. 
        // Sintasno liči na atribut - ne pišu se zagrade posle property-a. 
        // U stvari radi kao metoda. 
        // Važi sve što važi i za metodu - property može biti virtualni, apstraktni...
        public String Ime
        {
            // Getter deo property-a. Na osnovu njega kompajler interno generiše
            // get metodu koja je skrivena od programera. 
            // Kada negde u kodu pokušamo da preuzmemo vrednost property-ja 
            // pozvaće se getter. 
            // Primer: 
            // Student s = new Student();
            // ...
            // Console.WriteLine(s.Ime); // ovde se poziva getter
            get
            {
                return this.ime;
            }
            // Setter deo property-a. Na osnovu njega kompajler interno generiše
            // set metodu koja je skrivena od programera. 
            set
            {
                this.ime = value; 
                // Ključna reč value predstavlja promenljivu čiju vrednost dodeljujemo
                // property-ju
                // Primer:
                // Student s = new Student();
                // ...
                // s.Ime = "Marko"; // ovde se poziva setter, promenljiva value ima vrednost "Marko"
            }
        }

        // Moguće je zadati property bez odgovarajućeg atributa tzv. automatski property. 
        // U ovom slučaju sam kompajler automatski generiše odgovarajući atribut koji 
        // je nama nevidljiv. 
        // Na ovaj način imamo kraći zapis i delimično ograničene mogućnosti korišćenja
        // jer nemamo kontrolu nad tim atributom. 
        public String Prezime
        {
            get;
            set;
        }

        private int indeks;

        // Neka je broj indeksa studenta nepromenjiv van ove klase. 
        // Zbog toga property dobija samo getter. Ovo je read-only property. 
        public int Indeks
        {
            get
            {
                return this.indeks;
            }
        }

        private float poeni;

        // Ako nam nije neophodno da broj poena čitamo van klase student property može 
        // biti write-only.
        public float Poeni
        {
            set
            {
                // property može da ima proizvoljan kod u svojim getter-ima i setter-ima
                // npr. poziv neke druge funkcije
                PostaviBrojPoena(value);
            }
        }

        public int Ocena
        {
            get
            {
                // property može da ima proizvoljan kod u svojim getter-ima i setter-ima
                // ovde sadrži logiku za računanje ocene na osnovu broja poena na ispitu
                if (poeni >= 95)
                    return 10;
                else if (poeni >= 85)
                    return 9;
                else if (poeni >= 75)
                    return 8;
                else if (poeni >= 65)
                    return 7;
                else if (poeni >= 55)
                    return 6;
                else
                    return 5;
            }
        }

        public Student(String ime, String prezime, int indeks, float poeni)
        {
            this.ime = ime;
            this.Prezime = prezime;  // ne postoji odgovarajući atribut 
            // pa ovde postavljamo direktno vrednost property-ja
            this.indeks = indeks;
            PostaviBrojPoena(poeni);
        }

        // Izdvojena je kao posebna funkcija jer se koristi i u konstruktoru i u property-ju. 
        private void PostaviBrojPoena(float poeni)
        {
            if (poeni < 0 || poeni > 100)
                Console.WriteLine("Broj poena mora biti u opsegu [0-100].");
            else
                this.poeni = poeni;
        }

    }
}
