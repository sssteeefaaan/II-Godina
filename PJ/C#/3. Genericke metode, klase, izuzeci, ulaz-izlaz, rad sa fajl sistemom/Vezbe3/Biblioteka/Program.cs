using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteka bib = new Biblioteka();

            Knjiga k1 = new Knjiga("Computer Networks");
            k1.Autori.Add(new Autor("Andrew", "Tanenbaum"));
            k1.Autori.Add(new Autor("David", "Wetherall"));

            Knjiga k2 = new Knjiga("Operating Systems: Design and Implementation");
            k2.Autori.Add(new Autor("Andrew", "Tanenbaum"));
            k2.Autori.Add(new Autor("Albert", "Woodhull"));

            Knjiga k3 = new Knjiga("Structured Computer Organization");
            k3.Autori.Add(new Autor("Andrew", "Tanenbaum"));

            bib.DodajKnjigu(k1);
            bib.DodajKnjigu(k2);
            bib.DodajKnjigu(k3);

            List<Knjiga> knjigeTanenbauma = bib.PronadjiKnjigeAutora(new Autor("Andrew", "Tanenbaum"));
            foreach (Knjiga k in knjigeTanenbauma)
                Console.WriteLine(k);

            List<Knjiga> knjigeEckela = bib.PronadjiKnjigeAutora(new Autor("Bruce", "Eckel"));
            foreach (Knjiga k in knjigeEckela)
                Console.WriteLine(k);
        }
    }
}
