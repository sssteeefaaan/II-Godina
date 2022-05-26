namespace PrvaWindowsAplikacija
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
            this.btnPrvoDugme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrvoDugme
            // 
            this.btnPrvoDugme.Location = new System.Drawing.Point(58, 46);
            this.btnPrvoDugme.Name = "btnPrvoDugme";
            this.btnPrvoDugme.Size = new System.Drawing.Size(98, 23);
            this.btnPrvoDugme.TabIndex = 0;
            this.btnPrvoDugme.Text = "Prvo dugme";
            this.btnPrvoDugme.UseVisualStyleBackColor = true;
            this.btnPrvoDugme.Click += new System.EventHandler(this.btnPrvoDugme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnPrvoDugme);
            this.Name = "Form1";
            this.Text = "Prva aplikacija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrvoDugme;
    }
}

