using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerickaMatrica
{
    struct KompleksniBroj : IBroj
    {
        private double realni, imaginarni;

        public KompleksniBroj(double realni, double imaginarni)
        {
            this.realni = realni;
            this.imaginarni = imaginarni;
        }

        //public KompleksniBroj() // nije moguće zadati default konstruktor za strukturu
        //    : this(0, 0)
        //{
        //}



        public IBroj Inkrement()
        {
            realni++;
            imaginarni++;
            return this;
        }

        public IBroj Saberi(IBroj broj)
        {
            if (broj is KompleksniBroj)
            {
                KompleksniBroj drugiOperand = (KompleksniBroj)broj;
                return new KompleksniBroj(this.realni + drugiOperand.realni,
                    this.imaginarni + drugiOperand.imaginarni);
            }
            else
            {
                throw new Exception("Kompleksni broj se može sabrati samo sa kompleksnim brojem!");
            }
        }

        public IBroj Pomnozi(IBroj broj)
        {
            if (broj is KompleksniBroj)
            {
                KompleksniBroj drugiOperand = (KompleksniBroj)broj;
                return new KompleksniBroj(this.realni * drugiOperand.realni - this.imaginarni * drugiOperand.imaginarni,
                    this.imaginarni * drugiOperand.realni + this.realni * drugiOperand.imaginarni);
            }
            else
            {
                throw new Exception("Kompleksni broj se može množiti samo sa kompleksnim brojem!");
            }
        }


        public IBroj Nula
        {
            get { return new KompleksniBroj(0, 0); }
        }

        public override string ToString()
        {
            return realni + " + j" + imaginarni;
        }
    }
}
