using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerickiStek
{
    public class Stek<T> //where T : class//new()
    {
        readonly int velicina; 
        // Ključna reč readonly označava da vrednost promenljive može da se dodeli 
        // u deklaraciji ili u konstruktoru. Ne može se dodeliti ni u 
        // jednoj drugoj metodi. 
        int vrhSteka = 0;
        T[] elementi;
        public Stek()
            : this(100)
        { }
        public Stek(int velicina)
        {
            this.velicina = velicina;
            elementi = new T[velicina];
        }
        public void Push(T element)
        {
            if (vrhSteka >= velicina)
                Console.WriteLine("Stek je pun");
            else
            {
                elementi[vrhSteka] = element;
                vrhSteka++;
            }
        }

        public bool ImaElemenata()
        {
            return vrhSteka > 0;
        }
        public T Pop()
        {
            vrhSteka--;
            if (vrhSteka >= 0)
            {
                return elementi[vrhSteka];
            }
            else
            {
                vrhSteka = 0;
                Console.WriteLine("Stek je prazan");
                return default(T); 
                // vrati default vrednost za tip T, za referentni tip vraća null
                // za numeričke tipove vraća 0

                //return new T(); // Da bi ovo radilo mora u ograničenju za generički tip 
                                  // da stoji :new() kao znak da tip T ima podrazumevani konstruktor. 
                                  // Ovakvo ograničenje postoji samo za default konstruktor, a ne i 
                                  // za konstruktore sa argumentima. 

                //return null;  // Da bi ovo radilo mora u ograničenju za generički tip 
                                // da stoji class kao znak da je tip T referentni. 
                                // Slično ograničenje postoji i ako želimo da tip T
                                // bude vrednosni - tada se koristi ključna reč struct. 
            }
        }
    }
}
