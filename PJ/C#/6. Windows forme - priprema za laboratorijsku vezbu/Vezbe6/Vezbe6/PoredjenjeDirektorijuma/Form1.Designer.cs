namespace PoredjenjeDirektorijuma
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
            this.gbxPrviDirektorijum = new System.Windows.Forms.GroupBox();
            this.lbxPrviFajlovi = new System.Windows.Forms.ListBox();
            this.btnIzaberiPrviDirektorijum = new System.Windows.Forms.Button();
            this.txtPrviDirektorijum = new System.Windows.Forms.TextBox();
            this.gbxDrugiDirektorijum = new System.Windows.Forms.GroupBox();
            this.lbxDrugiFajlovi = new System.Windows.Forms.ListBox();
            this.btnIzaberiDrugiDirektorijum = new System.Windows.Forms.Button();
            this.txtDrugiDirektorijum = new System.Windows.Forms.TextBox();
            this.fbdIzaberiDirektorijum = new System.Windows.Forms.FolderBrowserDialog();
            this.btnPronadjiIste = new System.Windows.Forms.Button();
            this.lbxIstiFajlovi = new System.Windows.Forms.ListBox();
            this.gbxPrviDirektorijum.SuspendLayout();
            this.gbxDrugiDirektorijum.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPrviDirektorijum
            // 
            this.gbxPrviDirektorijum.Controls.Add(this.lbxPrviFajlovi);
            this.gbxPrviDirektorijum.Controls.Add(this.btnIzaberiPrviDirektorijum);
            this.gbxPrviDirektorijum.Controls.Add(this.txtPrviDirektorijum);
            this.gbxPrviDirektorijum.Location = new System.Drawing.Point(12, 12);
            this.gbxPrviDirektorijum.Name = "gbxPrviDirektorijum";
            this.gbxPrviDirektorijum.Size = new System.Drawing.Size(340, 317);
            this.gbxPrviDirektorijum.TabIndex = 0;
            this.gbxPrviDirektorijum.TabStop = false;
            this.gbxPrviDirektorijum.Text = "Prvi direktorijum";
            // 
            // lbxPrviFajlovi
            // 
            this.lbxPrviFajlovi.FormattingEnabled = true;
            this.lbxPrviFajlovi.HorizontalScrollbar = true;
            this.lbxPrviFajlovi.ItemHeight = 16;
            this.lbxPrviFajlovi.Location = new System.Drawing.Point(7, 82);
            this.lbxPrviFajlovi.Name = "lbxPrviFajlovi";
            this.lbxPrviFajlovi.Size = new System.Drawing.Size(327, 228);
            this.lbxPrviFajlovi.TabIndex = 2;
            // 
            // btnIzaberiPrviDirektorijum
            // 
            this.btnIzaberiPrviDirektorijum.Location = new System.Drawing.Point(6, 21);
            this.btnIzaberiPrviDirektorijum.Name = "btnIzaberiPrviDirektorijum";
            this.btnIzaberiPrviDirektorijum.Size = new System.Drawing.Size(144, 26);
            this.btnIzaberiPrviDirektorijum.TabIndex = 1;
            this.btnIzaberiPrviDirektorijum.Text = "Izaberi direktorijum";
            this.btnIzaberiPrviDirektorijum.UseVisualStyleBackColor = true;
            this.btnIzaberiPrviDirektorijum.Click += new System.EventHandler(this.btnIzaberiPrviDirektorijum_Click);
            // 
            // txtPrviDirektorijum
            // 
            this.txtPrviDirektorijum.Enabled = false;
            this.txtPrviDirektorijum.Location = new System.Drawing.Point(6, 53);
            this.txtPrviDirektorijum.Name = "txtPrviDirektorijum";
            this.txtPrviDirektorijum.Size = new System.Drawing.Size(328, 22);
            this.txtPrviDirektorijum.TabIndex = 0;
            // 
            // gbxDrugiDirektorijum
            // 
            this.gbxDrugiDirektorijum.Controls.Add(this.lbxDrugiFajlovi);
            this.gbxDrugiDirektorijum.Controls.Add(this.btnIzaberiDrugiDirektorijum);
            this.gbxDrugiDirektorijum.Controls.Add(this.txtDrugiDirektorijum);
            this.gbxDrugiDirektorijum.Location = new System.Drawing.Point(376, 12);
            this.gbxDrugiDirektorijum.Name = "gbxDrugiDirektorijum";
            this.gbxDrugiDirektorijum.Size = new System.Drawing.Size(340, 317);
            this.gbxDrugiDirektorijum.TabIndex = 1;
            this.gbxDrugiDirektorijum.TabStop = false;
            this.gbxDrugiDirektorijum.Text = "Drugi direktorijum";
            // 
            // lbxDrugiFajlovi
            // 
            this.lbxDrugiFajlovi.FormattingEnabled = true;
            this.lbxDrugiFajlovi.HorizontalScrollbar = true;
            this.lbxDrugiFajlovi.ItemHeight = 16;
            this.lbxDrugiFajlovi.Location = new System.Drawing.Point(7, 82);
            this.lbxDrugiFajlovi.Name = "lbxDrugiFajlovi";
            this.lbxDrugiFajlovi.Size = new System.Drawing.Size(327, 228);
            this.lbxDrugiFajlovi.TabIndex = 2;
            // 
            // btnIzaberiDrugiDirektorijum
            // 
            this.btnIzaberiDrugiDirektorijum.Location = new System.Drawing.Point(6, 21);
            this.btnIzaberiDrugiDirektorijum.Name = "btnIzaberiDrugiDirektorijum";
            this.btnIzaberiDrugiDirektorijum.Size = new System.Drawing.Size(144, 26);
            this.btnIzaberiDrugiDirektorijum.TabIndex = 1;
            this.btnIzaberiDrugiDirektorijum.Text = "Izaberi direktorijum";
            this.btnIzaberiDrugiDirektorijum.UseVisualStyleBackColor = true;
            this.btnIzaberiDrugiDirektorijum.Click += new System.EventHandler(this.btnIzaberiDrugiDirektorijum_Click);
            // 
            // txtDrugiDirektorijum
            // 
            this.txtDrugiDirektorijum.Enabled = false;
            this.txtDrugiDirektorijum.Location = new System.Drawing.Point(6, 53);
            this.txtDrugiDirektorijum.Name = "txtDrugiDirektorijum";
            this.txtDrugiDirektorijum.Size = new System.Drawing.Size(328, 22);
            this.txtDrugiDirektorijum.TabIndex = 0;
            // 
            // btnPronadjiIste
            // 
            this.btnPronadjiIste.Location = new System.Drawing.Point(19, 351);
            this.btnPronadjiIste.Name = "btnPronadjiIste";
            this.btnPronadjiIste.Size = new System.Drawing.Size(154, 26);
            this.btnPronadjiIste.TabIndex = 2;
            this.btnPronadjiIste.Text = "Pronađi iste fajlove";
            this.btnPronadjiIste.UseVisualStyleBackColor = true;
            this.btnPronadjiIste.Click += new System.EventHandler(this.btnPronadjiIste_Click);
            // 
            // lbxIstiFajlovi
            // 
            this.lbxIstiFajlovi.FormattingEnabled = true;
            this.lbxIstiFajlovi.ItemHeight = 16;
            this.lbxIstiFajlovi.Location = new System.Drawing.Point(199, 351);
            this.lbxIstiFajlovi.Name = "lbxIstiFajlovi";
            this.lbxIstiFajlovi.Size = new System.Drawing.Size(327, 196);
            this.lbxIstiFajlovi.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 591);
            this.Controls.Add(this.lbxIstiFajlovi);
            this.Controls.Add(this.btnPronadjiIste);
            this.Controls.Add(this.gbxDrugiDirektorijum);
            this.Controls.Add(this.gbxPrviDirektorijum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxPrviDirektorijum.ResumeLayout(false);
            this.gbxPrviDirektorijum.PerformLayout();
            this.gbxDrugiDirektorijum.ResumeLayout(false);
            this.gbxDrugiDirektorijum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPrviDirektorijum;
        private System.Windows.Forms.ListBox lbxPrviFajlovi;
        private System.Windows.Forms.Button btnIzaberiPrviDirektorijum;
        private System.Windows.Forms.TextBox txtPrviDirektorijum;
        private System.Windows.Forms.GroupBox gbxDrugiDirektorijum;
        private System.Windows.Forms.ListBox lbxDrugiFajlovi;
        private System.Windows.Forms.Button btnIzaberiDrugiDirektorijum;
        private System.Windows.Forms.TextBox txtDrugiDirektorijum;
        private System.Windows.Forms.FolderBrowserDialog fbdIzaberiDirektorijum;
        private System.Windows.Forms.Button btnPronadjiIste;
        private System.Windows.Forms.ListBox lbxIstiFajlovi;
    }
}

