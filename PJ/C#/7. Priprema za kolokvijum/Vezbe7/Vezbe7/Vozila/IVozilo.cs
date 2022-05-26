using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila
{
    public interface IVozilo
    {
        // U zadatku se traži samo property koji vraća neku vrednost
        // što znači da je dovoljan samo get deo. 
        string Naziv { get; }
        int SerijskiBroj { get; }
        float MaksimalnaBrzina { get; }

        // Klasa Put je kolekcija objekata tipa IVozilo i ta klasa treba da omogući 
        // da se svi njeni atributi uključujući i kolekciju vozila upisuju u fajl i 
        // čitaju iz fajla. Najjednostavniji način za to je da interfejs IVozilo zada
        // metode čiji su argumenti StreamReader, odnosno StreamWriter koje pretpostavljaju 
        // da će im se proslediti već kreirani i otvoreni tokovi. Klasa Put treba 
        // da otvori tok podataka, da upiše/pročita svoje atribute i da kroz petlju
        // poziva metode Ucitaj/Snimi za svako od svojih vozila. 
        void Ucitaj(StreamReader sr);
        void Snimi(StreamWriter sw);
    }
}
