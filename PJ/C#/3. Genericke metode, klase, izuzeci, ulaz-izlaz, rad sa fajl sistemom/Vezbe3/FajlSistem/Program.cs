
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FajlSistem
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo mydir = new DirectoryInfo(@"..\..\..\GenerickiStek"); 
            // relativna putanja do direktorijuma koji pretražujemo

            FileInfo[] f = mydir.GetFiles("*.cs");
            // Directory.GetFiles(@"..\..\..\GenerickiStek", "*.cs"); 
            // umesto DirectoryInfo može da se koristi i statička klasa Directory
            if (!Directory.Exists(@"C:\Test"))
                Directory.CreateDirectory(@"C:\Test");
            foreach (FileInfo file in f)
            {
                Console.WriteLine("Naziv fajla: " + file.Name + " Veličina: " + file.Length);
                file.CopyTo(@"C:\Test\" + file.Name, true);
            }
        }
    }
}
