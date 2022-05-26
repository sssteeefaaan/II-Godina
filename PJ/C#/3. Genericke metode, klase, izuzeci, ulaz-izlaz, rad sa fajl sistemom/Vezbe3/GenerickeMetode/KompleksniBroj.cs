using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerickeMetode
{
    class KompleksniBroj : IComparable
    {
        private float re, im;

        public KompleksniBroj(float re, float im)
        {
            this.re = re;
            this.im = im;
        }

        public float Moduo
        {
            get { return (float)Math.Sqrt(re * re + im * im); }   
        }

        public override string ToString()
        {
            return re + " + j" + im;
        }


        public int CompareTo(object obj)
        {
            KompleksniBroj drugi = obj as KompleksniBroj;
            if (drugi == null)
                throw new ArgumentException("Argument mora biti kompleksni broj i različit od null");
            int rezultat;
            if (this.Moduo == drugi.Moduo)
                rezultat = 0;
            else if (this.Moduo > drugi.Moduo)
                rezultat = 1;
            else
                rezultat = -1;
            return rezultat;
        }
    }

}
