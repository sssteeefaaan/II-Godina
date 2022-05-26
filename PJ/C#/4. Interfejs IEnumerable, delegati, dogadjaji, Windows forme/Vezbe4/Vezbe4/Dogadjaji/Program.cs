using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji
{
    class Program
    {
        static void Main(string[] args)
        {
            ProizvodjacDogadjaja proizvodjac = new ProizvodjacDogadjaja(5);
            // menja se vrednost broja dok događaj nema nijedan osluškivač
            proizvodjac.Broj = 7;

            // proizvođaču se dodeljuju dve metode potrošača događaja
            PotrosacDogadjaja potrosac = new PotrosacDogadjaja();
            proizvodjac.PromenaBroja += 
                new ProizvodjacDogadjaja.ObradaPromeneBroja(potrosac.ObradaDogadjaja);
            Potrosac2 p2 = new Potrosac2();
            proizvodjac.PromenaBroja += 
                new ProizvodjacDogadjaja.ObradaPromeneBroja(p2.Metoda);
 
            // nova promena broja poziva oba potrošača događaja
            proizvodjac.Broj = 9;
        }
    }
}
