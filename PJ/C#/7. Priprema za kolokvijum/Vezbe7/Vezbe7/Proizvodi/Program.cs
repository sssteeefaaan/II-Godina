using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proizvodi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Korpa k = new Korpa();
                k.Citanje("ulaz.txt");
                k.Izbaci(Status.UMagacinu);
                k.Upis("izlaz.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
