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

namespace PrimerMasterDetail
{
    #region Komentari
    // Implementacija korak po korak
    //  1. Dodati kontrolu Label, promeniti property (Name) u lblIme 
    //     i postaviti property Text na vrednost "Ime"
    //  2. Dodati kontrolu TextBox i promeniti (Name) u txtIme
    //  3. Dodati kontrolu Label, promeniti (Name) u lblPrezime i postaviti Text na vrednost "Prezime"
    //  4. Dodati kontrolu TextBox i promeniti (Name) u txtPrezime
    //  5. Dodati kontrolu Label, promeniti (Name) u lblBrojIndeksa i postaviti Text na vrednost "Broj indeksa:"
    //  6. Dodati kontrolu NumericUpDown, promeniti (Name) u numBrojIndeksa, 
    //     postaviti property Minimum na 1 (minimalna vrednost koja se može zadati kontrolom), 
    //     i postaviti property Maximum na npr. 20000 (maksimalna vrednost koja se može zadati kontrolom)
    //  7. Dodati kontrolu RadioButton, promeniti (Name) u rdbOsnovne, postaviti Text na Vrednost "Osnovne"
    //     i postaviti property Checked na true
    //  8. Dodati kontrolu RadioButton, promeniti (Name) u rdbMaster i postaviti Text na Vrednost "Master"
    //  9. Dodati kontrolu RadioButton, promeniti (Name) u rdbDoktorske i postaviti Text na Vrednost "Doktorske"
    // 10. Radio dugmad treba grupisati da bi bila međusobno isključiva 
    //     tj. treba ih ubaciti u zajedničku parent kontrolu
    // 11. Dodati kontrolu GroupBox, promeniti (Name) u gbxNivoStudija, 
    //     postaviti Text na Vrednost "Nivo studija" i prevući sva 3 radio 
    //     dugmeta na ovaj GroupBox
    // 12. Dodati kontrolu Label, promeniti (Name) u lblGodinaStudija i postaviti Text na vrednost "Godina studija:"
    // 13. Dodati kontrolu NumericUpDown, promeniti (Name) u numGodinaStudija i postaviti Minimum na 1 
    // 14. Problem - maksimalna vrednost za ovu kontrolu zavisi od selektovane vrednosti za nivo studija. 
    //     Za osnovne studije Maximum je 4, za master Maximum je 1, za doktorske Maximum je 3. 
    // 15. Rešenje - tu vrednost ćemo dinamički da menjamo u zavisnosti od selektovanog radio dugmeta. 
    //     Inicijalno je selektovano radio dugme za osnovne studije pa property Maximum postavljamo na 4. 
    //     Potreban nam je EventHandler za promenu stanja svakog od 3 radio dugmeta. Selektujemo dugme Osnovne, 
    //     u Properties prozoru biramo Events tab, tražimo događaj CheckedChanged i dvoklikom na njega generišemo 
    //     sledeći EventHandler:
    //     rdbOsnovne_CheckedChanged(object sender, EventArgs e)
    //     Istu metodu možemo da iskoristimo kao event handler i za druga dva radio dugmeta. Selektujemo radio dugme 
    //     Master i u Properties->Events tražimo događaj CheckedChanged pa iz padajućeg menija biramo rdbOsnovne_CheckedChanged. 
    //     Zatim selektujemo radio dugme Doktorske i u Properties->Events tražimo događaj CheckedChanged pa iz 
    //     padajućeg menija biramo rdbOsnovne_CheckedChanged. 
    // 16. Dodajemo kontrolu Label, menjamo (Name) u lblProsek 
    //     i postavljamo property Text na vrednost "Prosek"
    // 17. Dodajemo kontrolu NumericUpDown, menjamo (Name) u numProsek, postavljamo Minimum na 6, Maximum na 10
    //     i property DecimalPlaces na 2 da bismo predstavili vrednost prosečne ocene sa 2 decimalna mesta. 
    // 18. Dodajemo kontrolu CheckBox, menjamo (Name) u chkBudzet, postavljamo property Text na vrednost 
    //     "Finansiranje iz budžeta" i property Checked na vrednost true. 
    // 19. Dodajemo kontrolu Label, menjamo (Name) u lblDatumRodjenja
    //     i postavljamo property Text na vrednost "Datum rođenja:". 
    // 20. Dodajemo kontrolu DateTimePicker, menjamo (Name) u dtpDatumRodjenja i postavljamo property
    //     Format na Short da bismo prikazali samo datum u skraćenom formatu. 
    // 21. Dodajemo kontrolu Button, menjamo (Name) u btnDodaj, postavljamo property Text na vrednost "Dodaj". 
    //     Ovo dugme treba da služi za dodavanje novog studenta u listu studenata koja se čuva kao atribut klase Form1
    //     pa zato dodajemo Event Handler za klik na to dugme - metoda btnDodaj_Click. 
    // 22. Dodajemo kontrolu ListBox za prikaz liste studenata, menjamo (Name) u lbxStudenti i dodajemo pomoćnu 
    //     metodu za prikaz/osvežavanje podataka u ListBox kontroli. 
    // 23. Dodajemo logiku za izmenu studenta iz liste studenti. Potreban nam je Event Handler koji će na dupli klik
    //     na element u listi popuniti kontrole vrednostima iz selektovanog objekta. Selektujemo kontrolu lbxStudenti 
    //     i u Properties->Events dodajemo Event Handler za događaj DoubleClick - generiše se metoda 
    //     lbxStudenti_DoubleClick. 
    // 24. Naredni korak za izmenu je dodavanje dugmeta kojim prosleđujemo vrednosti iz kontrola u 
    //     objekat koji menjamo. Dodajemo kontrolu Button, menjamo (Name) u btnProsledi, postavljamo property Text na
    //     vrednost Prosledi i u Properties->Events dodajemo Event Handler za događaj Click - metoda btnProsledi_Click. 
    // 25. Brisanje selektovanog elementa iz liste - dodajemo kontrolu Button, menjamo (Name) u btnObrisi, postavljamo property Text na
    //     vrednost Obriši i u Properties->Events dodajemo Event Handler za događaj Click - metoda btnObrisi_Click. 
    // 26. Snimanje kreirane liste u fajl. Dodajemo kontrolu SaveFileDialog. Kontrola se ne prikazuje na samoj glavnoj formi 
    //     jer je u pitanju dijalog. Menjamo (Name) u sfdSnimi. Postavljamo property DefaultExt na .bin (određuje ekstenziju 
    //     koja se dodaje fajlu ako korisnik upiše samo naziv fajla bez ekstenzije). Postavljamo property Filter na "Binarni fajl|*.bin" da 
    //     bi bili prikazani samo fajlovi sa ekstenzijom .bin. 
    // 27. Da bismo prikazali SaveFileDialog potrebno nam je još jedno obično dugme. Dodajemo kontrolu Button, menjamo (Name) u btnSnimi, postavljamo property Text na
    //     vrednost Snimi i u Properties->Events dodajemo Event Handler za događaj Click - metoda btnObrisi_Click. 
    // 28. Učitavanje podataka iz fajla. Dodajemo kontrolu OpenFileDialog. Kontrola se ne prikazuje na samoj glavnoj formi 
    //     jer je u pitanju dijalog. Menjamo (Name) u ofdUcitaj. Postavljamo property Filter na 
    //     "Binarni fajl|*.bin|Svi fajlovi|*.*" da bi korisnik mogao da bira da li će biti prikazani 
    //     samo fajlovi sa ekstenzijom .bin ili svi fajlovi. 
    // 29. Da bismo prikazali OpenFileDialog potrebno nam je još jedno obično dugme. Dodajemo kontrolu Button, menjamo (Name) u btnUcitaj, postavljamo property Text na
    //     vrednost Učitaj i u Properties->Events dodajemo Event Handler za događaj Click - metoda btnUcitaj_Click. 
    // 30. Treba još omogućiti rad sa menijima. Dodajemo kontrolu MenuStrip i u njoj dodjemo stavku na osnovnom nivou Fajl. Ispod te
    //     stavke dodajemo još 2 podstavke Snimi i Učitaj. Stavki Snimi na događaj Click dodeljujemo handler btnSnimi_Click
    //     (postojeća metoda, biramo iz padajućeg menija). 
    //     Stavki Učitaj na događaj Click dodeljujemo handler btnUcitaj_Click (postojeća metoda, biramo iz padajućeg menija). 
    // 31. Za prečice do stavke u meniju Alt+slovo treba staviti znak & u nazivu stavke ispre slova koje želimo 
    //     da nam služi kao skraćenica. 
    // 32. Prečice sa proizvoljnim tasterom do stavke u meniju moguće je postaviti tako što izaberemo stavku iz menija pa 
    //     u Properties podesimo opciju ShortcutKeys. 
    #endregion Komentari

