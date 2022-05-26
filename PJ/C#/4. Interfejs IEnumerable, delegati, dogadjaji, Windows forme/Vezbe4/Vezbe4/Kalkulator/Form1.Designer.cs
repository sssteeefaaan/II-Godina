namespace Kalkulator
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
            this.lblOperand1 = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.lblOperand2 = new System.Windows.Forms.Label();
            this.txtOperacija = new System.Windows.Forms.TextBox();
            this.lblOperacija = new System.Windows.Forms.Label();
            this.btnJednako = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOperand1
            // 
            this.lblOperand1.AutoSize = true;
            this.lblOperand1.Location = new System.Drawing.Point(27, 22);
            this.lblOperand1.Name = "lblOperand1";
            this.lblOperand1.Size = new System.Drawing.Size(80, 17);
            this.lblOperand1.TabIndex = 0;
            this.lblOperand1.Text = "Operand 1:";
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(113, 19);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 22);
            this.txtOperand1.TabIndex = 1;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(113, 71);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 22);
            this.txtOperand2.TabIndex = 3;
            // 
            // lblOperand2
            // 
            this.lblOperand2.AutoSize = true;
            this.lblOperand2.Location = new System.Drawing.Point(27, 74);
            this.lblOperand2.Name = "lblOperand2";
            this.lblOperand2.Size = new System.Drawing.Size(80, 17);
            this.lblOperand2.TabIndex = 2;
            this.lblOperand2.Text = "Operand 2:";
            // 
            // txtOperacija
            // 
            this.txtOperacija.Location = new System.Drawing.Point(113, 123);
            this.txtOperacija.Name = "txtOperacija";
            this.txtOperacija.Size = new System.Drawing.Size(100, 22);
            this.txtOperacija.TabIndex = 5;
            // 
            // lblOperacija
            // 
            this.lblOperacija.AutoSize = true;
            this.lblOperacija.Location = new System.Drawing.Point(27, 126);
            this.lblOperacija.Name = "lblOperacija";
            this.lblOperacija.Size = new System.Drawing.Size(69, 17);
            this.lblOperacija.TabIndex = 4;
            this.lblOperacija.Text = "Operacija";
            // 
            // btnJednako
            // 
            this.btnJednako.Location = new System.Drawing.Point(113, 167);
            this.btnJednako.Name = "btnJednako";
            this.btnJednako.Size = new System.Drawing.Size(100, 23);
            this.btnJednako.TabIndex = 6;
            this.btnJednako.Text = "=";
            this.btnJednako.UseVisualStyleBackColor = true;
            this.btnJednako.Click += new System.EventHandler(this.btnJednako_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 253);
            this.Controls.Add(this.btnJednako);
            this.Controls.Add(this.txtOperacija);
            this.Controls.Add(this.lblOperacija);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.lblOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.lblOperand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperand1;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Label lblOperand2;
        private System.Windows.Forms.TextBox txtOperacija;
        private System.Windows.Forms.Label lblOperacija;
        private System.Windows.Forms.Button btnJednako;
    }
}

