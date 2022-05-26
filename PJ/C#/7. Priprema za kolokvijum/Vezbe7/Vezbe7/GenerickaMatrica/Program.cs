using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerickaMatrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrica<KompleksniBroj> kompMatrica = new Matrica<KompleksniBroj>(2, 3);
            Console.WriteLine("Matrica sa default vrednostima:");
            kompMatrica.Stampa();
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    kompMatrica[i, j] = new KompleksniBroj(i + 1, j + 1);
                }
            }
            Console.WriteLine("Inicijalizovana matrica:");
            kompMatrica.Stampa();
            Console.WriteLine();

            Console.WriteLine("Postfiksno inkrementriranje i štampa u istoj naredbi:");
            (kompMatrica++).Stampa();
            Console.WriteLine();

            Console.WriteLine("Štampa iste matrice - tek sada se vide rezultati inkrementiranja:");
            kompMatrica.Stampa();
            Console.WriteLine();
            
            Matrica<KompleksniBroj> zbir = kompMatrica + kompMatrica;
            
            Console.WriteLine("Zbir matrice sa samom sobom: ");
            zbir.Stampa();
        }
    }
}
