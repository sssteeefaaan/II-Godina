using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izuzeci
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DeljenjeNulom();
            }

            catch (DivideByZeroException e)
            {
                //Console.WriteLine("Izuzetak tipa DivideByZeroException " + e.Message);
                Console.WriteLine(e.StackTrace);
                // možemo da štampamo samo poruku e.Message ili ceo stek poziva funkcije e.StackTrace
                // StackTrace nam daje mnogo više informacija
                // throw; // throw bez argumenta baca isti izuzetak koji je "uhvaćen" u bloku
            }

            catch (ArithmeticException e)
            {
                Console.WriteLine("Izuzetak tipa ArithmeticException " + e.Message);
            }

            catch (Exception e)
            //catch (Exception) // i ove dve mogućnosti su sintaksno ispravne u slučaju kada 
            //catch             // nam nije neophodna promenljiva e za dalju obradu  
            {
                Console.WriteLine("Izuzetak tipa Exception " + e.StackTrace);
                //Console.WriteLine("Izuzetak tipa Exception");
            }
            finally
            {
                Console.WriteLine("Finally blok se svakako izvršava u slučaju da nam je neophodno oslobađanje nekih resursa");
            }
        }

        private static void DeljenjeNulom() // ne postoji ključna reč throws za razliku od Jave
        {
            int x = 5, y = 0;
            x /= y;
        }
    }
}