    public partial class Form1 : Form
    {
        private List<Student> studenti;

        public Form1()
        {
            InitializeComponent();
            studenti = new List<Student>();
        }

        // Pomoćna metoda koja preuzima vrednosti iz kontrola i 
        // postavlja sve atribute prosleđenog objekta. 
        private void IzKontrolaUObjekat(Student student)
        {
            student.Ime = txtIme.Text;
            student.Prezime = txtPrezime.Text;
            student.BrojIndeksa = (int)numBrojIndeksa.Value;
            student.NivoStudija = OdrediNivoStudija();
            student.GodinaStudija = (int)numGodinaStudija.Value;
            student.Prosek = (double)numProsek.Value;
            student.Budzet = chkBudzet.Checked;
            student.DatumRodjenja = dtpDatumRodjenja.Value;
        }

        // Pomoćna metoda koja određuje nivo studija na osnovu 
        // stanja radio dugmadi. 
        private NivoStudija OdrediNivoStudija()
        {
            if (rdbMaster.Checked)
                return NivoStudija.Master;
            else if (rdbDoktorske.Checked)
                return NivoStudija.Doktorske;
            else
                return NivoStudija.Osnovne;
        }

        // Pomocna metoda koja uzima vrednosti iz atributa prosleđenog 
        // objekta student i podešava prikazane vrednosti u kontrolama. 
        private void IzObjektaUKontrole(Student student)
        {
            txtIme.Text = student.Ime;
            txtPrezime.Text = student.Prezime;
            numBrojIndeksa.Value = student.BrojIndeksa;
            CekirajDugmice(student.NivoStudija);
            numGodinaStudija.Value = student.GodinaStudija;
            numProsek.Value = (decimal)student.Prosek;
            chkBudzet.Checked = student.Budzet;
            dtpDatumRodjenja.Value = student.DatumRodjenja;
        }

