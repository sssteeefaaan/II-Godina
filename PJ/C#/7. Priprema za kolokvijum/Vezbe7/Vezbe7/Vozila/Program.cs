using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            try
            {
            //  Ulaz sa tastature (ako se radi ta varijanta zadatka)
            //    Put put = new Put(100, 120, 100);

            //    Console.WriteLine("Izaberite opciju: a-novi automobil, k-novi kamion, bilo koji drugi unos za izlaz. ");
            //    string opcija = Console.ReadLine().ToLower();
            //    while (opcija == "a" || opcija == "k")
            //    {
            //        if (opcija == "a")
            //        {
            //            Console.WriteLine("Unesite naziv automobila:");
            //            string naziv = Console.ReadLine();
            //            Console.WriteLine("Unesite serijski broj automobila:");
            //            int serijskiBroj = Int32.Parse(Console.ReadLine());
            //            Console.WriteLine("Unesite maksimalnu brzinu automobila:");
            //            float maksimalnaBrzina = Single.Parse(Console.ReadLine());
            //            Console.WriteLine("Unesite broj mesta u automobilu:");
            //            int brojMesta = Int32.Parse(Console.ReadLine());
            //            put.DodajVozilo(new Automobil(naziv, serijskiBroj, maksimalnaBrzina, brojMesta));
            //        }
            //        else if (opcija == "k")
            //        {
            //            Console.WriteLine("Unesite naziv kamiona:");
            //            string naziv = Console.ReadLine();
            //            Console.WriteLine("Unesite serijski broj kamiona:");
            //            int serijskiBroj = Int32.Parse(Console.ReadLine());
            //            Console.WriteLine("Unesite maksimalnu brzinu kamiona:");
            //            float maksimalnaBrzina = Single.Parse(Console.ReadLine());
            //            Console.WriteLine("Unesite nosivost kamiona:");
            //            float nosivost = Single.Parse(Console.ReadLine());
            //            put.DodajVozilo(new Kamion(naziv, serijskiBroj, maksimalnaBrzina, nosivost));
            //        }
            //        Console.WriteLine("Izaberite opciju: a-novi automobil, k-novi kamion, bilo koji drugi unos za izlaz. ");
            //        opcija = Console.ReadLine();
            //    }
            
                // Čitanje iz fajla kao druga varijanta za unos
                Put put = new Put();
                put.Ucitaj("PutUlaz.txt");
                put.IzbaciVozilaUPrekršaju(2);
                put.UpozoriVozila(25);
                put.Snimi("PutIzlaz.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
