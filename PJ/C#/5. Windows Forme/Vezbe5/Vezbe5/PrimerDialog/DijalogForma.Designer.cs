namespace PrimerDialog
{
    partial class DijalogForma
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
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.numBrojIndeksa = new System.Windows.Forms.NumericUpDown();
            this.lblIndeks = new System.Windows.Forms.Label();
            this.numGodinaStudija = new System.Windows.Forms.NumericUpDown();
            this.lblGodinaStudija = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.chkBudzet = new System.Windows.Forms.CheckBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.numProsek = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblProsek = new System.Windows.Forms.Label();
            this.lblNivoStudija = new System.Windows.Forms.Label();
            this.cbxNivoStudija = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojIndeksa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGodinaStudija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProsek)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(154, 47);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(176, 22);
            this.txtPrezime.TabIndex = 24;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(154, 17);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(176, 22);
            this.txtIme.TabIndex = 23;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(82, 50);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 17);
            this.lblPrezime.TabIndex = 26;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(111, 20);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 25;
            this.lblIme.Text = "Ime:";
            // 
            // numBrojIndeksa
            // 
            this.numBrojIndeksa.Location = new System.Drawing.Point(154, 85);
            this.numBrojIndeksa.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numBrojIndeksa.Name = "numBrojIndeksa";
            this.numBrojIndeksa.Size = new System.Drawing.Size(176, 22);
            this.numBrojIndeksa.TabIndex = 27;
            // 
            // lblIndeks
            // 
            this.lblIndeks.AutoSize = true;
            this.lblIndeks.Location = new System.Drawing.Point(55, 87);
            this.lblIndeks.Name = "lblIndeks";
            this.lblIndeks.Size = new System.Drawing.Size(90, 17);
            this.lblIndeks.TabIndex = 28;
            this.lblIndeks.Text = "Broj indeksa:";
            // 
            // numGodinaStudija
            // 
            this.numGodinaStudija.Location = new System.Drawing.Point(154, 191);
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
            this.numGodinaStudija.TabIndex = 29;
            this.numGodinaStudija.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGodinaStudija
            // 
            this.lblGodinaStudija.AutoSize = true;
            this.lblGodinaStudija.Location = new System.Drawing.Point(42, 193);
            this.lblGodinaStudija.Name = "lblGodinaStudija";
            this.lblGodinaStudija.Size = new System.Drawing.Size(103, 17);
            this.lblGodinaStudija.TabIndex = 30;
            this.lblGodinaStudija.Text = "Godina studija:";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtkazi.Location = new System.Drawing.Point(255, 358);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 38;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // chkBudzet
            // 
            this.chkBudzet.AutoSize = true;
            this.chkBudzet.Checked = true;
            this.chkBudzet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBudzet.Location = new System.Drawing.Point(154, 275);
            this.chkBudzet.Name = "chkBudzet";
            this.chkBudzet.Size = new System.Drawing.Size(176, 21);
            this.chkBudzet.TabIndex = 31;
            this.chkBudzet.Text = "Finansiranje iz budžeta";
            this.chkBudzet.UseVisualStyleBackColor = true;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(149, 314);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(181, 22);
            this.dtpDatumRodjenja.TabIndex = 32;
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(35, 314);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(105, 17);
            this.lblDatumRodjenja.TabIndex = 33;
            this.lblDatumRodjenja.Text = "Datum rođenja:";
            // 
            // numProsek
            // 
            this.numProsek.DecimalPlaces = 2;
            this.numProsek.Location = new System.Drawing.Point(154, 233);
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
            this.numProsek.TabIndex = 35;
            this.numProsek.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(149, 358);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 37;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblProsek
            // 
            this.lblProsek.AutoSize = true;
            this.lblProsek.Location = new System.Drawing.Point(89, 235);
            this.lblProsek.Name = "lblProsek";
            this.lblProsek.Size = new System.Drawing.Size(56, 17);
            this.lblProsek.TabIndex = 36;
            this.lblProsek.Text = "Prosek:";
            // 
            // lblNivoStudija
            // 
            this.lblNivoStudija.AutoSize = true;
            this.lblNivoStudija.Location = new System.Drawing.Point(50, 127);
            this.lblNivoStudija.Name = "lblNivoStudija";
            this.lblNivoStudija.Size = new System.Drawing.Size(85, 17);
            this.lblNivoStudija.TabIndex = 39;
            this.lblNivoStudija.Text = "Nivo studija:";
            // 
            // cbxNivoStudija
            // 
            this.cbxNivoStudija.FormattingEnabled = true;
            this.cbxNivoStudija.Location = new System.Drawing.Point(154, 127);
            this.cbxNivoStudija.Name = "cbxNivoStudija";
            this.cbxNivoStudija.Size = new System.Drawing.Size(176, 24);
            this.cbxNivoStudija.TabIndex = 40;
            this.cbxNivoStudija.SelectedIndexChanged += new System.EventHandler(this.cbxNivoStudija_SelectedIndexChanged);
            // 
            // DijalogForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 396);
            this.Controls.Add(this.cbxNivoStudija);
            this.Controls.Add(this.lblNivoStudija);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.numBrojIndeksa);
            this.Controls.Add(this.lblIndeks);
            this.Controls.Add(this.numGodinaStudija);
            this.Controls.Add(this.lblGodinaStudija);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.chkBudzet);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.numProsek);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblProsek);
            this.Name = "DijalogForma";
            this.Text = "DijalogForma";
            ((System.ComponentModel.ISupportInitialize)(this.numBrojIndeksa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGodinaStudija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProsek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.NumericUpDown numBrojIndeksa;
        private System.Windows.Forms.Label lblIndeks;
        private System.Windows.Forms.NumericUpDown numGodinaStudija;
        private System.Windows.Forms.Label lblGodinaStudija;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.CheckBox chkBudzet;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.NumericUpDown numProsek;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblProsek;
        private System.Windows.Forms.Label lblNivoStudija;
        private System.Windows.Forms.ComboBox cbxNivoStudija;
    }
}