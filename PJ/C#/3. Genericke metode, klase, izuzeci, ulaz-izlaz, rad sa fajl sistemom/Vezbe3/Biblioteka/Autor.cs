using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Autor
    {
        private String ime;
        private String prezime;

        public Autor(String ime, String prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }

        public override string ToString()
        {
            return ime + " " + prezime;
        }

        public override int GetHashCode()
        {
            return (ime + prezime).GetHashCode();
            // return ToString().GetHashCode();
            // return ime.GetHashCode() * 59 + prezime.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Autor drugi = obj as Autor;
            if (drugi == null)
                return false;
            else 
                return this.ime == drugi.ime && this.prezime == drugi.prezime;
        }
    }
}
