using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proizvodi
{
    interface INaplata
    {
        string Valuta { get; }
        float Cena { get; }
        float Limit { get; }
    }
}
