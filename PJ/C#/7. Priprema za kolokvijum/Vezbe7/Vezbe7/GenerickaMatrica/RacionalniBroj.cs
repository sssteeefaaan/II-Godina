using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerickaMatrica
{
    struct RacionalniBroj : IBroj
    {
        private int brojilac, imenilac;

        public RacionalniBroj(int brojilac, int imenilac)
        {
            this.brojilac = brojilac;
            this.imenilac = imenilac;
        }

        //public RacionalniBroj() // nije moguće zadati default konstruktor za strukturu
        //    : this(0, 1)
        //{ }

        public IBroj Inkrement()
        {
            brojilac += imenilac; // (brojilac / imenilac) + 1 = (brojilac + imenilac) / imenilac
            return this;
        }

        public IBroj Saberi(IBroj broj)
        {
            if (broj is RacionalniBroj)
            {
                RacionalniBroj drugiOperand = (RacionalniBroj)broj;
                return new RacionalniBroj(this.brojilac * drugiOperand.imenilac + this.imenilac * drugiOperand.brojilac,
                    this.imenilac * drugiOperand.imenilac); 
                // nije sasvim matematički korektno, ali jednostavnosti radi ne tražimo NZS
            }
            else
            {
                throw new Exception("Racionalni broj se može sabrati samo sa racionalnim brojem!");
            }
        }

        public IBroj Pomnozi(IBroj broj)
        {
            if (broj is RacionalniBroj)
            {
                RacionalniBroj drugiOperand = (RacionalniBroj)broj;
                return new RacionalniBroj(this.brojilac * drugiOperand.brojilac,
                    this.imenilac * drugiOperand.imenilac);
                // ovde bi moglo da se odradi i skraćivanje, ali jednostavnosti radi
                // to preskačemo
            }
            else
            {
                throw new Exception("Racionalni broj se može množiti samo sa racionalnim brojem!");
            }
        }

        public IBroj Nula
        {
            get { return new RacionalniBroj(0, 1); }
        }

        public override string ToString()
        {
            return brojilac + "/" + imenilac;
        }
    }
}
