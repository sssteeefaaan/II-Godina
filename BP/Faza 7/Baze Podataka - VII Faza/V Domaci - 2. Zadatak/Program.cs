using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Baze
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleConnection veza = null;
            string sVeza = "Data Source = 160.99.12.92/GISLAB_PD; User Id = S16995; Password = Gaga2010;";

            try
            {
                veza = new OracleConnection(sVeza);
                veza.Open();

                StringBuilder naredba = new StringBuilder();
                naredba.Append(" SELECT U.Naziv_discipline, UK.Sifra, UK.Ime || ' ' || UK.Srednje_ime || ' ' || UK.Prezime AS Puno_ime ");
                naredba.Append(" FROM UCESTVUJE U, UCESNIK UK ");
                naredba.Append(" WHERE UK.Sifra = U.Sifra");

                OracleDataAdapter dAdapt = new OracleDataAdapter(naredba.ToString(), veza);

                DataSet dSet = new DataSet();
                dAdapt.Fill(dSet, "Ucensici");

                veza.Close();

                DataTable dTUcesnici = dSet.Tables["Ucensici"];

                Console.WriteLine("Unesite naziv prve i druge discipline:");
                string prvaDisc = Console.ReadLine();
                string drugaDisc = Console.ReadLine();

                //  Bira vrste sa prvom || drugom disciplinom
                DataRow[] fRows = dTUcesnici.Select("Naziv_discipline = '" + prvaDisc + "' OR Naziv_discipline = '" + drugaDisc + "'", "Sifra ASC");

                //  Prolazimo kroz listu, ako se sifra javi dva puta, znaci da ucestvuje na obe discipline, pa je stampamo
                for (int i = 0; i < fRows.Length - 1; i++)
                {
                    string sif = (string)fRows[i]["Sifra"];
                    int j = i + 1;
                    while (j < fRows.Length && sif != (string)fRows[j]["Sifra"])
                        j++;
                    if (sif == (string)fRows[j]["Sifra"])
                        Console.WriteLine((string)fRows[i]["Sifra"] + " " + (string)fRows[i]["Puno_ime"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occurred: " + e.Message);
            }
            finally
            {
                if (veza != null && veza.State == System.Data.ConnectionState.Open)
                    veza.Close();

                veza = null;
            }
        }
    }
}
