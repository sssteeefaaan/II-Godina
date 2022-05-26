using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerickaMatrica
{
    interface IBroj
    {
        IBroj Inkrement();
        IBroj Saberi(IBroj broj);
        IBroj Pomnozi(IBroj broj);
        // Treba nam nulta vrednost kao neutralni element za sabiranje. Treba nam jedna
        // nulta vrednost za celu klasu, ali interfejsom ne možemo da definišemo statičke 
        // članove klasa. 
        IBroj Nula { get; }
    }
}
