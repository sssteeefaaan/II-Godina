using System;
using System.Collections.Generic;
using System.Data;
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

                Console.Write("Ime:");              //  Kim
                string par1S = Console.ReadLine();

                Console.Write("Srednje ime:");      //  Jong
                string par2S = Console.ReadLine();

                Console.Write("Prezime:");          //  Un
                string par3S = Console.ReadLine();

                veza = new OracleConnection(sVeza);
                veza.Open();

                string naredbaGlavna = "SELECT * FROM UCESTVUJE";
                string naredbaSporedna = "SELECT Sifra, Ime, Srednje_ime, Prezime FROM UCESNIK";

                OracleDataAdapter dAdapterGlavni = new OracleDataAdapter(naredbaGlavna, veza);
                OracleDataAdapter dAdapterSporedni = new OracleDataAdapter(naredbaSporedna, veza);

                dAdapterGlavni.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                OracleCommandBuilder builderGlavni = new OracleCommandBuilder(dAdapterGlavni);

                DataSet dSetU = new DataSet();
                DataSet dSetUK = new DataSet();

                dAdapterGlavni.Fill(dSetU, "Ucestvuje");
                dAdapterSporedni.Fill(dSetUK, "Ucesnik");

                veza.Close();

                DataTable dTUcestvuje = dSetU.Tables["Ucestvuje"];
                DataTable dTUcesnik = dSetUK.Tables["Ucesnik"];

                DataRow[] filtered = dTUcesnik.Select("Ime = '" + par1S + "' AND Srednje_ime = '" + par2S + "' AND Prezime = '" + par3S + "'");
                if (filtered.Length > 0)
                {
                    string sifra = (string)filtered[0]["Sifra"];

                    Console.WriteLine(sifra);

                    foreach (DataRow r in dTUcestvuje.Rows)
                    {
                        if ((string)r["Sifra"] == sifra)
                            r.Delete();
                    }

                    Console.WriteLine(dAdapterGlavni.Update(dSetU, "Ucestvuje") + " rows were affected");
                }
                else
                    Console.WriteLine("Couldn't find the specified row!");
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
