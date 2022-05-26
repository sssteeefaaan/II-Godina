namespace RecnikSinonima
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
            this.lblRecNaEngleskom = new System.Windows.Forms.Label();
            this.txtRecNaEngleskom = new System.Windows.Forms.TextBox();
            this.lbxRecNaEngleskom = new System.Windows.Forms.ListBox();
            this.btnDodajEngleski = new System.Windows.Forms.Button();
            this.btnDodajSrpski = new System.Windows.Forms.Button();
            this.lbxRecNaSrpskom = new System.Windows.Forms.ListBox();
            this.txtRecNaSrpskom = new System.Windows.Forms.TextBox();
            this.lblRecNaSrpskom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecNaEngleskom
            // 
            this.lblRecNaEngleskom.AutoSize = true;
            this.lblRecNaEngleskom.Location = new System.Drawing.Point(12, 9);
            this.lblRecNaEngleskom.Name = "lblRecNaEngleskom";
            this.lblRecNaEngleskom.Size = new System.Drawing.Size(129, 17);
            this.lblRecNaEngleskom.TabIndex = 0;
            this.lblRecNaEngleskom.Text = "Reč na engleskom:";
            // 
            // txtRecNaEngleskom
            // 
            this.txtRecNaEngleskom.Location = new System.Drawing.Point(12, 29);
            this.txtRecNaEngleskom.Name = "txtRecNaEngleskom";
            this.txtRecNaEngleskom.Size = new System.Drawing.Size(178, 22);
            this.txtRecNaEngleskom.TabIndex = 1;
            this.txtRecNaEngleskom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRecNaEngleskom_KeyDown);
            // 
            // lbxRecNaEngleskom
            // 
            this.lbxRecNaEngleskom.FormattingEnabled = true;
            this.lbxRecNaEngleskom.ItemHeight = 16;
            this.lbxRecNaEngleskom.Location = new System.Drawing.Point(12, 110);
            this.lbxRecNaEngleskom.Name = "lbxRecNaEngleskom";
            this.lbxRecNaEngleskom.Size = new System.Drawing.Size(178, 212);
            this.lbxRecNaEngleskom.TabIndex = 2;
            this.lbxRecNaEngleskom.SelectedIndexChanged += new System.EventHandler(this.lbxRecNaEngleskom_SelectedIndexChanged);
            // 
            // btnDodajEngleski
            // 
            this.btnDodajEngleski.Location = new System.Drawing.Point(12, 57);
            this.btnDodajEngleski.Name = "btnDodajEngleski";
            this.btnDodajEngleski.Size = new System.Drawing.Size(75, 32);
            this.btnDodajEngleski.TabIndex = 3;
            this.btnDodajEngleski.Text = "Dodaj";
            this.btnDodajEngleski.UseVisualStyleBackColor = true;
            this.btnDodajEngleski.Click += new System.EventHandler(this.btnDodajEngleski_Click);
            // 
            // btnDodajSrpski
            // 
            this.btnDodajSrpski.Location = new System.Drawing.Point(275, 57);
            this.btnDodajSrpski.Name = "btnDodajSrpski";
            this.btnDodajSrpski.Size = new System.Drawing.Size(75, 32);
            this.btnDodajSrpski.TabIndex = 7;
            this.btnDodajSrpski.Text = "Dodaj";
            this.btnDodajSrpski.UseVisualStyleBackColor = true;
            this.btnDodajSrpski.Click += new System.EventHandler(this.btnDodajSrpski_Click);
            // 
            // lbxRecNaSrpskom
            // 
            this.lbxRecNaSrpskom.FormattingEnabled = true;
            this.lbxRecNaSrpskom.ItemHeight = 16;
            this.lbxRecNaSrpskom.Location = new System.Drawing.Point(275, 110);
            this.lbxRecNaSrpskom.Name = "lbxRecNaSrpskom";
            this.lbxRecNaSrpskom.Size = new System.Drawing.Size(178, 212);
            this.lbxRecNaSrpskom.TabIndex = 6;
            // 
            // txtRecNaSrpskom
            // 
            this.txtRecNaSrpskom.Location = new System.Drawing.Point(275, 29);
            this.txtRecNaSrpskom.Name = "txtRecNaSrpskom";
            this.txtRecNaSrpskom.Size = new System.Drawing.Size(178, 22);
            this.txtRecNaSrpskom.TabIndex = 5;
            this.txtRecNaSrpskom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRecNaSrpskom_KeyDown);
            // 
            // lblRecNaSrpskom
            // 
            this.lblRecNaSrpskom.AutoSize = true;
            this.lblRecNaSrpskom.Location = new System.Drawing.Point(275, 9);
            this.lblRecNaSrpskom.Name = "lblRecNaSrpskom";
            this.lblRecNaSrpskom.Size = new System.Drawing.Size(114, 17);
            this.lblRecNaSrpskom.TabIndex = 4;
            this.lblRecNaSrpskom.Text = "Reč na srpskom:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 367);
            this.Controls.Add(this.btnDodajSrpski);
            this.Controls.Add(this.lbxRecNaSrpskom);
            this.Controls.Add(this.txtRecNaSrpskom);
            this.Controls.Add(this.lblRecNaSrpskom);
            this.Controls.Add(this.btnDodajEngleski);
            this.Controls.Add(this.lbxRecNaEngleskom);
            this.Controls.Add(this.txtRecNaEngleskom);
            this.Controls.Add(this.lblRecNaEngleskom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecNaEngleskom;
        private System.Windows.Forms.TextBox txtRecNaEngleskom;
        private System.Windows.Forms.ListBox lbxRecNaEngleskom;
        private System.Windows.Forms.Button btnDodajEngleski;
        private System.Windows.Forms.Button btnDodajSrpski;
        private System.Windows.Forms.ListBox lbxRecNaSrpskom;
        private System.Windows.Forms.TextBox txtRecNaSrpskom;
        private System.Windows.Forms.Label lblRecNaSrpskom;
    }
}

