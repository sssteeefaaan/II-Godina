using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brojevi
{
    // Klasa koja implementira kompleksni broj u obliku Re+jIm
    class DekartovKompleksniBroj : KompleksniBroj 
    {
        private float re, im;

        public DekartovKompleksniBroj(float re, float im)
        {
            this.re = re;
            this.im = im;
        }

        // Implementacija apstraktne metode u izvedenoj klasi mora da ima ključnu reč override u deklaraciji
        // i modifikator pristupa isti kao i apstraktna metoda u osnovnoj klasi
        protected override float Moduo()
        {
            return (float)Math.Sqrt(re * re + im * im);   
        }

        public override void Stampaj()
        {
            Console.Write(re + " + j" + im);
        }
    }
}
