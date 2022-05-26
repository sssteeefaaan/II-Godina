using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrenosParametara
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            String s = "123";
            Klasa k = new Klasa(123);

            Console.WriteLine("a = " + a + " s = " + s + " k = " + k);
            // izlaz: a = 123 s = 123 k = 123
            
            Metoda(a, s, k);
            Console.WriteLine("a = " + a + " s = " + s + " k = " + k);
            // izlaz: a = 123 s = 123 k = 124
            // objašnjenje u komentarima u samoj funkciji Metoda

            MetodaRef(ref a, ref s, ref k);
            Console.WriteLine("a = " + a + " s = " + s + " k = " + k);
            // izlaz: a = 124 s = 1231 k = 125
            // objašnjenje u komentarima u samoj funkciji MetodaRef

            int b;
            string st;
            Klasa kl;
            MetodaOut(out b, out st, out kl);
            Console.WriteLine("b = " + b + " st = " + st + " kl = " + kl);
            // izlaz: b = 1 st = 1 kl = 1
            // objašnjenje u komentarima u samoj funkciji MetodaOut

            Console.WriteLine(MetodaParam(1, 2, 3, 4, 5));

            int[] n1 = {1, 2, 3};
            int[] n2 = {4, 5};
            Console.WriteLine(MetodaParamMat(n1, n2));
        }

        static void Metoda(int a, String s, Klasa k)
        {
            // int je vrednosni tip pa se a prenosi kao kopija objekta iz pozivajuće funkcije. 
            // Ovo inkrementiranje se neće "videti" u pozivajućoj funkciji. 
            a = a + 1;

            // String je referentni tip, ali su objekti tipa String nepromenjivi. Svaka dodela
            // vrednosti promenljivoj tipa String u stvari kreira novi objekat u dinamičkoj zoni 
            // memorije i postavlja promenljivu da "pokazuje" na taj objekat. 
            // Ovde se radi sa kopijom pokazivača na String iz pozivajuće funkcije. 
            // Naredna linija ne menja pokazivač na String u pozivajućoj funkciji. 
            s = s + "1";

            // Naša Klasa je pravi referentni tip čiju vrednost možemo menjati. Sledeća linija 
            // menja i objekat u pozivajućoj funkciji iako je k u stvari samo kopija pokazivača 
            // na objekat za koji je funkcija pozvana. 
            k.vrednost = k.vrednost + 1;
        }

        static void MetodaRef(ref int a, ref String s, ref Klasa k)
        {
            // Ključna reč ref kaže kompajleru da ne radi sa kopijama vrednosti iz pozivajuće funkcije
            // već sa samim vrednostima iz pozivajuće funkcije. Isto kao i operator & u C++u uz 
            // uz argumente metode. 
            a = a + 1;
            s = s + "1";
            k.vrednost = k.vrednost + 1;
        }

        static void MetodaOut(out int a, out String s, out Klasa k)
        {
            // Ključna reč out ispred argumenta funkcije kaže kompajleru da je ta promenljiva 
            // istovremeno i povratna vrednost funkcije. Na taj način funkcija može imati 
            // više od jedne povratne vrednosti. "Out" promenljivoj se obavezno dodeljuje 
            // vrednost u telu funkcije. 
            a = 1;
            s = "1";
            k = new Klasa(1);
        }

        static int MetodaParam(params int[] niz)
        {
            // Ključna reč params može da stoji samo uz promenljivu tipa niz. Omogućava 
            // nam da funkciju pozovemo sa proizvoljnim brojem argumenata od kojih je svaki 
            // istog tipa kao i pojedinačni elementi niza. 
            int s = 0;
            foreach (int i in niz)
            {
                s += i;
            }
            return s;
        }

        static int MetodaParamMat(params int[][] matrica)
        {
            // Params može da stoji i uz niz nizova. 
            int s = 0;
            foreach (int[] vrsta in matrica)
                foreach (int element in vrsta)
                    s += element;
            return s;
        }
    }
}
