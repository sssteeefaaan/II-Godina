using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utakmice
{
    public enum Ishod
    {
        PobedaDomacina, 
        Nerešeno, 
        PobedaGosta
    }
    abstract class Utakmica
    {
        private string domacaEkipa, gostujucaEkipa;
        
        public abstract Ishod Ishod { get; }
        public abstract int Iskljucenja { get; }

        public Utakmica(string domacaEkipa, string gostujucaEkipa)
        {
            this.domacaEkipa = domacaEkipa;
            this.gostujucaEkipa = gostujucaEkipa;
        }

        public virtual void Upis(StreamWriter sw)
        {
            sw.WriteLine(this.domacaEkipa);
            sw.WriteLine(this.gostujucaEkipa);
        }
        
        public virtual void Citanje(StreamReader sr)
        {
            this.domacaEkipa = sr.ReadLine();
            this.gostujucaEkipa = sr.ReadLine();
        }
    }
}
