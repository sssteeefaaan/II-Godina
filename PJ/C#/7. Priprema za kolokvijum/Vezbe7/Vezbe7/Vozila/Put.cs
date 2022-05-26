using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila
{
    public enum TipVozila
    {
        Automobil, 
        Kamion
    }

    public class Put
    {
        private int trenutniBroj;
        private IVozilo[] vozila; 
        // Umesto običnog niza [] moguće je koristiti i generičku listu List<IVozilo>
        // i tada je dodavanje i izbacivanje elemenata još jednostavnije. 
        private float ogranicenje, duzina;

        // Događaj preko kog klasa Put treba da upozori vozila na ograničenje mase vozila 
        // na tom putu. Delegat za ovaj događaj je zadat u posebnom fajlu. 
        public event UpozorenjeNosivost DogadjajUpozorenje;

        public Put()
        {
        }

        public Put(int maxBrojVozila, float ogranicenje, float duzina)
        {
            this.trenutniBroj = 0;
            this.ogranicenje = ogranicenje;
            this.duzina = duzina;
            this.vozila = new IVozilo[maxBrojVozila];
            // maxBrojVozila ne mora da se pamti kao atribut klase jer je dostupan kao
            // this.vozila.Length
        }

        // Metoda koja treba da upozori vozila tako što će da "ispali" događaj. 
        public void UpozoriVozila(float limitTezine)
        {
            // Provera da li je neki delegat dodeljen događaju tj. da li može da se "ispali" događaj 
            // a da se ne desi null reference izuzetak. 
            if (DogadjajUpozorenje != null)
                DogadjajUpozorenje(limitTezine);
        }

        public void DodajVozilo(IVozilo vozilo)
        {
            if (trenutniBroj < this.vozila.Length)
            {
                this.vozila[trenutniBroj] = vozilo;
                trenutniBroj++;
                // Event handlere za događaj provere mase ima smisla dodeliti samo kamionima, 
                // a ne i automobilima. 
                if (vozilo is Kamion)
                    this.DogadjajUpozorenje += ((Kamion)vozilo).ObradiUpozorenjeNosivost;
            }
            else
            {
                throw new Exception("Nema više mesta na putu!");
            }
        }


        // Put sadrži kolekciju vozila pa metode za rad sa fajlovima mogu da imaju
        // argument koji predstavlja putanju do fajla (relativnu ili apsolutnu). 
        // Ove metode kreiraju na osnovu putanje odgovarajući reader/writer i prosleđuju
        // ga metodama IVozilo.Snimi i IVozilo.Ucitaj. 
        public void Snimi(string fajl)
        {
            using (StreamWriter sw = new StreamWriter(fajl))
            {
                // Potrebna nam je i dužina niza tj. maksimalni broj vozila u njemu i 
                // i trenutni broj vozila u nizu. 
                sw.WriteLine(this.vozila.Length);
                sw.WriteLine(this.trenutniBroj);
                sw.WriteLine(this.ogranicenje);
                sw.WriteLine(this.duzina);

                for (int i = 0; i < trenutniBroj; i++)
                {
                    // Da bismo kod čitanja znali da li treba da pročitamo podatke o automobilu ili 
                    // podatke o kamionu (od toga nam zavisi koji je tip objekta koji kreiramo pri čitanju)
                    // ovde treba da upišemo tip trenutnog objekta. 
                    TipVozila tipVozila;
                    if (vozila[i].GetType() == typeof(Automobil))
                        tipVozila = TipVozila.Automobil;
                    else
                        tipVozila = TipVozila.Kamion;
                    // Najjednostavnije za kasnije čitanje je da vrednost enumeracije najpre 
                    // konvertujemo u int pa da se taj int upiše u fajl. 
                    sw.WriteLine((int)tipVozila);
                    vozila[i].Snimi(sw);
                }
            }
        }

        public void Ucitaj(string fajl)
        {
            using (StreamReader sr = new StreamReader(fajl))
            {
                this.vozila = new IVozilo[Int32.Parse(sr.ReadLine())];
                this.trenutniBroj = Int32.Parse(sr.ReadLine());
                this.ogranicenje = Single.Parse(sr.ReadLine());
                this.duzina = Single.Parse(sr.ReadLine());

                for (int i = 0; i < trenutniBroj; i++)
                {
                    // Ovde čitamo vrednost enumeracije koja je pre upisa u fajl bila konvertovana
                    // u int pa najpre mora da se radi parsiranje u int. Zatim se taj int konvertuje 
                    // u enumeraciju TipVozila.
                    TipVozila tipVozila = (TipVozila)Int32.Parse(sr.ReadLine());

                    // Da prilikom upisa u fajl nismo uradili konverziju u int vrednosti enumeracije
                    // bi bile upisane kao stringovi pa bi logika za čitanje bila sledeća:
                    //string tipString = sr.ReadLine();
                    //if (tipString == "Automobil")
                    //    tipVozila = TipVozila.Automobil;
                    //else
                    //    tipVozila = TipVozila.Kamion;

                    if (tipVozila == TipVozila.Automobil)
                        vozila[i] = new Automobil();
                    else
                        vozila[i] = new Kamion();
                    vozila[i].Ucitaj(sr);

                    // Event handlere za događaj provere mase ima smisla dodeliti samo kamionima, 
                    // a ne i automobilima. 
                    if (tipVozila == TipVozila.Kamion)
                        this.DogadjajUpozorenje += ((Kamion)vozila[i]).ObradiUpozorenjeNosivost;
                }
            }
        }

        public void IzbaciVozilaUPrekršaju(float dozvoljenoVreme)
        {
            Random rand = new Random();
            int i = 0;
            while (i < trenutniBroj)
            {
                float prosecnaBrzina = (float)(vozila[i].MaksimalnaBrzina * rand.NextDouble());
                float potrebnoVreme = duzina / prosecnaBrzina;
                if (potrebnoVreme > dozvoljenoVreme || prosecnaBrzina > ogranicenje)
                {
                    Console.WriteLine("Izbacujem vozilo " +vozila[i].Naziv + " sa pozicije " + i
                        + ". Prosečna brzina = " + prosecnaBrzina
                        + " Potrebno vreme = " + potrebnoVreme);
                    IzbaciVozilo(i);
                }
                else
                {
                    // i se povećava samo ako vozilo nije izbačeno, u suprotnom na to mesto je 
                    // došlo novo vozilo (a trenutniBroj je smanjen) pa treba odraditi proveru 
                    // i za to novo vozilo.
                    i++;
                }
            }
        }

        private void IzbaciVozilo(int pozicija)
        {
            if (pozicija >= 0 && pozicija < trenutniBroj)
            {
                // Kada se izbacuje vozilo treba izbaciti i event handler za to vozilo 
                // da se ne bi zvala provera za vozilo koje više nije na putu. 
                if (vozila[pozicija] is Kamion)
                    this.DogadjajUpozorenje -= ((Kamion)vozila[pozicija]).ObradiUpozorenjeNosivost;
                for (int i = pozicija; i < trenutniBroj - 1; i++)
                {
                    vozila[i] = vozila[i + 1];
                }
                trenutniBroj--;
            }
        }

    }
}

