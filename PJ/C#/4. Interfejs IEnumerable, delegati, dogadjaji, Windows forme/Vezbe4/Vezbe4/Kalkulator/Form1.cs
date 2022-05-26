using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJednako_Click(object sender, EventArgs e)
        {
            int rezultat;
            int op1;
            if (!Int32.TryParse(txtOperand1.Text, out op1))
                MessageBox.Show("Prvi operand nije validan celi broj");
            int op2;
            if (!Int32.TryParse(txtOperand2.Text, out op2))
                MessageBox.Show("Drugi operand nije validan celi broj");
            switch (txtOperacija.Text)
            {
                case "+":
                    rezultat = op1 + op2;
                    MessageBox.Show(rezultat.ToString());
                    break;
                case "*":
                    rezultat = op1 * op2;
                    MessageBox.Show(rezultat.ToString());
                    break;
                default:
                    MessageBox.Show("Operacija nije validna");
                    break;
            }
            

        }
    }
}
