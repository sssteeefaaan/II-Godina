using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrugIValjak
{
    class Krug
    {
        protected float r;
        
        //public static float PI = 3.14159f;
        // Mogli smo da koristimo static promenljivu. Static promenljivoj je moguće 
        // dodeliti vrednost bilo gde u programu. Zato je pravilinije u ovom primeru 
        // koristiti konstantu (nema smisla da se matematička konstanta ikada menja) 
        // ili readonly promenljivu. 
        // Van klase Krug pristupa joj se sa Krug.PI, u samoj klasi sa Krug.PI ili samo PI. 

        public static readonly float PI = 3.14159f;
        // Ako dodamo readonly modifikator uz atribut zabranićemo promenu vrednosti 
        // tog atributa. Readonly atributu mora da se dodeli vrednost jednom (kao ovde 
        // pri deklaraciji ili u konstruktoru) i ne može više nikada da se promeni. 
        // Sintaksa za pristup je ista kao i u prethodnom slučaju (jer je i ova 
        // promenljiva static) - van klase Krug pristupa joj se sa Krug.PI, u samoj 
        // klasi sa Krug.PI ili samo PI. 
        // Readonly atribut može da se deklariše i kao non-static.  

        //public const float PI = 3.14159f;
        // Konstanta klase. Mora se inicijalizovati ovde, u okviru deklaracije. 
        // Ni na jednom drugom mestu u kodu ne može joj se dodeliti vrednost. 
        // Sintaksa za pristup je ista kao i u prethodnom slučaju - van klase Krug 
        // pristupa joj se sa Krug.PI, u samoj klasi sa Krug.PI ili samo PI. 
        // Razlika između "static readonly" i "const":
        // -"static readonly" je promenljiva smeštena u nekoj memorijskoj lokaciji 
        // čija vrednost se uzima i koristi u toku izvršenja programa;
        // -"const" je konstanta čije simboličko ime se već u fazi kompajliranja
        // menja direktno vrednošću te konstante. 


        public Krug(float r)
        {
            this.r = r;
        }

        public Krug()
            : this(0.0f) // Poziv drugog konstruktora tekuće klase. 
        {
        }

        public virtual float Povrsina()
        {
            return r * r * Krug.PI;
        }
    }
}
