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
                Console.WriteLine("Unesite vreme u koje pocinje disciplina (HH:MM):");
                string par1S = Console.ReadLine();

                Console.WriteLine("Unesite sifru ucesnika koji je pogresno unet:");
                string par2S = Console.ReadLine();

                veza = new OracleConnection(sVeza);
                veza.Open();

                string naredba1 = "SELECT * FROM UCESTVUJE";
                string naredba2 = "SELECT * FROM DISCIPLINA";

                OracleDataAdapter dAdapter1 = new OracleDataAdapter(naredba1, veza);
                OracleDataAdapter dAdapter2 = new OracleDataAdapter(naredba2, veza);

                dAdapter1.MissingSchemaAction= MissingSchemaAction.AddWithKey;

                OracleCommandBuilder cb1 = new OracleCommandBuilder(dAdapter1);

                DataSet dSet1 = new DataSet();
                DataSet dSet2 = new DataSet();

                dAdapter1.Fill(dSet1, "UCESTVUJE");
                dAdapter2.Fill(dSet2, "DISCIPLINA");

                veza.Close();

                DataTable dT1 = dSet1.Tables["UCESTVUJE"];
                DataTable dT2 = dSet2.Tables["DISCIPLINA"];

                DataRow[] filtered1 = dT1.Select("Sifra ='" + par2S + "'");
                DataRow[] filtered2 = dT2.Select("Vreme_pocetka ='" + par1S + "h'");

                if (filtered1.Length > 0)
                {
                    if (filtered2.Length > 0)
                    {
                        filtered1[0]["Naziv_discipline"] = filtered2[0]["Naziv_discipline"];
                        filtered1[0]["Vreme_pocetka"] = par1S + "h";
                        filtered1[0]["Redni_broj"] = (dT1.Select("Naziv_discipline = '" + (string)filtered2[0]["Naziv_discipline"] + "' AND Vreme_pocetka ='" + par1S + "h'")).Length + 1;
                    }
                    Console.WriteLine(dAdapter1.Update(dSet1, "UCESTVUJE") + " rows were affected!");
                }
                else
                    Console.WriteLine("Couldn't find that row!");

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
