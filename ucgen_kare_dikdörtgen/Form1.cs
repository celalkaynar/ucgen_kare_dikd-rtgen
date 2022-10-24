using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucgen_kare_dikdörtgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";

            textBox5.Text = "";
            label8.Text = "";

            textBox3.Text = "";
            textBox4.Text = "";
            label6.Text = "";

            groupBox2.Visible = true;
            groupBox1.Visible = false;
            groupBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dik_kısa = Convert.ToInt16(textBox3.Text);
            int dik_uzun = Convert.ToInt16(textBox4.Text);
            string dik = Convert.ToString(dik_uzun * dik_kısa);
            label6.Text = dik;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";

            textBox5.Text = "";
            label8.Text = "";

            textBox3.Text = "";
            textBox4.Text = "";
            label6.Text = "";

            groupBox3.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";

            textBox5.Text = "";
            label8.Text = "";

            textBox3.Text = "";
            textBox4.Text = "";
            label6.Text = "";

            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int taban = Convert.ToInt16(textBox1.Text);
            int yükseklik = Convert.ToInt16(textBox2.Text);
            string ucgen = Convert.ToString(taban * yükseklik / 2);
            label3.Text = ucgen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kare_kenar = Convert.ToInt16(textBox5.Text);
            string kare = Convert.ToString(kare_kenar * kare_kenar);
            label8.Text = kare;
        }
    }
}