        // Pomoćna funkcija koja čekira radio dugmiće za prikaz
        // odgovarajućeg nivoa studija. 
        private void CekirajDugmice(NivoStudija nivo)
        {
            switch (nivo)
            {
                case NivoStudija.Osnovne:
                    rdbOsnovne.Checked = true;
                    break;
                case NivoStudija.Master:
                    rdbMaster.Checked = true;
                    break;
                case NivoStudija.Doktorske:
                    rdbDoktorske.Checked = true;
                    break;
                default:
                    break;
            }
        }

        // Pomoćna funkcija koja se poziva kad god je potrebno osvežiti prikaz liste
        private void PrikaziListu()
        {
            // čišćenje liste u slučaju da je u njoj prethodno bilo nekih elemenata
            lbxStudenti.Items.Clear(); 
            // dodavanje elemenata iz liste studenti u ListBox za prikaz
            lbxStudenti.Items.AddRange(studenti.ToArray());
            // umesto prethodne linije može da se koristi i sledeća foreach petlja
            //foreach (Student s in studenti)
            //    lbxStudenti.Items.Add(s);
        }

        private void rdbOsnovne_CheckedChanged(object sender, EventArgs e)
        {
            // RadioButton kontrole su grupisane pa je uvek tačno jedna čekirana. 
            // Na osnovu toga biramo maksimalnu vrednost u numeričkom polju. 
            if (rdbMaster.Checked)
                numGodinaStudija.Maximum = 1;
            else if (rdbDoktorske.Checked)
                numGodinaStudija.Maximum = 3;
            else
                numGodinaStudija.Maximum = 4;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Student noviStudent = new Student();
            IzKontrolaUObjekat(noviStudent);
            studenti.Add(noviStudent);
            PrikaziListu();
        }

        private void lbxStudenti_DoubleClick(object sender, EventArgs e)
        {
            // ako nema selektovanih elemenata u listi onda  
            // SelectedIndex ima vrednost -1
            if (lbxStudenti.SelectedIndex != -1)
            {
                IzObjektaUKontrole(studenti[lbxStudenti.SelectedIndex]);
            }
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            // ako nema selektovanih elemenata u listi onda  
            // SelectedIndex ima vrednost -1
            if (lbxStudenti.SelectedIndex != -1)
            {
                // prosleđujemo vrednosti iz kontrola u objekat koji je 
                // prethodno bio selektovan za izmenu
                IzKontrolaUObjekat(studenti[lbxStudenti.SelectedIndex]);
                // osvežavamo prikaz liste
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

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            // Dijalog forma se otvara metodom ShowDialog()
            // Na taj način njena roditeljska forma ostaje neaktivna
            if (sfdSnimi.ShowDialog() == DialogResult.OK)

            // Ispitujemo povratnu vrednost metode ShowDialog. Samo
            // ako je ta vrednost OK (znači da je korisnik zatvorio 
            // formu klikom na ok dugme) izvršavamo dalje akcije. 
            {
                Student.SnimiStudente(sfdSnimi.FileName, studenti);
                // Apsolutna putanja do fajla koji je korisnik izabrao za 
                // snimanje se nalazi u sfdSnimi.FileName
            }
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            // Dijalog forma se otvara metodom ShowDialog()
            // Na taj način njena roditeljska forma ostaje neaktivna
            if (ofdUcitaj.ShowDialog() == DialogResult.OK)

            // Ispitujemo povratnu vrednost metode ShowDialog. Samo
            // ako je ta vrednost OK (znači da je korisnik zatvorio 
            // formu klikom na ok dugme) izvršavamo dalje akcije. 
            {
                studenti = Student.UcitajStudente(ofdUcitaj.FileName);
                // Apsolutna putanja do fajla koji je korisnik izabrao za 
                // snimanje se nalazi u ofdUcitaj.FileName
                PrikaziListu();
            }

        }
    }
}
