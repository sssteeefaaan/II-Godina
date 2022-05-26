using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati
{
    class Program
    {
        // deklaracija delegata
        delegate int AritmetickaOperacija(int n);

        static int broj = 10;
        static event AritmetickaOperacija dogadjaj;

        // metode koje se po potpisu slažu sa delegatom, 
        // u opštem slučaju ne mora da budu statičke
        public static int Dodaj(int sabirak)
        {
            broj += sabirak;
            Console.WriteLine(broj);
            return broj;
        }

        public static int Pomnozi(int mnozilac)
        {
            broj *= mnozilac;
            Console.WriteLine(broj);
            return broj;
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            dogadjaj += Dodaj;
            dogadjaj += Pomnozi;
            dogadjaj += delegate (int x) { return broj / x; };

            if (dogadjaj != null)
                dogadjaj(broj);

            //// kreiranje instanci delegata, tj. dodela metoda delegatima
            //// 1. način - konstruktoru delegata se prosleđuje odgovarajuća metoda
            //AritmetickaOperacija operacija1 = new AritmetickaOperacija(Dodaj);
            //// 2. način - delegatu se direktno dodeljuje metoda
            //// (interno se isto generiše poziv konstruktora kao u načinu 1, 
            //// samo je zapis skraćen)
            //AritmetickaOperacija operacija2 = Pomnozi;
            //// 3. način - delegatu se dodeljuje anonimna metoda
            //AritmetickaOperacija operacija3 = delegate (int x) { return broj /= x; };



            //Console.WriteLine("Vrednost broja pre promena: " + broj);
            //// izvršenje delegata, tj. izvršenje metoda pozivom delegata
            //// ovakva sintaksa interno generiše poziv metode Invoke iz klase Delegate
            //operacija1(25);
            //Console.WriteLine("Vrednost broja posle prve operacije: " + broj);
            //// ravnopravno se za poziv delegata koristi i sledeća sintaksa
            //// tj. eksplicitan poziv metode Invoke iz klase Delegate
            //operacija2.Invoke(5);
            //Console.WriteLine("Vrednost broja posle druge operacije: " + broj);
            //operacija3(25);
            //Console.WriteLine("Vrednost broja posle treće operacije: " + broj);
            //Console.ReadKey();
        }

    }
}
