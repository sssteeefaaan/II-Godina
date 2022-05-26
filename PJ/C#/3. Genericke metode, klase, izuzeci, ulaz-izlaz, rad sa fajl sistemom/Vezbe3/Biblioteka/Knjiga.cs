using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Knjiga
    {
        private String naslov;
        private List<Autor> autori;

        public Knjiga(String naslov, List<Autor> autori)
        {
            this.naslov = naslov;
            this.autori = autori;
        }

        public Knjiga(String naslov)
            :this(naslov, new List<Autor>())
        {
        }

        public String Naslov
        {
            get { return this.naslov; }
        }

        public List<Autor> Autori
        {
            get { return this.autori; }
        }

        public override string ToString()
        {
            String rezultat =  "\"" + naslov + "\"";
            foreach (Autor a in autori)
                rezultat += (" ," + a);
            return rezultat;
        }
    }
}
