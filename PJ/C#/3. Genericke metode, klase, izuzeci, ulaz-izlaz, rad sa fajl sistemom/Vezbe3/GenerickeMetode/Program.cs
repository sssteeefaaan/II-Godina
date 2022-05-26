using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerickeMetode
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] celiBrojevi = { 3, 1, 9, 6, 8, 2 };
            //SortirajCeleBrojeve(celiBrojevi);

            //float[] realniBrojevi = { 1.41f, 3.14159f, 0.301f, 1.618f };
            //SortirajRealneBrojeve(realniBrojevi);

            int[] celiBrojevi = { 3, 1, 9, 6, 8, 2 };
            Sortiraj<int>(celiBrojevi);

            float[] realniBrojevi = { 1.41f, 3.14159f, 0.301f, 1.618f };
            Sortiraj<float>(realniBrojevi);

            string[] gradovi = { "Amsterdam", "Berlin", "London", "Moskva", "Madrid" };
            Sortiraj<string>(gradovi);

            KompleksniBroj[] kompleksni = { new KompleksniBroj(1, 1), new KompleksniBroj(3, 3), new KompleksniBroj(2, 2) };
            Sortiraj<KompleksniBroj>(kompleksni);
        }

        // primer generičke metode
        static void Zameni<T>(ref T a, ref T b)
        {
            T pom = a;
            a = b;
            b = pom;
        }

        // metoda za sortiranje samo celih brojeva
        static void SortirajCeleBrojeve(int[] niz)
        {
            Console.WriteLine("Niz pre sortiranja: ");
            for (int i = 0; i < niz.Length; i++)
                Console.WriteLine(niz[i]);

            // sortiranje
            for (int i = 0; i < niz.Length - 1; i++)
            {
                int iMax = i;
                for (int j = i + 1; j < niz.Length; j++)
                {
                    if (niz[j] > niz[iMax])
                    {
                        iMax = j;
                    }
                }
                if (iMax != i)
                {
                    Zameni<int>(ref niz[i], ref niz[iMax]);
                    // može i kompajler automatski da utvrdi generički parametar
                    // tj. nije obavezno da pišemo int
                    // Zameni(ref niz[i], ref niz[iMax]);
                }
            }

            Console.WriteLine("Niz posle sortiranja: ");
            for (int i = 0; i < niz.Length; i++)
                Console.WriteLine(niz[i]);

        }

        // metoda za sortiranje samo float brojeva
        static void SortirajRealneBrojeve(float[] niz)
        {
            Console.WriteLine("Niz pre sortiranja: ");
            for (int i = 0; i < niz.Length; i++)
                Console.WriteLine(niz[i]);

            // sortiranje
            for (int i = 0; i < niz.Length - 1; i++)
            {
                int iMax = i;
                for (int j = i + 1; j < niz.Length; j++)
                {
                    if (niz[j] > niz[iMax])
                    {
                        iMax = j;
                    }
                }
                if (iMax != i)
                {
                    Zameni<float>(ref niz[i], ref niz[iMax]);
                }
            }

            Console.WriteLine("Niz posle sortiranja: ");
            for (int i = 0; i < niz.Length; i++)
                Console.WriteLine(niz[i]);

        }

        // metoda za sortiranje objekata generičkog tipa T
        static void Sortiraj<T>(T[] niz) where T : IComparable
        {
            Console.WriteLine("Niz pre sortiranja: ");
            for (int i = 0; i < niz.Length; i++)
                Console.WriteLine(niz[i]);

            // sortiranje
            for (int i = 0; i < niz.Length - 1; i++)
            {
                int iMax = i;
                for (int j = i + 1; j < niz.Length; j++)
                {
                    if (niz[j].CompareTo(niz[iMax]) > 0)
                    // if (niz[j] > niz[iMax]) // ovo bi radilo u C++u ali ne i ovde
                    // kompajler ne dozvoljava primenu operatora > nad objektom tipa 
                    // T jer u fazi kompajliranja ne zna da li je T tip koji 
                    // ima implemetiran operator >
                    // U C#u je rešenje da se koristi where ograničenje i interfejs
                    // IComparable koji nameće da T ima metodu CompareTo
                    // za poređenje 2 objekta. 
                    {
                        iMax = j;
                    }
                }
                if (iMax != i)
                {
                    Zameni<T>(ref niz[i], ref niz[iMax]);
                }
            }

            Console.WriteLine("Niz posle sortiranja: ");
            for (int i = 0; i < niz.Length; i++)
                Console.WriteLine(niz[i]);

        }
    }
}
