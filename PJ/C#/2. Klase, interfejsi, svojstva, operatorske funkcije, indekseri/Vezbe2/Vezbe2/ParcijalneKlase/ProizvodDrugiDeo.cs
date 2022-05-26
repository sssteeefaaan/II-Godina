using System; // using direktive su posebne za svaki deo klase

namespace ParcijalneKlase
{
    partial class Proizvod
    {
        private float cena;
        private float kolicina;

        public void Stampaj()
        {
            Console.Write("Proizvod: " + sifra + " " + naziv + " sa cenom: " + cena + " i količinom: " + kolicina);
        }
    }
}
