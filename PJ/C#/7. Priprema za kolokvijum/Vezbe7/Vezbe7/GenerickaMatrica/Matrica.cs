using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerickaMatrica
{
    class Matrica<T> where T : struct, IBroj // ograničenje da T mora da bude struktura 
        // koja implementira interfejs IBroj
    {
        private int vrsta, kolona; // broj vrsta i broj kolona
        private T[,] podaci;

        public Matrica(int vrsta, int kolona)
        {
            // konstruktor koji postavlja broj vrsta i broj kolona
            this.vrsta = vrsta;
            this.kolona = kolona;
            this.podaci = new T[vrsta, kolona];
        }

        public Matrica(Matrica<T> matrica)
        {
            // konstruktor koji radi kopiranje postojeće matrice
            this.vrsta = matrica.vrsta;
            this.kolona = matrica.kolona;
            this.podaci = new T[vrsta, kolona];
            for (int i = 0; i < vrsta; i++)
                for (int j = 0; j < kolona; j++)
                    podaci[i, j] = matrica.podaci[i, j];
                    // Zbog ograničenja da je tip T struktura tj. vrednosni tip ovakvo kopiranje 
                    // je u redu. Da je tip T klasa tj. referentni tip kopiranje bi moralo da se 
                    // radi tako da se kopira svaki element matrice posebno:
                    // podaci[i, j] = new T(matrica.podaci[i, j]);
                    // Ali prethodna linija koda dovodi do greške prilikom kompajliranja jer 
                    // ne postoji način da budemo sigurni da tip T ima konstruktor za kopiranje. 
                    // Jedno od mogućih rešenja je da interfejs IBroj ima metodu:
                    // IBroj Clone()
                    // koja pravi kopiju tekućeg objekta this i koristimo je ovako:
                    // podaci[i, j] = (T)matrica.podaci[i, j].Clone();
        }

        // Indekser sa 2 dimenzije (2 argumenta). 
        public T this[int i, int j]
        {
            get { return podaci[i, j]; }
            set { this.podaci[i, j] = value; }
        }

        public void Stampa()
        {
            for (int i = 0; i < vrsta; i++)
            {
                for (int j = 0; j < kolona; j++)
                {
                    Console.Write(podaci[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }

        // Preklapanje unarnog operatora ++. Ne zadaju se posebne funkcije
        // za prefiksni i postfiksni poziv unarnog operatora. 
        public static Matrica<T> operator ++(Matrica<T> matrica)
        {
            // Ova metoda se izvršava i kod prefiksnog i kod postfiksnog poziva operatora ++. 
            // Zbog postfiksnog poziva moramo da obezbedimo da ova metoda ne menja operand
            // matrica već njegovu kopiju koju na kraju vraća. 
            Matrica<T> rezultat = new Matrica<T>(matrica);
            for (int i = 0; i < rezultat.vrsta; i++)
                for (int j = 0; j < rezultat.kolona; j++)
                    rezultat.podaci[i, j].Inkrement();
                    //rezultat.podaci[i, j]++;
                    // Prethodna linija bi bila korektna u C++ templejtskoj klasi. U C# kompajler
                    // prijavljuje grešku jer ne postoji način da garantujemo da tip T ima 
                    // operator ++. 
            return rezultat;
        }

        // Preklapanje binarnog operatora +. 
        public static Matrica<T> operator +(Matrica<T> matrica1, Matrica<T> matrica2)
        {
            if (matrica1.vrsta != matrica2.vrsta || matrica1.kolona != matrica2.kolona)
            {
                Console.WriteLine("Matrice za sabiranje moraju biti istog reda.");
                return null;
            }
            else
            {
                Matrica<T> rezultat = new Matrica<T>(matrica1.vrsta, matrica1.kolona);
                for (int i = 0; i < rezultat.vrsta; i++)
                    for (int j = 0; j < rezultat.kolona; j++)
                        // Funkcija Saberi iz interfejsa IBroj vraća rezultat tipa IBroj, ali kompajler nema načina
                        // da bude siguran da pored toga što je tipa IBroj da li je rezultat i tipa T. 
                        // To mi obezbeđujemo takvom implementacijom da u klasi KompleksniBroj funkcija 
                        // Saberi vraća rezultat tipa KompleksniBroj, a u klasi RacionalniBroj vraća tip 
                        // RacionalniBroj. 
                        // Ovde samo kastovanjem u tip T to i potvrđujemo. 
                        rezultat.podaci[i, j] = (T)matrica1.podaci[i, j].Saberi(matrica2.podaci[i, j]);
                return rezultat;
            }
        }

        // Preklapanje binarnog operatora *. 
        public static Matrica<T> operator *(Matrica<T> matrica1, Matrica<T> matrica2)
        {
            if (matrica1.kolona != matrica2.vrsta)
            {
                Console.WriteLine("Za množenje matrica broj kolona prvog operanda i broj vrsta drugog operanda moraju biti identični.");
                return null;
            }
            else
            {
                Matrica<T> rezultat = new Matrica<T>(matrica1.vrsta, matrica2.kolona);
                for (int i = 0; i < rezultat.vrsta; i++)
                {
                    for (int j = 0; j < rezultat.kolona; j++)
                    {
                        // Za računanje sume treba nam nulta vrednost za inicijalizaciju. Ne možemo 
                        // da koristimo new T() - za kompleksni broj daje vrednost 0+j0 što je u redu, 
                        // ali za racionalni broj daje vrednost 0/0 što je pogrešno (konstruktor bez
                        // argumenata kod struktura ne možemo sami da zadamo, podrazumevano radi tako
                        // da postavlja sve atribute strukture na njihove podrazumevane vrednosti. 
                        // Zbog toga nam je potreban property koji vraća nultu vrednost za odgovarajući 
                        // tip broja i tom nultom vrednošću inicijalizujemo vrednost sume na početku. 
                        rezultat.podaci[i, j] = (T)rezultat.podaci[i, j].Nula;
                        for (int k = 0; k < matrica1.kolona; k++)
                            rezultat.podaci[i, j] = (T)rezultat.podaci[i, j].Saberi(matrica1.podaci[i, k].Pomnozi(matrica2.podaci[k, j]));
                    }
                }
                return rezultat;
            }
        }
    }
}
