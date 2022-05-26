using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiIzuzeci
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Deljenje(3, 0));
            }
            catch (Exception e)
            {
                Console.WriteLine("Izuzetak tipa " + e.GetType() + e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Finally blok se svakako izvršava u slučaju da nam je neophodno oslobađanje nekih resursa");
            }
        }

        private static int Deljenje(int x, int y) // ne postoji ključna reč throws za razliku od Jave
        {
            //if (y == 0)
            //    throw new IzuzetakDeljenjeNulom("Deljenje " + x + "/" + y + " nije moguće.");
            //return x /= y;

            try
            {
                return x /= y;
            }
            catch (DivideByZeroException e)
            {
                throw new IzuzetakDeljenjeNulom("Deljenje " + x + "/" + y + " nije moguće.", e);
            }
        }
    }
}
