using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            float f = 20.2f;
            double d = 30.33;
            String s = "blabla";

            Console.WriteLine("VektorEnumerator:");
            IEnumerator enumerator = new VektorEnumerator(4);
            ((VektorEnumerator)enumerator).DodajElement(i);
            ((VektorEnumerator)enumerator).DodajElement(f);
            ((VektorEnumerator)enumerator).DodajElement(d);
            ((VektorEnumerator)enumerator).DodajElement(s);
            // IEnumerator uvek obilazimo ovako
            enumerator.Reset();
            while (enumerator.MoveNext())
                Console.WriteLine(enumerator.Current);

            Console.WriteLine("VektorEnumerable:");
            IEnumerable enumerable = new VektorEnumerable(4);
            ((VektorEnumerable)enumerable).DodajElement(i);
            ((VektorEnumerable)enumerable).DodajElement(f);
            ((VektorEnumerable)enumerable).DodajElement(d);
            ((VektorEnumerable)enumerable).DodajElement(s);
            // IEnumerable uvek obilazimo foreach petljom
            foreach (object o in enumerable)
                Console.WriteLine(o);

            Console.WriteLine("VektorEnumerableYield:");
            IEnumerable enumerable2 = new VektorEnumerableYield(4);
            ((VektorEnumerableYield)enumerable2).DodajElement(i);
            ((VektorEnumerableYield)enumerable2).DodajElement(f);
            ((VektorEnumerableYield)enumerable2).DodajElement(d);
            ((VektorEnumerableYield)enumerable2).DodajElement(s);
            foreach (object o in enumerable2)
                Console.WriteLine(o);
        }
    }
}
