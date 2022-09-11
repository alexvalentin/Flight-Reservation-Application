using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mini_aplicatie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonPlateste_Click(object sender, EventArgs e)
        {
            if (textBoxDateCard.TextLength == 19 && textBoxCVV.TextLength ==3) 
                MessageBox.Show("Plata a fost aprobata cu succes!", "Valentin Fly");
            else
                MessageBox.Show("Datele nu sunt bine introduse! Incearca din nou.", "Valentin Fly");
        }

        private void buttonExitPay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCVV_TextChanged(object sender, EventArgs e)
        {
                        
        }

        private void textBoxCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled =  (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) )
            {
                errorProviderCVV.SetError(labelCvv, "Allow only numeric values!");

                labelCvv.Text = "Allow only numeric values!";
            }
            else
            {
                errorProviderCVV.SetError(labelCvv, "");
                labelCvv.Text = "";
            }
        }

        private void textBoxDateCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                )
            {
                errorProviderDataCard.SetError(labelDataCard, "Allow only numeric values!");

                labelDataCard.Text = "Allow only numeric values!";
            }
            else
            {
                errorProviderDataCard.SetError(labelDataCard, "");
                labelDataCard.Text = "";

                if ((textBoxDateCard.Text.Length == 4) && char.IsDigit(e.KeyChar))
                    textBoxDateCard.AppendText("-");
                if ((textBoxDateCard.Text.Length == 9) && char.IsDigit(e.KeyChar))
                    textBoxDateCard.AppendText("-");
                if ((textBoxDateCard.Text.Length == 14) && char.IsDigit(e.KeyChar))
                    textBoxDateCard.AppendText("-");
                /*
                if ((textBoxDateCard.Text.Length == 4) && char.IsControl(e.KeyChar))
                    textBoxDateCard.Text.Remove(textBoxDateCard.Text.Length - 2);
                if ((textBoxDateCard.Text.Length == 9) && char.IsControl(e.KeyChar))
                    textBoxDateCard.AppendText("-");
                if ((textBoxDateCard.Text.Length == 14) && char.IsControl(e.KeyChar))
                    textBoxDateCard.AppendText("-");
                */
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    
}
