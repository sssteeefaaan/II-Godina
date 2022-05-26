using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utakmice
{
    class FudbalskaUtakmica : Utakmica
    {
        private int goloviDomacina, goloviGostiju;
        private int iskljucenjaDomacina, iskljucenjaGostiju;

        public FudbalskaUtakmica()
            : base("", "")
        {
        }

        public FudbalskaUtakmica(string domacaEkipa, string gostujucaEkipa, 
            int goloviDomacina, int goloviGostiju, int iskljucenjaDomacina, int iskljucenjaGostiju)
            : base(domacaEkipa, gostujucaEkipa)
        {
            this.goloviDomacina = goloviDomacina;
            this.goloviGostiju = goloviGostiju;
            this.iskljucenjaDomacina = iskljucenjaDomacina;
            this.iskljucenjaGostiju = iskljucenjaGostiju;
        }

        public override void Upis(System.IO.StreamWriter sw)
        {
            base.Upis(sw);
            sw.WriteLine(goloviDomacina);
            sw.WriteLine(goloviGostiju);
            sw.WriteLine(iskljucenjaDomacina);
            sw.WriteLine(iskljucenjaGostiju);
        }

        public override void Citanje(System.IO.StreamReader sr)
        {
            base.Citanje(sr);
            goloviDomacina = int.Parse(sr.ReadLine());
            goloviGostiju = int.Parse(sr.ReadLine());
            iskljucenjaDomacina = int.Parse(sr.ReadLine());
            iskljucenjaGostiju = int.Parse(sr.ReadLine());
        }

        public override Ishod Ishod
        {
            get 
            {
                if (goloviDomacina == goloviGostiju)
                    return Ishod.Nerešeno;
                else if (goloviDomacina > goloviGostiju)
                    return Ishod.PobedaDomacina;
                else
                    return Ishod.PobedaGosta;
            }
        }

        public override int Iskljucenja
        {
            get 
            { 
                return iskljucenjaDomacina + iskljucenjaGostiju; 
            }
        }
    }
}
