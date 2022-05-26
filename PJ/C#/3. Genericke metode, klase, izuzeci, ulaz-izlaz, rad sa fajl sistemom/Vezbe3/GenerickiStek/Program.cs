using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerickiStek
{
    class Program
    {
        static void Main(string[] args)
        {
            Stek<int> s = new Stek<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);

            while (s.ImaElemenata())
            {
                Console.WriteLine(s.Pop());
            }
            Console.WriteLine(s.Pop());

            //Stek<String> ss = new Stek<String>();
            //ss.Push("1");
            //ss.Push("2");
            //ss.Push("3");
            //ss.Push("4");

            //while (ss.ImaElemenata())
            //{
            //    Console.WriteLine(ss.Pop());
            //}
            //if (ss.Pop() == null)
            //    Console.WriteLine("Null je default vrednost za string");

        }   
    }
}
