using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proizvodi
{
    public enum Status
    {
        UProdavnici, 
        UMagacinu,
        Narucen
    }

    abstract class Proizvod
    {
        private String naziv;
        private int sifra;
        private Status status;
        
        public abstract float Cena
        {
            get;
        }

        public Status Status
        {
            get
            {
                return this.status;
            }
        }

        public Proizvod()
        {
        }

        public Proizvod(String naziv, int sifra, Status status)
        {
            this.naziv = naziv;
            this.sifra = sifra;
            this.status = status;
        }

        public virtual void Upis(StreamWriter sw)
        {
            sw.WriteLine(this.naziv);
            sw.WriteLine(this.sifra);
            sw.WriteLine((int)this.status);
        }

        public virtual void Citanje(StreamReader sr)
        {
            this.naziv = sr.ReadLine();
            this.sifra = int.Parse(sr.ReadLine());
            this.status = (Status)int.Parse(sr.ReadLine());
        }
    }
}
