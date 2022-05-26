using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StudentiIOcene;
// Da bismo koristili klasu student iz projekta StudentiIOcene najpre dodajemo 
// referencu na taj projekat 
// (desni klik na tekući projekat -> Add... -> Reference pa biramo projekat StudentiIOcene. 
// Ovde samo uključujemo namespace StudentiIOcene. 
namespace PrimerGeneričkihKlasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = Encoding.Unicode;
            PrimerGenerickaLista();
            PrimerGenerickiDictionary();
        }

        private static void PrimerGenerickaLista()
        {
            List<Student> lista = new List<Student>();
            lista.Add(new Student("Petra", "Petrović", 15000, 88.5f));
            lista.Add(new Student("Jovana", "Jovanović", 15200, 98.0f));
            lista.Add(new Student("Marko", "Marković", 15300, 50.5f));
            lista.Add(new Student("Đorđe", "Đorđević", 15400, 93.0f));

            lista.RemoveAt(2);

            foreach (Student s in lista)
                Console.WriteLine(s.Indeks + " " + s.Ime + " " + s.Prezime + " " + s.Ocena);

            for (int i = 0; i < lista.Count; i++)
                Console.WriteLine(lista[i].Indeks + " " + lista[i].Ime + " " + lista[i].Prezime + " " + lista[i].Ocena);
        }

        private static void PrimerGenerickiDictionary()
        {
            Dictionary<int, Student> hashTablica = new Dictionary<int, Student>();
            hashTablica.Add(15000, new Student("Petra", "Petrović", 15000, 88.5f));
            hashTablica.Add(15200, new Student("Jovana", "Jovanović", 15200, 98.0f));
            hashTablica.Add(15300, new Student("Marko", "Marković", 15300, 50.5f));
            hashTablica.Add(15400, new Student("Đorđe", "Đorđević", 15400, 93.0f));
            //hashTablica.Add(15400, new Student("Đorđe", "Đorđević", 15400, 93.0f));
            hashTablica[15402] = new Student("Đorđe1", "Đorđević1", 15400, 93.0f);

            foreach (Student s in hashTablica.Values)
                Console.WriteLine(s.Indeks + " " + s.Ime + " " + s.Prezime + " " + s.Ocena);

            Student s1 = hashTablica[15000];
            Console.WriteLine(s1.Indeks + " " + s1.Ime + " " + s1.Prezime + " " + s1.Ocena);

            Student s2; //= null;
            if (hashTablica.TryGetValue(15201, out s2))
                Console.WriteLine(s2.Indeks + " " + s2.Ime + " " + s2.Prezime + " " + s2.Ocena);
            else
                Console.WriteLine("Student sa zadatim brojem indeksa ne postoji!");
        }
        
    }
}
