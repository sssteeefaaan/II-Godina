using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                UredjenaKolekcija k = new UredjenaKolekcija(100);
                k.Dodaj(new StudentFIB(11111, "Jovan", "Jovanović", 15, 20, 10));
                k.Dodaj(new StudentFIB(22222, "Petra", "Petrović", 15, 15, 8));
                k.Dodaj(new StudentSAF(33333, "Aleksa", "Aleksić", 20, 20));
                k.Dodaj(new StudentSAF(44444, "Mika", "Mikić", 30, 30));

                k.Stampa();
                Console.WriteLine("Opadajući:");
                k.Uredi(Smer.Opadajuci);
                k.Stampa();
                Console.WriteLine("Rastući:");
                k.Uredi(Smer.Rastuci);
                k.Stampa();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
