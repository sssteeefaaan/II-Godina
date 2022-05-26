using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorGenericPrimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Generički VektorEnumerator:");
            IEnumerator<int> enumerator = new VektorEnumerator<int>(4);
            ((VektorEnumerator<int>)enumerator).DodajElement(2);
            ((VektorEnumerator<int>)enumerator).DodajElement(3);
            ((VektorEnumerator<int>)enumerator).DodajElement(5);
            ((VektorEnumerator<int>)enumerator).DodajElement(7);
            // IEnumerator uvek obilazimo ovako
            enumerator.Reset();
            while (enumerator.MoveNext())
                Console.WriteLine(enumerator.Current);

            Console.WriteLine("Generički VektorEnumerable:");
            IEnumerable<int> enumerable = new VektorEnumerable<int>(4);
            ((VektorEnumerable<int>)enumerable).DodajElement(2);
            ((VektorEnumerable<int>)enumerable).DodajElement(3);
            ((VektorEnumerable<int>)enumerable).DodajElement(5);
            ((VektorEnumerable<int>)enumerable).DodajElement(7);
            // IEnumerable uvek obilazimo foreach petljom
            foreach (object o in enumerable)
                Console.WriteLine(o);

            Console.WriteLine("Generički VektorEnumerableYield:");
            IEnumerable<int> enumerable2 = new VektorEnumerableYield<int>(4);
            ((VektorEnumerableYield<int>)enumerable2).DodajElement(2);
            ((VektorEnumerableYield<int>)enumerable2).DodajElement(3);
            ((VektorEnumerableYield<int>)enumerable2).DodajElement(5);
            ((VektorEnumerableYield<int>)enumerable2).DodajElement(7);
            foreach (object o in enumerable2)
                Console.WriteLine(o);

        }
    }
}
