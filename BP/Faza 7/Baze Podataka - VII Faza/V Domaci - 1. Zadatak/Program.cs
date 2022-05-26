using System;
using System.Collections.Generic;
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
            string sVeza= "Data Source = 160.99.12.92/GISLAB_PD; User Id = S16995; Password = Gaga2010;";

            try
            {
                Console.WriteLine("Unesite naziv prve discipline:");
                string disc1 = Console.ReadLine();

                Console.WriteLine("Unesite naziv druge discipline:");
                string disc2 = Console.ReadLine();

                veza = new OracleConnection(sVeza);
                veza.Open();

                StringBuilder naredba = new StringBuilder();
                naredba.Append("SELECT UK.Sifra, UK.Ime || ' ' || UK.Srednje_ime || ' ' || UK.Prezime AS Puno_imE ");
                naredba.Append("FROM UCESTVUJE U, UCESNIK UK ");
                naredba.Append("WHERE U.Sifra = UK.Sifra AND U.Naziv_discipline LIKE :PrvaDisciplina ");
                naredba.Append("INTERSECT SELECT UK.Sifra, UK.Ime || ' ' || UK.Srednje_ime || ' ' || UK.Prezime AS Puno_ime ");
                naredba.Append("FROM UCESTVUJE U, UCESNIK UK WHERE U.Sifra = UK.Sifra AND U.Naziv_discipline LIKE :DrugaDisciplina");

                OracleCommand komanda = new OracleCommand(naredba.ToString(), veza);
                komanda.CommandType = System.Data.CommandType.Text;

                OracleParameter parametarDisc1 = new OracleParameter("PrvaDisciplina", OracleDbType.Varchar2);
                OracleParameter parametarDisc2 = new OracleParameter("DrugaDisciplina", OracleDbType.Varchar2);

                parametarDisc1.Value = disc1 + "%";
                parametarDisc2.Value = disc2 + "%";

                komanda.Parameters.Add(parametarDisc1);
                komanda.Parameters.Add(parametarDisc2);

                OracleDataReader dataR = komanda.ExecuteReader();

                if (dataR.HasRows)
                {
                    while (dataR.Read())
                    {
                        string sifra = dataR.GetString(0);
                        string punoIme = dataR.GetString(1);

                        Console.WriteLine(sifra + "\t" + punoIme);
                    }
                }
                else
                {
                    Console.WriteLine("U bazi podataka ne postoji nijedna osoba koja ucestvuje na obe discipline!");
                }

                dataR.Close();
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
