using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecnikSinonima
{
    public partial class Form1 : Form
    {
        // Za jednu reč na engleskom moguće je zadati više reči na srpskom kao prevod (primer
        // table => sto, tabela). Zato engleske reči koristimo kao ključeve u Dictionary 
        // klasi, a srpske reči predstavljaju value u Dictionary klasi i čuvaju se u listi. 
        Dictionary<string, List<string>> recnik = new Dictionary<string, List<string>>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajEngleski_Click(object sender, EventArgs e)
        {
            // provera da nije prazan TextBox
            if (txtRecNaEngleskom.Text != "")
            {
                if (!recnik.ContainsKey(txtRecNaEngleskom.Text))
                {
                    // Ako rečnik već ne sadrži englesku reč dodaje se ta reč kao key, 
                    // a value je nova lista koja će čuvati srpske reči. 
                    recnik.Add(txtRecNaEngleskom.Text, new List<string>());
                    // Osvežavanje prikaza u ListBox kontroli sa engleskim rečima. 
                    lbxRecNaEngleskom.Items.Clear();
                    lbxRecNaEngleskom.Items.AddRange(recnik.Keys.ToArray());
                    // Briše se sadržaj TextBox-a koji čuva reči na engleskom. 
                    txtRecNaEngleskom.Text = "";
                }
                else
                {
                    MessageBox.Show("Reč " + txtRecNaEngleskom.Text + " već postoji!");
                }
            }
        }

        private void lbxRecNaEngleskom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selektovanaRec = (string)lbxRecNaEngleskom.SelectedItem;
            if (selektovanaRec != null && recnik.ContainsKey(selektovanaRec))
            {
                // Kad se promeni selektovana stavka u listi engleskih reči
                // treba osvežiti prikaz prevoda za tu reč u listi srpskih reči. 
                lbxRecNaSrpskom.Items.Clear();
                lbxRecNaSrpskom.Items.AddRange(recnik[selektovanaRec].ToArray());
            }
        }

        private void btnDodajSrpski_Click(object sender, EventArgs e)
        {
            string selektovanaRec = (string)lbxRecNaEngleskom.SelectedItem;
            if (selektovanaRec != null)
            {
                if (recnik.ContainsKey(selektovanaRec) && txtRecNaSrpskom.Text != "")
                {
                    // recnik[selektovanaRec] vraća vrednost za ključ selektovanaRec
                    // u klasi Dictionary. Ta vrednost je u stvari tipa List<T> pa 
                    // možemo da koristimo Add metodu da dodamo novu reč u tu listu. 
                    recnik[selektovanaRec].Add(txtRecNaSrpskom.Text);
                    // Kad se doda nova stavka u listu srpskih reči
                    // treba osvežiti prikaz liste srpskih reči.  
                    lbxRecNaSrpskom.Items.Clear();
                    lbxRecNaSrpskom.Items.AddRange(recnik[selektovanaRec].ToArray());
                    // Briše se sadržaj TextBox-a koji čuva reči na engleskom. 
                    txtRecNaSrpskom.Text = "";
                }
            }
            else
                MessageBox.Show("Nije selektovana engleska reč za koju se dodaje prevod!");
        }

        private void txtRecNaEngleskom_KeyDown(object sender, KeyEventArgs e)
        {
            // Osim klikom na dugme, engleska reč se može dodati i pritiskom na 
            // taster Enter. 
            if (e.KeyCode == Keys.Enter)
                btnDodajEngleski_Click(sender, e);
        }

        private void txtRecNaSrpskom_KeyDown(object sender, KeyEventArgs e)
        {
            // Osim klikom na dugme, srpska reč se može dodati i pritiskom na 
            // taster Enter. 
            if (e.KeyCode == Keys.Enter)
                btnDodajSrpski_Click(sender, e);
        }


    }
}
