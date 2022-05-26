using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaObject
{
    class JednostavnaKlasa
    {
        private int vrednost;
        public JednostavnaKlasa(int vrednost)
        {
            this.vrednost = vrednost;
        }

        // Primer kako treba override-ovati Equals metodu. Ovde 
        // dobijamo upozorenje da nedostaje override za GetHashCode metodu 
        // i to će biti objašnjeno u primerima za rad sa klasom Dictionary. 
        public override bool Equals(object obj)
        {
            // Ako je prosleđeni objekat null ili nije tipa JednostavnaKlasa
            // vraćamo false. 
            if (obj == null || !(obj is JednostavnaKlasa))
                return false;
            // U suprotnom konvertujemo obj u tip JednostavnaKlasa i radimo 
            // poređenje atributa klase. 
            JednostavnaKlasa drugiObjekat = (JednostavnaKlasa)obj;
            return this.vrednost == drugiObjekat.vrednost;
        }
    }
}
