using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            TestWriteUsing();
            TestReadUsing();
        }

        static void TestWriteUsing()
        {
            using (FileStream fajlZaUpis = new FileStream("FajlZaStream.txt", FileMode.Create))
            {
                byte[] nizBajtova = null;
                nizBajtova = Encoding.ASCII.GetBytes("test podaci za upis");
                fajlZaUpis.Write(nizBajtova, 0, nizBajtova.Length);
            }
        }

        static void TestReadUsing()
        {
            using (FileStream fajlZaCitanje = new FileStream("FajlZaStream.txt", FileMode.Open))
            {
                int velicina = (int)fajlZaCitanje.Length;
                byte[] nizBajtova = new byte[velicina];
                fajlZaCitanje.Read(nizBajtova, 0, velicina);
                Console.WriteLine(Encoding.ASCII.GetString(nizBajtova));
            }
        }
    }
}
