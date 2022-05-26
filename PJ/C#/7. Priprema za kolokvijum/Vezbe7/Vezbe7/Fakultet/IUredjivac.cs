using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultet
{
    public enum Smer
    {
        Neuredjeno,
        Rastuci,
        Opadajuci
    }

    interface IUredjivac
    {
        void Uredi(Smer uredjenje);
    }
}
