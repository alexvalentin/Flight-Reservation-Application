using System;
using System.IO;
using System.Windows.Forms;

namespace Mini_aplicatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Blue Air");
            comboBox1.Items.Add("Wizz Air");
            comboBox1.Items.Add("Tarom");
            comboBox1.Items.Add("Turkish Airlines");
            comboBox1.Items.Add("Fly Emirates");
            comboBox1.Items.Add("Swiss");
            comboBox1.Items.Add("Lufthansa");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("calendar.png");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void alegeData_Click(object sender, EventArgs e)
        {
            String alegeData = monthCalendar1.SelectionStart.ToString();
            MessageBox.Show("Ati ales sa zbori in data de " + alegeData + ".");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            TimeSpan t = date2 - date1;

            double datetime = t.TotalDays;
            int days = Convert.ToInt32(datetime);
            textdeAfisat.Text = days.ToString() + " Days";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Load("calculatorzile.png");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // switch

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        String alegeZbor;
        String dataZbor;

        private void clasaI_CheckedChanged(object sender, EventArgs e)
        {
            alegeZbor = clasaI.Text;
        }

        private void clasaII_CheckedChanged(object sender, EventArgs e)
        {
            alegeZbor = businessClass.Text;
        }

        private void lowCost_CheckedChanged(object sender, EventArgs e)
        {
            alegeZbor = lowCost.Text;
        }

        private void calendarZbor_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataZbor = calendarZbor.SelectionStart.ToString();
        }

        private void buttonZbor_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("istoric_alegeri_zbor.txt", true); // true - append data to the file
            String firmaTransportAleasa = Convert.ToString(comboBox1.SelectedItem);

            //Boolean ok1;
            if ((checkBox1.Checked == true) && (comboBox1.SelectedItem != null) && !(calendarZbor.SelectionEnd <= DateTime.Now) && ((clasaI.Checked == true) || (businessClass.Checked == true) || (lowCost.Checked == true)))
            {
                MessageBox.Show("Ati ales " + firmaTransportAleasa + "-> " + alegeZbor + " in data de " + dataZbor + ".", "Valentin Fly");

                streamWriter.Write("Ati ales " + firmaTransportAleasa + "-> " + alegeZbor + " in data de " + dataZbor + ".\n");

                Form2 secondForm = new Form2();
                secondForm.Show();
            }

            else
                MessageBox.Show("Trebuie sa fiti de acord cu termenii si conditiile aplicatiei pentru a selecta avionul, clasa de zbor si data in care veti zbura.", "Eroare");

            streamWriter.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //firmaTransportAleasa = Convert.ToString(comboBox1.SelectedItem);

            String firmaTransportAleasa = Convert.ToString(comboBox1.SelectedItem);

            switch (firmaTransportAleasa)
            {
                case "Blue Air":
                    pictureBoxAvion.Load("blueair.jpg");
                    Console.Write(firmaTransportAleasa);
                    break;

                case "Wizz Air":
                    pictureBoxAvion.Load("wizzair.jpg");
                    Console.Write(firmaTransportAleasa);
                    break;

                case "Tarom":
                    pictureBoxAvion.Load("tarom.jpg");
                    Console.Write(firmaTransportAleasa);
                    break;

                case "Turkish Airlines":
                    pictureBoxAvion.Load("turkish.jpg");
                    Console.Write(firmaTransportAleasa);
                    break;

                case "Fly Emirates":
                    pictureBoxAvion.Load("emirates.jpg");
                    Console.Write(firmaTransportAleasa);
                    break;

                case "Lufthansa":
                    pictureBoxAvion.Load("lufthansa.jpg");
                    Console.Write(firmaTransportAleasa);
                    break;

                case "Swiss":
                    pictureBoxAvion.Load("swiss.jpg");
                    Console.Write(firmaTransportAleasa);
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void spreCalculator_Click(object sender, EventArgs e)
        {

            s.SelectTab("tabPage2");
        }

        private void spreCalendar_Click(object sender, EventArgs e)
        {
            s.SelectTab("tabPage3");
        }

        private void buttonHome1_Click(object sender, EventArgs e)
        {
            s.SelectTab("tabPage1");
        }

        private void buttonHome2_Click(object sender, EventArgs e)
        {
            s.SelectTab("tabPage1");
        }

        private void clasaZbor_Enter(object sender, EventArgs e)
        {
        }
    }
}

