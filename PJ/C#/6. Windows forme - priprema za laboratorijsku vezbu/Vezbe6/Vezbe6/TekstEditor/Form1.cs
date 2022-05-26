using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekstEditor
{
    // Koraci za implementaciju:
    // 1. Kontrola TextBox za prikaz teksta
    //    Dodati TextBox kontrolu na formu, promeniti (Name) property u txtEditor, podesiti
    //    Multiline property u true (da bi TextBox mogao da prikaže više od jednog reda), 
    //    "razvući" TextBox do granica klijentskog pravougaonika u formi (ostaviti malo
    //    prostora do gornje granice da bi mogla da se doda MenuStrip kontorla i u Anchor  
    //    property dodati vrednosti Right i Bottom da bi TextBox menjao veličinu zajedno sa 
    //    formom (Top i Left anchor postoje po default-u kad se doda kontrola). 
    // 2. Dodavanje stavki u meniju
    //    Prevući kontrolu MenuStrip na formu. Ona se automatski pozicionira u gornjem levom 
    //    uglu forme. U polju gde stoji natpis "Type here" moguće je uneti novu stavku u meniju. 
    //    Kreirati ovakvu strukturu menija:
    //    &Fajl      &Edit
    //    |__&Snimi  |__Se&lektuj sve
    //    |__&Otvori |__&Datum/Vreme
    //    Znak & se dodaje ispred karaktera koji će u kombinaciji sa Alt tasterom aktivirati neku stavku 
    //    iz menija. Npr. Alt+F+S aktivira Fajl->Snimi stavku.  
    //
    //  2. Snimanje teksta u fajl
    //    Dodati kontrolu SaveFileDialog. Kontrola se ne prikazuje na samoj glavnoj formi jer je u pitanju 
    //    dijalog forma koja se kasnije povezuje sa stavkom iz menija "Snimi". Promeniti (Name) u sfdSnimi. 
    //    Postaviti property DefaultExt na .txt (određuje ekstenziju koja se dodaje fajlu ako korisnik 
    //    upiše samo naziv fajla bez ekstenzije). Postaviti property Filter na "Tekstualni fajl|*.txt" 
    //    da bi dijalog forma prikazala samo fajlove sa ekstenzijom .txt. U dizajner pogledu selektovati
    //    stavku iz menija Fajl->Snimi i u Properties pogledu u kartici sa događajima (simbol "munja")
    //    dodati event handler metodu za događaj Click koja dobija podrazumevano ime 
    //    snimiToolStripMenuItem_Click. Implementacija te metode je data ispod.
    //
    // 3. Otvaranje/učitavanje teksta iz fajla
    //    Dodati kontrolu OpenFileDialog. Kontrola se ne prikazuje na samoj glavnoj formi jer je u pitanju 
    //    dijalog forma koja se kasnije povezuje sa stavkom iz menija "Otvori". Promeniti (Name) u ofdOtvori. 
    //    Postaviti property FileName prazan string, po default-u vrednost je openFileDialog1. Postaviti 
    //    property Filter na "Tekstualni fajl|*.txt" da bi dijalog forma prikazala samo fajlove sa 
    //    ekstenzijom .txt. U dizajner pogledu selektovati stavku iz menija Fajl->Otvori i u 
    //    Properties pogledu u kartici sa događajima (simbol "munja") dodati event handler metodu za 
    //    događaj Click koja dobija podrazumevano ime otvoriToolStripMenuItem_Click. Implementacija te metode 
    //    je data u kodu ispod.
    //   
    // 4. Selektovanje celokupnog teksta u editoru
    //    Ovu funkcionalnost treba ostvariti preko stavke u meniju Edit-> Selektuj sve. U dizajn pogledu 
    //    pozicionirati se na stavku "Selektuj sve" i u Properties pogledu (kartica sa događajima) 
    //    dodati event handler metodu za događaj Click koja dobija podrazumevano ime 
    //    selektujSveToolStripMenuItem_Click. Implementacija te metode je data u kodu ispod.
    //
    // 5. Dodavanje Datuma/Vremena u tekst
    //    Slična funkcionalnost postoji i u Notepad editoru - izborom stavke Datum/Vreme dodaje se trenutni
    //    datum i vreme u tekst. Ovu funkcionalnost treba ostvariti preko stavke u meniju Edit-> Datum/Vreme. 
    //    U dizajn pogledu pozicionirati se na stavku "Datum/Vreme" i u Properties pogledu (kartica sa događajima) 
    //    dodati event handler metodu za događaj Click koja dobija podrazumevano ime 
    //    datumVremeToolStripMenuItem_Click. Implementacija te metode je data u kodu ispod.
    // 
    // 6. Podešavanje prečica sa tastature
    //    Preko menija su već implementirane prečice pomoću kombinacije Alt+<više_slova>. Obično 
    //    aplikacije imaju i prečice sa kombinacijom Ctrl+<jedno_slovo>. Za ovakve prečice je potrebna 
    //    obrada događaja sa tastature. Detaljnije objašnjenje događaja tastature dato je u prezentaciji
    //    sa uvodom u Windows forme. Od događaja KeyDown, KeyPress i KeyUp najbolji za ove prečice je 
    //    KeyDown zato što korisnik dobija odgovor na akciju odmah prilikom pritiska na taster (ne čeka se
    //    da se taster otpusti). 
    //    U dizajn pogledu selektovati TextBox kontrolu  i u Properties pogledu (kartica sa događajima) 
    //    dodati event handler metodu za događaj KeyDown koja dobija podrazumevano ime 
    //    datumVremeToolStripMenuItem_Click. Implementacija te metode je data u kodu ispod.



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void snimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Dijalog forma se otvara metodom ShowDialog()
            // Na taj način njena roditeljska forma ostaje neaktivna
            if (sfdSnimi.ShowDialog() == DialogResult.OK)
            {
                // Ispitujemo povratnu vrednost metode ShowDialog. Samo
                // ako je ta vrednost OK (znači da je korisnik zatvorio 
                // formu klikom na ok dugme) otvaramo tekstualni tok i upisujemo
                // tekst u fajl. 
                using (StreamWriter sw = new StreamWriter(sfdSnimi.FileName))
                {
                    sw.Write(txtEditor.Text);
                }
            }
        }

        private void otvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Dijalog forma se otvara metodom ShowDialog()
            // Na taj način njena roditeljska forma ostaje neaktivna
            if (ofdOtvori.ShowDialog() == DialogResult.OK)
            {
                // Ispitujemo povratnu vrednost metode ShowDialog. Samo
                // ako je ta vrednost OK (znači da je korisnik zatvorio 
                // formu klikom na ok dugme) otvaramo tekstualni tok i tekst
                // iz fajla upisujemo u TextBox. 
                using (StreamReader sr = new StreamReader(ofdOtvori.FileName))
                {
                    txtEditor.Text = sr.ReadToEnd();
                }
            }
        }

        private void selektujSveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.SelectAll();
        }

        private void datumVremeToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            // na postojeći tekst u editoru konkateniramo vreme pa datum
            txtEditor.Text += 
                (DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToShortDateString());
        }

        private void txtEditor_KeyDown(object sender, KeyEventArgs e)
        {
            // proveravamo najpre da li je aktiviran taster Ctrl
            if (e.Control)
            {
                if (e.KeyCode == (Keys.S))
                    // za Ctrl+S izvršava se snimanje
                    snimiToolStripMenuItem_Click(sender, e);
                else if (e.KeyCode == (Keys.O))
                    // za Ctrl+O izvršava se otvaranje
                    otvoriToolStripMenuItem_Click(sender, e);
                else if (e.KeyCode == (Keys.A))
                    // za Ctrl+A selektuje se sav tekst
                    selektujSveToolStripMenuItem_Click(sender, e);
                else if (e.KeyCode == (Keys.D))
                    // za Ctrl+D ubacuje se datum i vreme
                    datumVremeToolStripMenuItem_Click(sender, e);
            }
            // moguće je i rešenje preko KeyData umesto KeyCode
            // i kombinacije običnog tastera i kontrol tastera bitskim OR operatorom
            //if (e.KeyData == (Keys.S | Keys.Control))
            //    // za Ctrl+S izvršava se snimanje
            //    snimiToolStripMenuItem_Click(sender, e);
            //if (e.KeyData == (Keys.O | Keys.Control))
            //    // za Ctrl+O izvršava se otvaranje
            //    otvoriToolStripMenuItem_Click(sender, e);
            //if (e.KeyData == (Keys.A | Keys.Control))
            //    // za Ctrl+A selektuje se sav tekst
            //    selektujSveToolStripMenuItem_Click(sender, e);
            //if (e.KeyData == (Keys.D | Keys.Control))
            //    // za Ctrl+D ubacuje se datum i vreme
            //    datumVremeToolStripMenuItem_Click(sender, e);
        }
    }
}
