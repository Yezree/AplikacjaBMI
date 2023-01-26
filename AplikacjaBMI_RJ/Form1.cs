using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaBMI_RJ
{
    public partial class Form1 : Form
    {
        double h;
        double w;
        double t;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.bMI_WynikiTableAdapter.Fill(this.bMIDataSet._BMI_Wyniki);

            this.bMI_WiekTableAdapter.Fill(this.bMIDataSet._BMI_Wiek);

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            waga.Clear();
            wzrost.Clear();
            BMILabel.Text = "";
            BMILabel.BackColor = Color.White;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            BMILabel.BackColor = Color.White;
            try
            {
                h = Double.Parse(wzrost.Text);
                w = Double.Parse(waga.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Nieprawidłowe dane. Proszę użyć ',' jako separatora dziesiętnego. Prosimy kliknąć RESET");
                return;
            }

            t = w / (h * h);
            BMILabel.Text = String.Format("{0:f}", t);

            if (t <= 23.9)
            {
                BMILabel.BackColor = Color.PowderBlue;
            }
            else if (t <= 27.9)
            {
                BMILabel.BackColor = Color.Blue;
            }
            else if (t <= 32.9)
            {
                BMILabel.BackColor = Color.Yellow;
            }
            else if (t <= 37.9)
            {
                BMILabel.BackColor = Color.Red;
            }
            else if (t <= 40.9)
            {
                BMILabel.BackColor = Color.DarkRed;
            }
            else if (t >= 40.9)
            {
                BMILabel.BackColor = Color.DarkRed;
            }

            if (t < 16.0)
            {
                label4.Text = "wyglodzenie";
            }
            else if (t <= 16.9)
            {
                label4.Text = "wychudzenie";
            }
            else if (t <= 18.49)
            {
                label4.Text = "niedowaga";
            }
            else if (t <= 24.99)
            {
                label4.Text = "waga prawidłowa";
            }
            else if (t <= 29.9)
            {
                label4.Text = "nadwaga";
            }
            else if (t <= 34.99)
            {
                label4.Text = "I stopien otylosci";
            }
            else if (t <= 39.99)
            {
                label4.Text = "II stopien otylosci";
            }
            else if (t >= 40.0)
            {
                label4.Text = "Otylosc skrajna";
            }

        }

        private void wzrost_TextChanged(object sender, EventArgs e)
        {
        }

        private void BMILabel_Click(object sender, EventArgs e)
        {
        }

        private void BMILabel_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Body_mass_index");
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 153, 153);
            this.label4.ForeColor = Color.FromArgb(0, 153, 0);
            this.label1.ForeColor = Color.FromArgb(0, 153, 0);
            this.BMILabel.ForeColor = Color.FromArgb(0, 153, 0);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.BMILabel.ForeColor = Color.Black;
            this.label4.BackColor = Color.DarkGray;
            this.button1.BackColor = Color.YellowGreen;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
