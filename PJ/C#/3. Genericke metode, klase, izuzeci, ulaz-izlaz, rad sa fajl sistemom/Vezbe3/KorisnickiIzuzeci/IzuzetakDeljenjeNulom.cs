using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiIzuzeci
{
    class IzuzetakDeljenjeNulom : Exception
    {
        public IzuzetakDeljenjeNulom()
        { 
        }

        public IzuzetakDeljenjeNulom(String message)
            : base(message)
        {
        }

        public IzuzetakDeljenjeNulom(String message, Exception inner)
            : base(message, inner)
        {
            // klasa Exception ima property InnerException pa preko njega možemo da 
            // "ulančavamo" izuzetke bačene sa različitih mesta
        }

    }
}
