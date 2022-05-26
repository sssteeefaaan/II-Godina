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

namespace PoredjenjeDirektorijuma
{
    public partial class Form1 : Form
    {
        // podaci o prvom i drugom selektovanom direktorijumu
        private DirectoryInfo prviDir, drugiDir;
        // podaci o fajlovima u prvom i drugom selektovanom direktorijumu
        private FileInfo[] prviFajlovi, drugiFajlovi;
        // lista fajlova koji su isti u oba direktorijuma
        private List<FileInfo> istiFajlovi;

        public Form1()
        {
            InitializeComponent();
            istiFajlovi = new List<FileInfo>();
        }

        private void btnIzaberiPrviDirektorijum_Click(object sender, EventArgs e)
        {
            // Za izbor direktorijuma se koristi FolderBrowserDialog kontrola koja 
            // radi slično kao i SaveFileDialog i OpenFileDialog. 
            if (fbdIzaberiDirektorijum.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // FolderBrowserDialog.SelectedPath sadrži putanju direktorijuma koji
                // je korisnik odabrao pa kliknuo OK.
                prviDir = new DirectoryInfo(fbdIzaberiDirektorijum.SelectedPath);
                // U TextBox-u samo prikazujemo putanju do izabranog direktorijuma
                // prethodno je property Enabled podešen na false da korisnik ne 
                // bi mogao da menja sadržaj TextBox-a.
                txtPrviDirektorijum.Text = prviDir.FullName;
                // Vraćaju se svi fajlovi iz prvog direktorijuma kao niz FileInfo klasa.
                prviFajlovi = prviDir.GetFiles();
                // Brisanje postojećih stavki pa popunjavanje ListBox-a novim stavkama.
                lbxPrviFajlovi.Items.Clear();
                lbxPrviFajlovi.Items.AddRange(prviFajlovi);
            }
        }

        private void btnIzaberiDrugiDirektorijum_Click(object sender, EventArgs e)
        {
            // Ista logika kao i za prvi direktorijum.
            if (fbdIzaberiDirektorijum.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                drugiDir = new DirectoryInfo(fbdIzaberiDirektorijum.SelectedPath);
                txtDrugiDirektorijum.Text = drugiDir.FullName;
                drugiFajlovi = drugiDir.GetFiles();
                lbxDrugiFajlovi.Items.Clear();
                lbxDrugiFajlovi.Items.AddRange(drugiFajlovi);
            }
        }

        private void btnPronadjiIste_Click(object sender, EventArgs e)
        {
            // Brišemo sve iz liste istih fajlova.
            istiFajlovi.Clear();
            // Poredimo sve fajlove iz prvog direktorijuma sa svim fajlovima iz drugog direktorijuma.
            foreach (FileInfo fi1 in prviFajlovi)
            {
                foreach (FileInfo fi2 in drugiFajlovi)
                {
                    if (fi1.Name == fi2.Name && UporediSadrzajFajlova(fi1, fi2))
                    {
                        istiFajlovi.Add(fi1);
                    }
                }
            }
            lbxIstiFajlovi.Items.Clear();
            lbxIstiFajlovi.Items.AddRange(istiFajlovi.ToArray());
        }

        private bool UporediSadrzajFajlova(FileInfo fi1, FileInfo fi2)
        {
            // Ako se fajlovi razlikuju po dužini možemo odmah da vratimo false.
            if (fi1.Length != fi2.Length)
                return false;
            // Otvaranje dva fajl toka u istom using bloku, razdvojeni su operatorom zarez.
            // Dovoljna nam je klasa FileStream jer ćemo da radimo poređenje bajt po bajt
            // nije nam neophodan tok sa formatiranjem (BinaryReader).
            using (FileStream fs1 = new FileStream(fi1.FullName, FileMode.Open), 
                fs2 = new FileStream(fi2.FullName, FileMode.Open))
            {
                int length = (int)fs1.Length;
                byte[] bytes1 = new byte[length];
                fs1.Read(bytes1, 0, length); 
                // Učitan je ceo prvi fajl u niz bajtova.
                byte[] bytes2 = new byte[length];
                fs2.Read(bytes2, 0, length);
                // Učitan je ceo drugi fajl u niz bajtova.
                int position = 0;
                while (position < length
                    && bytes1[position] == bytes2[position])
                {
                    position++;
                }
                if (position < length)
                    return false;
                else
                    return true;
            }
        }
    }
}
