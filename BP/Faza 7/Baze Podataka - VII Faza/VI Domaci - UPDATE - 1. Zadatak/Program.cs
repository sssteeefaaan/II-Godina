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
                Console.WriteLine("Unesite vreme u koje pocinje disciplina (HH:MM):");
                string par1S = Console.ReadLine();

                Console.WriteLine("Unesite sifru ucesnika koji je pogresno unet:");
                string par2S = Console.ReadLine();

                veza = new OracleConnection(sVeza);
                veza.Open();

                //  ZNAM DA OVA KOMANDA IMA PROBLEM, jer Vreme_pocetka nije kljuc tabele DISCIPLINA,
                //  Ali je tako odradjeno kako bi se pokazala funkcionalnost ugnjezdenih upita....
                //  Logika bi bila da biram nesto sto nije kljuc, pa da time setujem, medjutim ovako je ispalo....

                StringBuilder naredba = new StringBuilder();
                naredba.Append("UPDATE UCESTVUJE ");            //  :vreme = '16:45h' i '06:00h'. Menjajte izmedju ove dve vrednosti, kako bi se update-ovala tabela
                naredba.Append("SET Naziv_discipline = (SELECT Naziv_discipline FROM DISCIPLINA WHERE Vreme_pocetka = :vremeOne ), ");
                naredba.Append("Vreme_pocetka = :vremeTwo , ");
                naredba.Append("Redni_broj = (SELECT Count(*) FROM UCESTVUJE WHERE Vreme_pocetka = :vremeThree GROUP BY(Naziv_discipline)) + 1 ");
                naredba.Append("WHERE Sifra = :sifra ");     //  :sifra = 'RS009'

                OracleCommand komanda = new OracleCommand(naredba.ToString(), veza);
                komanda.CommandType = System.Data.CommandType.Text;

                OracleParameter par1 = new OracleParameter("vremeOne", OracleDbType.Varchar2);
                OracleParameter par2 = new OracleParameter("vremeTwo", OracleDbType.Varchar2);
                OracleParameter par3 = new OracleParameter("vremeThree", OracleDbType.Varchar2);
                OracleParameter par4 = new OracleParameter("sifra", OracleDbType.Varchar2);

                par1.Value = (par1S + "h"); //  Pokusao sam sa samo jednim parametrom :vreme, medjutim to nije funkcionisalo, pa postoje tri
                par2.Value = (par1S + "h"); //  Jer se na tri mesta menjaju.... :/
                par3.Value = (par1S + "h"); //  Imao sam dosta nejasnoca i problema sa parametrima, da ne kazem frustracija, tako da se nadam da cete priznati ovakvo resenje
                par4.Value = par2S;

                komanda.Parameters.Add(par1);
                komanda.Parameters.Add(par2);
                komanda.Parameters.Add(par3);
                komanda.Parameters.Add(par4);

                Console.WriteLine(komanda.ExecuteNonQuery() + " rows were affected!");

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
