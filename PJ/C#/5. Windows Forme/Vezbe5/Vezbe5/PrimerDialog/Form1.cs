using Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerDialog
{
    // Logika u ovoj formi je ista kao i u projektu PrimerMasterDetail
    // sa tom razlikom što su "detail" kontrole za prikaz podataka o 
    // jednom studentu prebačene u formu DijalogForma, 
    // a dugme Dodaj i dugme Izmeni otvaraju 
    // otvaraju tu dijalog formu za dodavanje ili izmenu studenta. 
    //
    // Za raspored kontrola su promenjena Anchor podešavanja. Podrazumevane 
    // vrednosti za Anchor za svaku od kontrola su Top i Left. Za ListBox menjamo 
    // tako da su uključene sve 4 vrednosti Top, Bottom, Left i Right. Na taj način dobijamo
    // mogućnost da povećanjem forme povećavamo i ListBox. Da prilikom povećanja
    // ListBox ne bi prekrio nijedno dugme menjamo i njihova Anchor podešavanja. 
    // Za dugmiće "Snimi" i "Učitaj" isključujemo Top i uključujemo Bottom tako da ostaju 
    // sa uključenim Bottom i Left. 
    // Za dugmiće "Izmeni", "Dodaj" i "Obriši" isključujemo Left i uključujemo Right tako da ostaju 
    // sa uključenim Top i Right. 
    public partial class Form1 : Form
    {
        private List<Student> studenti;

        public Form1()
        {
            InitializeComponent();
            this.studenti = new List<Student>();
        }

        // Pomoćna funkcija koja se poziva kad god je potrebno osvežiti prikaz liste
        private void PrikaziListu()
        {
            // čišćenje liste u slučaju da je u njoj prethodno bilo nekih elemenata
            lbxStudenti.Items.Clear();
            // dodavanje elemenata iz liste studenti u ListBox za prikaz
            lbxStudenti.Items.AddRange(studenti.ToArray());
        }

        private void btniSnimi_Click(object sender, EventArgs e)
        {
            if (sfdSnimiStudente.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Student.SnimiStudente(sfdSnimiStudente.FileName, this.studenti);
            }
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            if (ofdUcitajStudente.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                studenti = Student.UcitajStudente(ofdUcitajStudente.FileName);
                PrikaziListu();
            }
        }



        private void lbxStudenti_DoubleClick(object sender, EventArgs e)
        {
            // ako nema selektovanih elemenata u listi onda  
            // SelectedIndex ima vrednost -1
            if (lbxStudenti.SelectedIndex != -1)
            {
                DijalogForma dlg = new DijalogForma(studenti[lbxStudenti.SelectedIndex]);
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    PrikaziListu();
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DijalogForma dlg = new DijalogForma(null);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                studenti.Add(dlg.Student);
                PrikaziListu();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            // ako nema selektovanih elemenata u listi onda  
            // SelectedIndex ima vrednost -1
            if (lbxStudenti.SelectedIndex != -1)
            {
                // selektovani element se uklanja iz liste
                studenti.RemoveAt(lbxStudenti.SelectedIndex);
                // osvežavamo prikaz liste
                PrikaziListu();
            }
        }
    }
}
