using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrenosParametara
{
    // Jednostavni referentni tip
    class Klasa
    {
        public int vrednost;

        public Klasa(int vrednost)
        {
            this.vrednost = vrednost;
        }

        public override string ToString()
        {
            return vrednost.ToString();
        }
    }
}
