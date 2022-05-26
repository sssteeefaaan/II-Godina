using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligoni
{
    class Poligon
    {
        private int brojTemena;   // broj temena mnogougla
        private double poluprecnik;  // poluprečnik opisane kružnice oko mnogougla
        private Tacka[] niz;         // niz temena mnogougla     

        public Poligon(int brojTemena, double poluprecnik)
        {
            // Ovaj konstruktor kreira pravilan mnogougao sa zadatim brojem temena
            // koji je upisan u kružnicu zadatog poluprečnika. 
            if (brojTemena < 3)
                Console.WriteLine("Poligon treba da ima najmanje 3 temena");
            else
            {
                this.brojTemena = brojTemena;
                this.poluprecnik = poluprecnik;
                this.niz = new Tacka[brojTemena];  
                // Niz temena mnogougla se generiše na sledeći način
                // Deli se pun krug na onoliko kružnih isečaka koliko ima temena
                double ugaoInkrement = 2 * Math.PI / brojTemena;
                // Kreće se od ugla 0 i ide se do ugla ((brojTemena - 1)/brojTemena) * 2 * Math.PI
                // Granice tako dobijenih kružnih isečaka su temena mnogougla
                for (int i = 0; i < brojTemena; i++)
                {
                    niz[i].X = Math.Round(poluprecnik * Math.Cos(i * ugaoInkrement), 3); 
                    niz[i].Y = Math.Round(poluprecnik * Math.Sin(i * ugaoInkrement), 3);
                    // zbog greške reda veličine 10e-15 radimo zaokruživanje rezultata
                }
            }
        }

        // Indexer - posebna vrsta property-ja. Koristi se ključna reč this i argument 
        // indexera između uglastih zagrada. U ovom slučaju je jedna dimenzija. Ako 
        // ima više dimenzija argumenti su razdvojeni zarezom. 
        public Tacka this[int i]
        {
            get
            {
                return niz[i];
                // Getter se izvršava ako negde u kodu pokušavamo da pročitamo vrednost odgovarajućeg niza
                // Primer: 
                // Poligon p = new Poligon();
                // ...
                // Console.WriteLine(p[2]); 
                // na ovaj način imamo kraći zapis umesto da pišemo p.niz[2] 
            }
            set
            {
                niz[i] = value;
                // Setter se poziva kod dodele vrednosti property-ju
                // Primer:
                // Poligon p = new Poligon();
                // ...
                // p[2] = new Tacka(1, 0); 
                // ovde se poziva setter, promenljiva value ima vrednost Tacka(1, 0)

            }
        }
    }
}
