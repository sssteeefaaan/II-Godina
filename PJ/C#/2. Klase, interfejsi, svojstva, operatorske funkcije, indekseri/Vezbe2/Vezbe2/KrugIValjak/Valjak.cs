using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrugIValjak
{
    // Moguće je samo jednostruko nasleđivanje kao u Javi
    // Ne postoji ključna reč extends za razliku od Jave već se 
    // koristi operator : kao u C++u
    // Ne mogu se dodati modifikatori pristupa kod nasleđivanja za razliku od C++a, 
    // podrazumeva se public nasleđivanje
    class Valjak : Krug
    {
        private float h;

        public Valjak()
        {
            this.h = 0.0f;
        }

        public Valjak(float r, float h)
            : base(r)  // Poziv konstruktora osnovne klase, base ima sličnu ulogu kao super u Javi. 
        {
            this.h = h;
        }

        public float Zapremina()
        {
            return base.Povrsina() * h;
            // Treba nam površina kruga za računanje zapremine valjka, 
            // bez ključne reči base Povrsina() vraća površinu valjka. 
        }

        // Obavezna ključna reč override u metodi izvedene klase. Bez nje kompajler će 
        // ovu metodu posmatrati kao potpuno novu, a ne kao metodu koja virtualno 
        // preklapa metodu osnovne klase. 
        public override float Povrsina()
        {
            return base.Povrsina() * 2 + 2 * r * h * Krug.PI;
        }

    }
}
