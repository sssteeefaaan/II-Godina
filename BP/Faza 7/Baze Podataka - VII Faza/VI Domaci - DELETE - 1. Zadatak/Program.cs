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
            string sVeza = "Data Source = 160.99.12.92/GISLAB_PD; User Id = S16995; Password = Gaga2010;";

            try
            {
                Console.WriteLine("Unesite podatke o ucesniku kog zelite da izbacite sa svih disciplina:");

                Console.WriteLine("Ime:");              //  Kim
                string par1S = Console.ReadLine();

                Console.WriteLine("Srednje ime:");      //  Jong
                string par2S = Console.ReadLine();

                Console.WriteLine("Prezime:");          //  Un
                string par3S = Console.ReadLine();

                veza = new OracleConnection(sVeza);
                veza.Open();

                StringBuilder naredba = new StringBuilder();
                naredba.Append(" DELETE FROM UCESTVUJE ");
                naredba.Append(" WHERE SIFRA = ");
                naredba.Append(" (SELECT Sifra FROM UCESNIK ");
                naredba.Append(" WHERE Ime = :pim AND Srednje_ime = :psim AND Prezime = :ppzm )");

                OracleCommand komanda = new OracleCommand(naredba.ToString(), veza);
                komanda.CommandType = System.Data.CommandType.Text;

                OracleParameter par1 = new OracleParameter("pim", OracleDbType.Varchar2);
                OracleParameter par2 = new OracleParameter("psim", OracleDbType.Varchar2);
                OracleParameter par3 = new OracleParameter("ppzm", OracleDbType.Varchar2);

                komanda.Parameters.Add(par1);
                komanda.Parameters.Add(par2);
                komanda.Parameters.Add(par3);

                par1.Value = par1S;
                par2.Value = par2S;
                par3.Value = par3S;

                Console.WriteLine(komanda.ExecuteNonQuery() + " rows were affected.");
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
