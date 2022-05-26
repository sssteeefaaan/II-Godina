namespace PrimerMasterDetail
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblBrojIndeksa = new System.Windows.Forms.Label();
            this.numBrojIndeksa = new System.Windows.Forms.NumericUpDown();
            this.rdbOsnovne = new System.Windows.Forms.RadioButton();
            this.rdbMaster = new System.Windows.Forms.RadioButton();
            this.rdbDoktorske = new System.Windows.Forms.RadioButton();
            this.gbxNivoStudija = new System.Windows.Forms.GroupBox();
            this.numGodinaStudija = new System.Windows.Forms.NumericUpDown();
            this.lblGodinaStudija = new System.Windows.Forms.Label();
            this.numProsek = new System.Windows.Forms.NumericUpDown();
            this.lblProsek = new System.Windows.Forms.Label();
            this.chkBudzet = new System.Windows.Forms.CheckBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.lblDatumRođenja = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lbxStudenti = new System.Windows.Forms.ListBox();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.sfdSnimi = new System.Windows.Forms.SaveFileDialog();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.ofdUcitaj = new System.Windows.Forms.OpenFileDialog();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.učitajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojIndeksa)).BeginInit();
            this.gbxNivoStudija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGodinaStudija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProsek)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(95, 43);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(135, 40);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(176, 22);
            this.txtIme.TabIndex = 1;
            //
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(135, 75);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(176, 22);
            this.txtPrezime.TabIndex = 3;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(66, 75);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 17);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblBrojIndeksa
            // 
            this.lblBrojIndeksa.AutoSize = true;
            this.lblBrojIndeksa.Location = new System.Drawing.Point(39, 116);
            this.lblBrojIndeksa.Name = "lblBrojIndeksa";
            this.lblBrojIndeksa.Size = new System.Drawing.Size(90, 17);
            this.lblBrojIndeksa.TabIndex = 4;
            this.lblBrojIndeksa.Text = "Broj indeksa:";
            // 
            // numBrojIndeksa
            // 
            this.numBrojIndeksa.Location = new System.Drawing.Point(135, 114);
            this.numBrojIndeksa.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numBrojIndeksa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBrojIndeksa.Name = "numBrojIndeksa";
            this.numBrojIndeksa.Size = new System.Drawing.Size(176, 22);
            this.numBrojIndeksa.TabIndex = 5;
            this.numBrojIndeksa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdbOsnovne
            // 
            this.rdbOsnovne.AutoSize = true;
            this.rdbOsnovne.Checked = true;
            this.rdbOsnovne.Location = new System.Drawing.Point(6, 21);
            this.rdbOsnovne.Name = "rdbOsnovne";
            this.rdbOsnovne.Size = new System.Drawing.Size(86, 21);
            this.rdbOsnovne.TabIndex = 6;
            this.rdbOsnovne.TabStop = true;
            this.rdbOsnovne.Text = "Osnovne";
            this.rdbOsnovne.UseVisualStyleBackColor = true;
            this.rdbOsnovne.CheckedChanged += new System.EventHandler(this.rdbOsnovne_CheckedChanged);
            // 
            // rdbMaster
            // 
            this.rdbMaster.AutoSize = true;
            this.rdbMaster.Location = new System.Drawing.Point(98, 21);
            this.rdbMaster.Name = "rdbMaster";
            this.rdbMaster.Size = new System.Drawing.Size(72, 21);
            this.rdbMaster.TabIndex = 7;
            this.rdbMaster.Text = "Master";
            this.rdbMaster.UseVisualStyleBackColor = true;
            this.rdbMaster.CheckedChanged += new System.EventHandler(this.rdbOsnovne_CheckedChanged);
            // 
            // rdbDoktorske
            // 
            this.rdbDoktorske.AutoSize = true;
            this.rdbDoktorske.Location = new System.Drawing.Point(176, 21);
            this.rdbDoktorske.Name = "rdbDoktorske";
            this.rdbDoktorske.Size = new System.Drawing.Size(93, 21);
            this.rdbDoktorske.TabIndex = 8;
            this.rdbDoktorske.Text = "Doktorske";
            this.rdbDoktorske.UseVisualStyleBackColor = true;
            this.rdbDoktorske.CheckedChanged += new System.EventHandler(this.rdbOsnovne_CheckedChanged);
            // 
            // gbxNivoStudija
            // 
            this.gbxNivoStudija.Controls.Add(this.rdbOsnovne);
            this.gbxNivoStudija.Controls.Add(this.rdbDoktorske);
            this.gbxNivoStudija.Controls.Add(this.rdbMaster);
            this.gbxNivoStudija.Location = new System.Drawing.Point(39, 151);
            this.gbxNivoStudija.Name = "gbxNivoStudija";
            this.gbxNivoStudija.Size = new System.Drawing.Size(272, 46);
            this.gbxNivoStudija.TabIndex = 9;
            this.gbxNivoStudija.TabStop = false;
            this.gbxNivoStudija.Text = "Nivo studija";
            // 
            // numGodinaStudija
            // 
            this.numGodinaStudija.Location = new System.Drawing.Point(135, 213);
            this.numGodinaStudija.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numGodinaStudija.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGodinaStudija.Name = "numGodinaStudija";
            this.numGodinaStudija.Size = new System.Drawing.Size(176, 22);
            this.numGodinaStudija.TabIndex = 11;
            this.numGodinaStudija.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGodinaStudija
            // 
            this.lblGodinaStudija.AutoSize = true;
            this.lblGodinaStudija.Location = new System.Drawing.Point(26, 215);
            this.lblGodinaStudija.Name = "lblGodinaStudija";
            this.lblGodinaStudija.Size = new System.Drawing.Size(103, 17);
            this.lblGodinaStudija.TabIndex = 10;
            this.lblGodinaStudija.Text = "Godina studija:";
            // 
            // numProsek
            // 
            this.numProsek.DecimalPlaces = 2;
            this.numProsek.Location = new System.Drawing.Point(135, 250);
            this.numProsek.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numProsek.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numProsek.Name = "numProsek";
            this.numProsek.Size = new System.Drawing.Size(176, 22);
            this.numProsek.TabIndex = 13;
            this.numProsek.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lblProsek
            // 
            this.lblProsek.AutoSize = true;
            this.lblProsek.Location = new System.Drawing.Point(73, 252);
            this.lblProsek.Name = "lblProsek";
            this.lblProsek.Size = new System.Drawing.Size(56, 17);
            this.lblProsek.TabIndex = 12;
            this.lblProsek.Text = "Prosek:";
            // 
            // chkBudzet
            // 
            this.chkBudzet.AutoSize = true;
            this.chkBudzet.Checked = true;
            this.chkBudzet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBudzet.Location = new System.Drawing.Point(135, 290);
            this.chkBudzet.Name = "chkBudzet";
            this.chkBudzet.Size = new System.Drawing.Size(176, 21);
            this.chkBudzet.TabIndex = 14;
            this.chkBudzet.Text = "Finansiranje iz budžeta";
            this.chkBudzet.UseVisualStyleBackColor = true;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(137, 329);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(174, 22);
            this.dtpDatumRodjenja.TabIndex = 15;
            // 
            // lblDatumRođenja
            // 
            this.lblDatumRođenja.AutoSize = true;
            this.lblDatumRođenja.Location = new System.Drawing.Point(26, 332);
            this.lblDatumRođenja.Name = "lblDatumRođenja";
            this.lblDatumRođenja.Size = new System.Drawing.Size(105, 17);
            this.lblDatumRođenja.TabIndex = 16;
            this.lblDatumRođenja.Text = "Datum rođenja:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(54, 364);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(60, 25);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lbxStudenti
            // 
            this.lbxStudenti.FormattingEnabled = true;
            this.lbxStudenti.ItemHeight = 16;
            this.lbxStudenti.Location = new System.Drawing.Point(29, 406);
            this.lbxStudenti.Name = "lbxStudenti";
            this.lbxStudenti.Size = new System.Drawing.Size(284, 84);
            this.lbxStudenti.TabIndex = 18;
            this.lbxStudenti.DoubleClick += new System.EventHandler(this.lbxStudenti_DoubleClick);
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(121, 364);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(112, 25);
            this.btnProsledi.TabIndex = 19;
            this.btnProsledi.Text = "Prosledi u listu";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(240, 364);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(68, 25);
            this.btnObrisi.TabIndex = 20;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // sfdSnimi
            // 
            this.sfdSnimi.DefaultExt = "bin";
            this.sfdSnimi.Filter = "Binarni fajl|*.bin";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(86, 508);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
            this.btnSnimi.TabIndex = 21;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // ofdUcitaj
            // 
            this.ofdUcitaj.Filter = "Binarni fajlovi|*.bin|Svi fajlovi|*.*";
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(169, 508);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(75, 23);
            this.btnUcitaj.TabIndex = 22;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(325, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snimiToolStripMenuItem,
            this.učitajToolStripMenuItem});
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fajlToolStripMenuItem.Text = "&Fajl";
            // 
            // snimiToolStripMenuItem
            // 
            this.snimiToolStripMenuItem.Name = "snimiToolStripMenuItem";
            this.snimiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.snimiToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.snimiToolStripMenuItem.Text = "&Snimi";
            this.snimiToolStripMenuItem.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // učitajToolStripMenuItem
            // 
            this.učitajToolStripMenuItem.Name = "učitajToolStripMenuItem";
            this.učitajToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.učitajToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.učitajToolStripMenuItem.Text = "&Učitaj";
            this.učitajToolStripMenuItem.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 543);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.lbxStudenti);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblDatumRođenja);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.chkBudzet);
            this.Controls.Add(this.numProsek);
            this.Controls.Add(this.lblProsek);
            this.Controls.Add(this.numGodinaStudija);
            this.Controls.Add(this.lblGodinaStudija);
            this.Controls.Add(this.gbxNivoStudija);
            this.Controls.Add(this.numBrojIndeksa);
            this.Controls.Add(this.lblBrojIndeksa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numBrojIndeksa)).EndInit();
            this.gbxNivoStudija.ResumeLayout(false);
            this.gbxNivoStudija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGodinaStudija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProsek)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblBrojIndeksa;
        private System.Windows.Forms.NumericUpDown numBrojIndeksa;
        private System.Windows.Forms.RadioButton rdbOsnovne;
        private System.Windows.Forms.RadioButton rdbMaster;
        private System.Windows.Forms.RadioButton rdbDoktorske;
        private System.Windows.Forms.GroupBox gbxNivoStudija;
        private System.Windows.Forms.NumericUpDown numGodinaStudija;
        private System.Windows.Forms.Label lblGodinaStudija;
        private System.Windows.Forms.NumericUpDown numProsek;
        private System.Windows.Forms.Label lblProsek;
        private System.Windows.Forms.CheckBox chkBudzet;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Label lblDatumRođenja;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox lbxStudenti;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.SaveFileDialog sfdSnimi;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.OpenFileDialog ofdUcitaj;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem učitajToolStripMenuItem;
    }
}

