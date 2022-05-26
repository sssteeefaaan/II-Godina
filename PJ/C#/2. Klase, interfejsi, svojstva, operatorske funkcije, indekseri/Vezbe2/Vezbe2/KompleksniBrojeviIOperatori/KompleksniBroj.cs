using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompleksniBrojeviIOperatori
{
    class KompleksniBroj
    {
        public float re;
        public float im;

        public KompleksniBroj(float re, float im)
        {
            this.re = re;
            this.im = im;
        }

        public void Stampaj()
        {
            Console.WriteLine(re + " + j" + im);
        }

        // Slično kao u Javi predefinišemo metodu ToString za prikaz ovog objekta
        // Razlika je to što je slovo "T" veliko i što je obavezna ključna reč
        // "override". 
        public override string ToString()
        {
            return re + " + j" + im;
        }

        public float Moduo
        {
            get
            {
                return (float)Math.Sqrt(this.re * this.re + this.im * this.im);
            }
        }

        // Statička metoda za definisanje binarnog operatora ima 2 argumenta
        public static KompleksniBroj operator +(KompleksniBroj k1, KompleksniBroj k2)
        {
            return new KompleksniBroj(k1.re + k2.re, k1.im + k2.im);
        }

        // Statička metoda za definisanje unarnog operatora ima 1 argument. Ista metoda 
        // izvršiće se i prilikom prefiksnog i prilikom postfiksnog poziva operatora. 
        // Zbog toga metoda NE SME da menja objekat za koji je pozvana, već mora da kreira novi 
        // objekat koji vraća. 
        public static KompleksniBroj operator ++(KompleksniBroj k)
        {
            return new KompleksniBroj(k.re + 1, k.im + 1);
        } 

        // Par operatora == i != . Ako se predefiniše jedan od njih, a ne i drugi
        // kompajler će prijaviti grešku. 
        public static bool operator ==(KompleksniBroj k1, KompleksniBroj k2)
        {
            return k1.re == k2.re && k1.im == k2.im;
        }
        public static bool operator !=(KompleksniBroj k1, KompleksniBroj k2)
        {
            // Dve moguće implementacije operatora != kada već imamo operator ==
            return k1.re != k2.re || k1.im != k2.im;
            //return !(k1 == k2); 
        }

        // Par operatora < i > . Ako se predefiniše jedan od njih, a ne i drugi
        // kompajler će prijaviti grešku. 
        public static bool operator <(KompleksniBroj k1, KompleksniBroj k2)
        {
            return k1.Moduo < k2.Moduo;
        }
        public static bool operator >(KompleksniBroj k1, KompleksniBroj k2)
        {
            return k1.Moduo > k2.Moduo;
        }

        // Par operatora <= i >= . Ako se predefiniše jedan od njih, a ne i drugi
        // kompajler će prijaviti grešku. 
        public static bool operator <=(KompleksniBroj k1, KompleksniBroj k2)
        {
            // Dve moguće implementacije operatora <= kada već imamo operator >
            return k1.Moduo <= k2.Moduo;
            //return !(k1 > k2);
        }
        public static bool operator >=(KompleksniBroj k1, KompleksniBroj k2)
        {
            // Dve moguće implementacije operatora >= kada već imamo operator <
            return k1.Moduo >= k2.Moduo;
            //return !(k1 < k2);
        }
  
        // Operator za implicitnu konverziju tipa. Njegov poziv može da izgleda ovako:
        // float a = 5.5f;
        // KompleksniBroj k = a;
        // Konverzija ima smisla da bude implicitna ako se prilikom konverzije ne gube podaci
        // kao kod npr. implicitne konverzije iz nižeg u viši numerički tip:
        // double d = 6;
        public static implicit operator KompleksniBroj(float realniBroj)
        {
            // U matematici svaki realni broj istovremeno pripada i nadskupu kompleksnih brojeva
            // pa ga konvertujemo u kompleksni broj čiji je imaginarni deo 0.
            KompleksniBroj k = new KompleksniBroj(realniBroj, 0);
            Console.WriteLine("Implicitna konverzija tipa float u KompleksniBroj");
            return k;
        }

        // Operator za eksplicitnu konverziju tipa. Njegov poziv može da izgleda ovako:
        // KompleksniBroj k = new KompleksniBroj(3.8f, 9.5f);
        // float a = (float)k;
        // Konverzija ima smisla da bude eksplicitna ako se prilikom konverzije gube podaci
        // pa kompajler očekuje eksplicitnu potvrdu od programera da se programer slaže sa 
        // mogućim gubitkom. 
        // Npr. eksplicitna konverzije iz višeg u niži numerički tip:
        // int i = (int)3.14159;
        public static explicit operator float(KompleksniBroj kompleksniBroj)
        {
            // Realni podatak ne može da sadrži kompletnu informaciju o kompleksnom 
            // broju pa jednostavno odbacujemo imaginarni deo i vraćamo samo realni. 
            Console.WriteLine("Explicitna konverzija tipa KompleksniBroj u float");
            return kompleksniBroj.re;
        }
    }

}
