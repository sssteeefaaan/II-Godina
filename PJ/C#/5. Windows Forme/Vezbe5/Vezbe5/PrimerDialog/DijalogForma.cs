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
    // Razlike u odnosu na projekat PrimerMasterDetail
    // 1. Dugme btnOK kome se još podešava property DialogResult na vrednost OK 
    //    da bi taj rezultat prosledila ova forma pri zatvaranju dugmetom OK. 
    // 2. Dugme btnOtkazi kome se još podešava property DialogResult na vrednost Cancel 
    //    da bi taj rezultat prosledila ova forma pri zatvaranju dugmetom Otkaži. 
    // 3. Ovde umesto radio dugmića za nivo studija dodajemo kontrolu ComboBox (samo da bismo
    //    isprobali rad ove kontrole). Menjamo (Name) u cbxNivoStudija. U konstruktoru
    //    popunjavamo tu kontrolu sa 3 moguće vrednosti. 
    // 4. Da bismo napravili vezu između izabaranog nivoa studija u kontroli ComboBox i 
    //    mogućih vrednosti za godinu studija u kontroli numGodinaStudija dodajemo 
    //    Event Handler za događaj SelectedIndexChanged - generiše se metoda cbxNivoStudija_SelectedIndexChanged. 
    //    Ovaj event se izvršava kada se promeni selektovana stavka u kontroli ComboBox.
    
    public partial class DijalogForma : Form
    {
        // Property koji označava studenta kog editujemo. 
        // Koristimo ga kada roditeljska forma treba da preuzme 
        // podatke o objektu editovanom u okviru ove forme. 
        public Student Student { get; set; }

        public DijalogForma()
        {
            InitializeComponent();
            // inicijalizacija kontrole cbxNivoStudija
            // dodajemo moguće stavke u cbxNivoStudija
            cbxNivoStudija.Items.Add(NivoStudija.Osnovne);
            cbxNivoStudija.Items.Add(NivoStudija.Master);
            cbxNivoStudija.Items.Add(NivoStudija.Doktorske);
            cbxNivoStudija.SelectedItem = NivoStudija.Osnovne;
            // biramo selektovanu stavku u cbxNivoStudija
            // isti efekat bi imala i sledeća linija 
            // cbxNivoStudija.SelectedIndex = 0;
        }

        public DijalogForma(Student student)
            : this()
        {
            // Ako se forma otvara za editovanje postojećeg studenta
            // ovaj parametar je različit od null. 
            // Ako se forma otvara za dodavanje novog studenta ovaj 
            // parametar je null. 
            this.Student = student;
            if (student != null)
                IzObjektaUKontrole(student);
        }

        // Pomoćna metoda koja preuzima vrednosti iz kontrola i 
        // postavlja sve atribute prosleđenog objekta. 
        private void IzKontrolaUObjekat(Student student)
        {
            student.Ime = txtIme.Text;
            student.Prezime = txtPrezime.Text;
            student.BrojIndeksa = (int)numBrojIndeksa.Value;
            student.NivoStudija = (NivoStudija)cbxNivoStudija.SelectedItem;
            student.GodinaStudija = (int)numGodinaStudija.Value;
            student.Prosek = (double)numProsek.Value;
            student.Budzet = chkBudzet.Checked;
            student.DatumRodjenja = dtpDatumRodjenja.Value;
        }

        

        // Pomocna metoda koja uzima vrednosti iz atributa prosleđenog 
        // objekta student i podešava prikazane vrednosti u kontrolama. 
        private void IzObjektaUKontrole(Student student)
        {
            txtIme.Text = student.Ime;
            txtPrezime.Text = student.Prezime;
            numBrojIndeksa.Value = student.BrojIndeksa;
            cbxNivoStudija.SelectedItem = student.NivoStudija;
            numGodinaStudija.Value = student.GodinaStudija;
            numProsek.Value = (decimal)student.Prosek;
            chkBudzet.Checked = student.Budzet;
            dtpDatumRodjenja.Value = student.DatumRodjenja;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Ako je objekat Student null onda se radi o dodavanju
            // novog studenta pa se najpre kreiramo taj objekat. 
            if (Student == null)
                Student = new Student();
            IzKontrolaUObjekat(Student);
        }

        // Event Handler koji nam daje vezu između selektovanog nivoa studija
        // i godine studija koju je moguće izabrati. 
        private void cbxNivoStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((NivoStudija)cbxNivoStudija.SelectedItem) == NivoStudija.Master)
                numGodinaStudija.Maximum = 1;
            else if (((NivoStudija)cbxNivoStudija.SelectedItem) == NivoStudija.Doktorske)
                numGodinaStudija.Maximum = 3;
            else
                numGodinaStudija.Maximum = 4;
        }
        

    }
}
