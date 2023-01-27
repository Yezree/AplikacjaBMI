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

              if (t <= 15.99)
            {
                BMILabel.BackColor = Color.PowderBlue;
            }
            else if (t <= 18.5)
            {
                BMILabel.BackColor = Color.Blue;
            }
            else if (t <= 24.49)
            {
                BMILabel.BackColor = Color.Yellow;
            }
            else if (t <= 29.99)
            {
                BMILabel.BackColor = Color.Red;
            }
            else if (t <= 34.99)
            {
                BMILabel.BackColor = Color.DarkRed;
            }
            else if (t >= 40.99)
            {
                BMILabel.BackColor = Color.DarkRed;
            }
            else if (t >= 44.99)
            {
                BMILabel.BackColor = Color.DarkRed;
            }
            else if (t >= 45.0)
            {
                BMILabel.BackColor = Color.DarkRed;
            }

            if (t < 15.99)
            {
               MessageBox.Show("Ekstremalna niedowaga oznacza, że BMI jest poniżej 16. Osoby z ekstremalną niedowagą mają znacznie zbyt mało masy ciała w stosunku do swojego wzrostu i mogą być bardzo słabe i osłabione. Mogą mieć trudności z utrzymaniem temperatury ciała, a ich odporność jest bardzo słaba. Mogą cierpieć na anemia, trudności z trawieniem, a także problemy hormonalne. Ekstremalna niedowaga jest poważnym problemem zdrowotnym, który wymaga natychmiastowej pomocy medycznej.");
                return;
            }
            else if (t <= 18.5)
            {
                MessageBox.Show("Niedowaga: BMI poniżej 18,5 oznacza, że dana osoba ma zbyt mało masy ciała w stosunku do swojego wzrostu. Osoby z niedowagą mogą mieć trudności z utrzymaniem temperatury ciała, mieć słabszą odporność, mniejszą wytrzymałość i większe ryzyko chorób.");
                return;
            }
            else if (t <= 24.49)
            {
                MessageBox.Show("Norma wagowa: BMI od 18,5 do 24,9 oznacza, że dana osoba ma prawidłową masę ciała w stosunku do swojego wzrostu. Osoby z normą wagową mają najniższe ryzyko zdrowotne związane z masą ciała.");
                return;
            }
            else if (t <= 29.99)
            {
                 MessageBox.Show("Nadwaga: BMI od 25 do 29,9 oznacza, że dana osoba ma nadmierną masę ciała w stosunku do swojego wzrostu. Osoby z nadwagą mogą mieć większe ryzyko chorób serca, cukrzycy i innych schorzeń związanych z masą ciała.");
                return;
            }
            else if (t <= 34.99)
            {
                 MessageBox.Show("I stopień otyłości: BMI od 30 do 34,9 oznacza, że dana osoba jest otyła i ma zwiększone ryzyko chorób serca, cukrzycy i innych schorzeń związanych z masą ciała.");
                return;
            }
            else if (t <= 40.99)
            {
                 MessageBox.Show("II stopień otyłości: BMI od 35 do 39,9 oznacza, że dana osoba jest ciężko otyła i ma zwiększone ryzyko chorób serca, cukrzycy, udaru mózgu i innych schorzeń związanych z masą ciała.");
                return;
            }
            else if (t <= 44.99)
            {
                 MessageBox.Show("III stopień otyłości (otyłość skrajna): BMI powyżej 40 oznacza, że dana osoba jest bardzo ciężko otyła i ma bardzo wysokie ryzyko chorób serca, cukrzycy, udaru mózgu i innych schorzeń związanych z masą ciała.");
                return;
            }
            else if (t >= 45.0)
            {
                MessageBox.Show("Otyłość typu androidalnego (otyłość brzucha): Jest to rodzaj otyłości, w którym tłuszcz gromadzi się głównie w okolicach brzucha.");
                return;
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
