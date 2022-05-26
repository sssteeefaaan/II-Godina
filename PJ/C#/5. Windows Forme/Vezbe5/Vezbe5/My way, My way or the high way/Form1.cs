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

namespace My_way__My_way_or_the_high_way
{
    public partial class Form1 : Form
    {
        private List<Student> studenti;

        public Form1()
        {
            InitializeComponent();
            studenti = new List<Student>();
        }

        private void nivoStudija_CheckedChanged(object sender, EventArgs e)
        {
            if (rbttnOsnovne.Checked)
                numUDGodStud.Maximum = 4;
            else if (rbttnMaster.Checked)
                numUDGodStud.Maximum = 1;
            else if (rbttnDoktorske.Checked)
                numUDGodStud.Maximum = 3;
        }

        private void formToObject(Student s)
        {
            s.Ime = txtBIme.Text;
            s.Prezime = txtBPrezime.Text;
            s.BrojIndeksa = (int)numUDBIndx.Value;
            s.DatumRodjenja = dTPDatRodj.Value;
            s.Prosek = (double)numUDProsek.Value;
            s.NivoStudija = checkButtons();
            s.GodinaStudija = (int)numUDGodStud.Value;
            s.Budzet = chckBBudzet.Checked;
        }

        private void objectToForm(Student s)
        {
            txtBIme.Text = s.Ime;
            txtBPrezime.Text = s.Prezime;
            numUDBIndx.Value = s.BrojIndeksa;
            dTPDatRodj.Value = s.DatumRodjenja;
            numUDProsek.Value = (decimal)s.Prosek;
            checkButtons(s.NivoStudija);
            numUDGodStud.Value = s.GodinaStudija;
            chckBBudzet.Checked = s.Budzet;
        }

        private void checkButtons(NivoStudija nS)
        {
            switch (nS)
            {
                case (NivoStudija.Osnovne):
                    rbttnOsnovne.Checked = true;
                    break;
                case (NivoStudija.Master):
                    rbttnMaster.Checked = true;
                    break;
                case (NivoStudija.Doktorske):
                    rbttnDoktorske.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private NivoStudija checkButtons()
        {
            if (rbttnOsnovne.Checked)
                return NivoStudija.Osnovne;
            else if (rbttnMaster.Checked)
                return NivoStudija.Master;
            return NivoStudija.Doktorske;
        }

        private void osveziListu()
        {
            lbxStudenti.Items.Clear();
            lbxStudenti.Items.AddRange(studenti.ToArray());
            
        }
        private void bttnDodaj_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            formToObject(s);
            studenti.Add(s);
            osveziListu();
        }

        private void bttnProsledi_Click(object sender, EventArgs e)
        {
            if (lbxStudenti.SelectedIndex != -1)
            {
                objectToForm(studenti[lbxStudenti.SelectedIndex]);
                osveziListu();
            }
        }

        private void lbxStudenti_DoubleClick(object sender, EventArgs e)
        {
            if (lbxStudenti.SelectedIndex != -1)
                objectToForm(studenti[lbxStudenti.SelectedIndex]);
        }

        private void bttnSnimi_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                Student.SnimiStudente(saveFileDialog1.FileName, studenti);
        }

        private void bttnUcitaj_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                studenti = Student.UcitajStudente(openFileDialog1.FileName);
            osveziListu();
        }

        private void bttnObrisi_Click(object sender, EventArgs e)
        {
            if (lbxStudenti.SelectedIndex != -1)
                studenti.RemoveAt(lbxStudenti.SelectedIndex);
            osveziListu();
        }
    }
}
