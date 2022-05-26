using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligoni
{
    // Za jednostavne objekte kao što je tačka u 2D prostoru može se koristiti 
    // i struktura umesto klase
    struct Tacka
    {
        private double x, y; // koordinate tačke u 2D prostoru

        // Strukture mogu da imaju svojstva (properties), potpuno isto kao i klase. 
        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        // Preklopljena metoda iz osnovne klase Object. Preklapanje ove metode 
        // obezbeđuje kasnije pregledniji prikaz tj. izvršiće se tamo gde od objekta 
        // klase Tacka tražimo odgovarajući string za predstavlje te tačke.         
        public override string ToString()
        {
            return "X:" + x + " Y:" + y;
        }
    }
}
