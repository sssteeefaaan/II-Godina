using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int brVrsta = 3, brKolona = 4;
            // inicijalizacija matrice
            Matrica m = new Matrica(brVrsta, brKolona);
            for (int i = 0; i < brVrsta; i++)
                for (int j = 0; j < brKolona; j++)
                    m[i, j] = i * brKolona + j;
            Console.WriteLine("Originalna matrica:");
            m.Stampa();
            Console.WriteLine();

            Console.WriteLine("Postfiksni poziv ++ operatora i štampa u jednoj naredbi:");
            m++.Stampa();
            Console.WriteLine("Samo štampa matrice:");
            m.Stampa();
            Console.WriteLine();

            Console.WriteLine("Prefiksni poziv ++ operatora i štampa u jednoj naredbi:");
            (++m).Stampa();
            Console.WriteLine("Samo štampa matrice:");
            m.Stampa();
            Console.WriteLine();

            // test sabiranja matrica
            Console.WriteLine("Rezultat sabiranja prethodne matrice sa samom sobom:");
            Matrica zbir = m + m;
            zbir.Stampa();
            Console.WriteLine();

            // test množenja matrica
            Matrica m1 = new Matrica(4, 3);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 3; j++)
                    m1[i, j] = i * 3 + j;
            Console.WriteLine("Proizvod matrica:");
            m.Stampa();
            Console.WriteLine("i");
            m1.Stampa();
            Console.WriteLine("je");
            Matrica proizvod = m * m1;
            proizvod.Stampa();
        }
    }
}
