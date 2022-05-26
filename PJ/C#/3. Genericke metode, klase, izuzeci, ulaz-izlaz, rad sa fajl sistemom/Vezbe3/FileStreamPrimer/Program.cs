using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            TestWrite();
            TestRead();
        }

        static void TestWrite()
        {
            FileStream fajlZaUpis = null;
            try
            {
                fajlZaUpis = new FileStream("FajlZaStream.txt", FileMode.Create);
                byte[] nizBajtova = null;
                nizBajtova = Encoding.ASCII.GetBytes("test podaci za upis");
                fajlZaUpis.Write(nizBajtova, 0, nizBajtova.Length);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                fajlZaUpis.Close();
            }
        }

        static void TestRead()
        {
            FileStream fajlZaCitanje = null;
            try
            {
                fajlZaCitanje = new FileStream("FajlZaStream.txt", FileMode.Open);
                int velicina = (int)fajlZaCitanje.Length;
                byte[] nizBajtova = new byte[velicina];
                fajlZaCitanje.Read(nizBajtova, 0, velicina);
                Console.WriteLine(Encoding.ASCII.GetString(nizBajtova));
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                fajlZaCitanje.Close();
            }
        }

    }
}
