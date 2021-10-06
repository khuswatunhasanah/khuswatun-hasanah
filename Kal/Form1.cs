using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb1.Items.Clear();
            cmb1.Items.Add("Penjumlahan");
            cmb1.Items.Add("Pengurangan");
            cmb1.Items.Add("Perkalian");
            cmb1.Items.Add("Pembagian");
        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
            double tnilaiA, tnilaiB, tBox3;

            if (cmb1.SelectedIndex == -1)
            {
                MessageBox.Show("oprator belum di plih..");
            }
            else if (cmb1.SelectedIndex == 0)
            {
                tnilaiA = Double.Parse(tBox1.Text);
                tnilaiB = Double.Parse(tBox2.Text);
                tBox3 = tnilaiA + tnilaiB;
                tBox3Teks.Text = tBox3.ToString();
            }
            else if (cmb1.SelectedIndex == 1)
            {
                tnilaiA = Double.Parse(tBox1.Text);
                tnilaiB = Double.Parse(tBox2.Text);
                tBox3 = tnilaiA - tnilaiB;
                tBox3Teks.Text = tBox3.ToString();
            }
            else if (cmb1.SelectedIndex == 2)
            {
                tnilaiA = Double.Parse(tBox1.Text);
                tnilaiB = Double.Parse(tBox2.Text);
                tBox3 = tnilaiA * tnilaiB;
                tBox3Teks.Text = tBox3.ToString();
            }
            else if (cmb1.SelectedIndex == 3)
            {
                tnilaiA = Double.Parse(tBox1.Text);
                tnilaiB = Double.Parse(tBox2.Text);
                tBox3 = tnilaiA / tnilaiB;
                tBox3Teks.Text = tBox3.ToString();


            }


        }

        private void thasil_Click(object sender, EventArgs e)
        {

        }

        private void tBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
