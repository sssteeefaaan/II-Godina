using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaracija promenljive tipa enumeracije i dodela vrednosti 
            // toj promenljivoj
            DanUNedelji danas = DanUNedelji.Ponedeljak;
            // Korišćenje promenljive tipa enumeracije
            if (danas != DanUNedelji.Subota && danas != DanUNedelji.Nedelja)
                Console.WriteLine("Danas je radni dan.");

            // Enumeracija se interno predstavlja celobrojnim podatkom. 
            // To nam potvrđuje i konverzija tipa iz narednog primera
            for (int i = 0; i < 7; i++)
                Console.WriteLine((DanUNedelji)i);

            // switch case upravljačka struktura efikasno radi nad enumeracijama
            switch (danas)
            {
                case DanUNedelji.Ponedeljak:
                case DanUNedelji.Utorak:
                case DanUNedelji.Sreda:
                case DanUNedelji.Cetvrtak:
                case DanUNedelji.Petak:
                    Console.WriteLine("Radni dan");
                    break;
                case DanUNedelji.Subota:
                case DanUNedelji.Nedelja:
                    Console.WriteLine("Vikend");
                    break;
            }
        }
    }
}
