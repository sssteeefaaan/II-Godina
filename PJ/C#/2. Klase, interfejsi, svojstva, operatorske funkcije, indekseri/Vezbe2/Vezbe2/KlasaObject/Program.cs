using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeri poređenja vrednosnih tipova
            int a = 1, b = 1;
            Console.WriteLine("Promenljive vrednosnog tipa int a=" + a + " i b=" + b);
            Console.WriteLine("Operator == radi poređenje po vrednosti pa a == b vraća "
                + (a == b));
            Console.WriteLine("Operator == radi poređenje po vrednosti pa a == a vraća "
                + (a == a));
            Console.WriteLine("Metoda Equals radi poređenje po vrednosti pa a.Equals(b) vraća "
                + a.Equals(b));
            Console.WriteLine("Metoda Equals radi poređenje po vrednosti pa a.Equals(a) vraća "
                + a.Equals(a));
            Console.WriteLine("Statičku metodu ReferenceEquals NE TREBA pozivati nad vrednosnim tipovima!!!");
            Console.WriteLine("Object.ReferenceEquals(a, a) vraća " + Object.ReferenceEquals(a, a));
            Console.WriteLine("Object.ReferenceEquals(a, b) vraća " + Object.ReferenceEquals(a, b));
            Console.WriteLine();

            // Kako radi ToString
            Object obj1 = new Object();
            Console.WriteLine("Default implementacija metode ToString vraća naziv tipa tekućeg objekta:");
            Console.WriteLine("obj1.ToString() vraća " + obj1.ToString());
            Console.WriteLine("obj1.GetType().ToString() vraća " + obj1.GetType().ToString());
            Console.WriteLine();

            // Poređenje instanci klase Object
            Object obj2 = null, obj3 = null;
            Console.WriteLine("Poređenje 2 null objekta:");
            Console.WriteLine("Object.ReferenceEquals(obj2, obj3) vraća " 
                + Object.ReferenceEquals(obj2, obj3));
            Console.WriteLine("Object.Equals(obj2, obj3) vraća "
                + Object.Equals(obj2, obj3));
            Console.WriteLine();

            obj2 = new Object();
            obj3 = new Object();
            Console.WriteLine("Poređenje 2 objekta posle poziva konstruktora:");
            Console.WriteLine("Object.ReferenceEquals(obj2, obj3) vraća "
                + Object.ReferenceEquals(obj2, obj3));
            Console.WriteLine("Object.Equals(obj2, obj3) vraća "
                + Object.Equals(obj2, obj3));
            Console.WriteLine();


            // Poređenje instanci našeg tipa JednostavnaKlasa
            JednostavnaKlasa jk1 = new JednostavnaKlasa(1);
            JednostavnaKlasa jk2 = new JednostavnaKlasa(2);
            Console.WriteLine("Poređenje 2 različite instance tipa JednostavnaKlasa sa različitim vrednostima:");
            Console.WriteLine("Object.ReferenceEquals(jk1, jk2) vraća "
                + Object.ReferenceEquals(jk1, jk2));
            Console.WriteLine("Object.Equals(jk1, jk2) vraća "
                + Object.Equals(jk1, jk2));
            Console.WriteLine();

            Console.WriteLine("Poređenje 2 različite instance tipa JednostavnaKlasa koje imaju iste vrednosti:");
            jk2 = new JednostavnaKlasa(1);
            Console.WriteLine("Object.ReferenceEquals(jk1, jk2) vraća "
                + Object.ReferenceEquals(jk1, jk2));
            Console.WriteLine("Object.Equals(jk1, jk2) vraća "
                + Object.Equals(jk1, jk2));
            Console.WriteLine();

            Console.WriteLine("Poređenje 2 iste instance tipa JednostavnaKlasa posle dodele jk2 = jk1:");
            jk2 = jk1;
            Console.WriteLine("Object.ReferenceEquals(jk1, jk2) vraća "
                + Object.ReferenceEquals(jk1, jk2));
            Console.WriteLine("Object.Equals(jk1, jk2) vraća "
                + Object.Equals(jk1, jk2));
            Console.WriteLine();
        }
    }
}

