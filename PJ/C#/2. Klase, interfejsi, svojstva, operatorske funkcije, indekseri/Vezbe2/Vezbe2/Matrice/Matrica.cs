using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrice
{
    class Matrica
    {
        private int vrsta, kolona; // broj vrsta i broj kolona
        private float[,] podaci;

        public Matrica(int vrsta, int kolona)
        {
            // konstruktor koji postavlja broj vrsta i broj kolona
            this.vrsta = vrsta;
            this.kolona = kolona;
            this.podaci = new float[vrsta, kolona];
        }

        public Matrica(Matrica matrica)
        {
            // konstruktor koji radi kopiranje postojeće matrice
            this.vrsta = matrica.vrsta;
            this.kolona = matrica.kolona;
            this.podaci = new float[vrsta, kolona];
            for (int i = 0; i < vrsta; i++)
                for (int j = 0; j < kolona; j++)
                    podaci[i, j] = matrica.podaci[i, j];
        }

        // Indekser sa 2 dimenzije (2 argumenta). 
        public float this[int i, int j]
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
                    Console.Write(podaci[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Preklapanje unarnog operatora ++. Ne zadaju se posebne funkcije
        // za prefiksni i postfiksni poziv unarnog operatora. 
        public static Matrica operator ++(Matrica matrica)
        {
            Matrica rezultat = new Matrica(matrica);
            for (int i = 0; i < rezultat.vrsta; i++)
                for (int j = 0; j < rezultat.kolona; j++)
                    rezultat.podaci[i, j]++;
            return rezultat;
        }

        // Preklapanje binarnog operatora +. 
        public static Matrica operator +(Matrica matrica1, Matrica matrica2)
        {
            if (matrica1.vrsta != matrica2.vrsta || matrica1.kolona != matrica2.kolona)
            {
                Console.WriteLine("Matrice za sabiranje moraju biti istog reda.");
                return null;
            }
            else
            {
                Matrica rezultat = new Matrica(matrica1.vrsta, matrica1.kolona);
                for (int i = 0; i < rezultat.vrsta; i++)
                    for (int j = 0; j < rezultat.kolona; j++)
                        rezultat.podaci[i, j] = matrica1.podaci[i, j] + matrica2.podaci[i, j];

                return rezultat;
            }
        }

        // Preklapanje binarnog operatora *. 
        public static Matrica operator *(Matrica matrica1, Matrica matrica2)
        {
            if (matrica1.kolona != matrica2.vrsta)
            {
                Console.WriteLine("Za množenje matrica broj kolona prvog operanda i broj vrsta drugog operanda moraju biti identični.");
                return null;
            }
            else
            {
                Matrica rezultat = new Matrica(matrica1.vrsta, matrica2.kolona);
                for (int i = 0; i < rezultat.vrsta; i++)
                {
                    for (int j = 0; j < rezultat.kolona; j++)
                    {
                        rezultat.podaci[i, j] = 0;
                        for (int k = 0; k < matrica1.kolona; k++)
                            rezultat.podaci[i, j] += matrica1.podaci[i, k] * matrica2.podaci[k, j];
                    }
                }
                return rezultat;
            }
        }
    }
}
