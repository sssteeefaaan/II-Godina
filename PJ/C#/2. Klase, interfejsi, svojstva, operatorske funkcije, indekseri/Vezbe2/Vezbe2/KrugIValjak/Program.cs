using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrugIValjak
{
    class Program
    {
        static void Main(string[] args)
        {
            Krug k = new Krug(1);
            Valjak v = new Valjak(1, 1);  
            // Ako je promenljiva deklarisana kao tipa Valjak i instancirana kao tipa Valjak 
            // površina se ispravno računa bilo da je metoda Povrsina() virtualna ili ne. 
            // Da bi sledeća linija ispravno radila neophodno je da metoda Povrsina() bude virutalna. 
            // U suprotnom za objekat tipa Valjak pozivala bi se metoda Povrsina() iz klase Krug. 
            // Krug v = new Valjak(1, 1);  
            Console.WriteLine("Površina kruga: " + k.Povrsina());
            Console.WriteLine("Površina valjka: " + v.Povrsina());
        }
    }
}
