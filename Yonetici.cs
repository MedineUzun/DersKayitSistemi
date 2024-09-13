using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab_1
{
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        private void Yonetici_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yoneticigiris_Click(object sender, EventArgs e)
        {

            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;
            string isim = "Yönetici";
            string y_sifre = "y123";
            if (kullaniciadi == isim && sifre == y_sifre)
            {

                YoneticiGiris yoneticiGiris = new YoneticiGiris();
                yoneticiGiris.Show();

            }
            else
            {

                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }







        }

    }
}
