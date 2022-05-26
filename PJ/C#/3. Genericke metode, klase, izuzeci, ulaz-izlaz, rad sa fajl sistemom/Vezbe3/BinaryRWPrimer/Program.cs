using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryRWPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "Neki tekst";

            // kreiranje i upis u fajl
            try
            {
                using (BinaryWriter bw = new BinaryWriter(new FileStream("podaci.bin", FileMode.Create)))
                {
                    bw.Write(i);
                    bw.Write(d);
                    bw.Write(b);
                    bw.Write(s);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // čitanje iz fajla
            // moglo je i ovde da se radi sa using blokom, iskorišćen je try-catch-finally poređenja radi
            BinaryReader br = null;
            try
            {
                br = new BinaryReader(new FileStream("podaci.bin", FileMode.Open));
            
                // čitaju se podaci u istom redosledu kako smo ih i upisivali
                i = br.ReadInt32();
                Console.WriteLine("Int podatak: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double podatak: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Bool podatak: {0}", b);
                s = br.ReadString();
                Console.WriteLine("String podatak: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Čitanje iz fajla nije uspelo.");
                return;
            }
            finally
            {
                br.Close();
            }

            Console.ReadKey();
        }
    }
}
