using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojevi
{
    // Klasa koja implementira kompleksni broj u polarnom obliku
    class PolarniKompleksniBroj : KompleksniBroj
    {
        private float moduo, ugao;

        public PolarniKompleksniBroj(float moduo, float ugao)
        {
            this.moduo = moduo;
            this.ugao = ugao;
        }

        // Implementacija apstraktne metode u izvedenoj klasi mora da ima ključnu reč override u deklaraciji
        // i modifikator pristupa isti kao i apstraktna metoda u osnovnoj klasi
        protected override float Moduo()
        {
            return this.moduo;
        }

        public override void Stampaj()
        {
            Console.Write(moduo + " * exp(j" + ugao + ")");
        }
    }
}
