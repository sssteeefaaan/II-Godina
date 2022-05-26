using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utakmice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Turnir t = new Turnir();
                t.Citanje("ulaz.txt");
                t.Izbaci();
                t.Upis("izlaz.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
