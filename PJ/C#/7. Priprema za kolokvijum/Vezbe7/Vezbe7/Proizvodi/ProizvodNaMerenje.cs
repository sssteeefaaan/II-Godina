using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proizvodi
{
    class ProizvodNaMerenje : Proizvod
    {
        private float masaUKg;
        private float cenaPoKg;

        public ProizvodNaMerenje()
        {
        }

        public ProizvodNaMerenje(String naziv, int sifra, Status status,
            float masaUKg, float cenaPoKg)
            : base(naziv, sifra, status)
        {
            this.masaUKg = masaUKg;
            this.cenaPoKg = cenaPoKg;
        }

        public override float Cena
        {
            get { return this.masaUKg * this.cenaPoKg; }
        }

        public override void Upis(System.IO.StreamWriter sw)
        {
            base.Upis(sw);
            sw.WriteLine(this.masaUKg);
            sw.WriteLine(this.cenaPoKg);
        }

        public override void Citanje(System.IO.StreamReader sr)
        {
            base.Citanje(sr);
            this.masaUKg = float.Parse(sr.ReadLine());
            this.cenaPoKg = float.Parse(sr.ReadLine());
        }

    }
}
