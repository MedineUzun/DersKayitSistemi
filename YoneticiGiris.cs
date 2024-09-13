using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YazLab_1
{
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
        }

        private void YoneticiGiris_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            OgrenciEklecs ogrenciEkle1 = new OgrenciEklecs();
            ogrenciEkle1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciSil ogrenciSil1 = new OgrenciSil();
            ogrenciSil1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgrenciGuncelle ogrenciGuncelle1 = new OgrenciGuncelle();
            ogrenciGuncelle1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgretmenEkle ogretmenEkle1 = new OgretmenEkle();
            ogretmenEkle1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OgretmenSil ogretmenSil1 = new OgretmenSil();
            ogretmenSil1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OgretmenGuncelle ogretmenGuncelle1 = new OgretmenGuncelle();
            ogretmenGuncelle1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {


            İlgialaniekle ilgialaniekle = new İlgialaniekle();
            ilgialaniekle.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            İlgialanisil ilgialanisil = new İlgialanisil();
            ilgialanisil.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            İlgialanigüncelle ilgialaniguncelle = new İlgialanigüncelle();
            ilgialaniguncelle.Show();
        }



        private void button7_Click(object sender, EventArgs e)
        {



            Ogrencilistele ogrencilistele = new Ogrencilistele();
            ogrencilistele.Show();



        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ogretmenlistele ogretmenlistele = new Ogretmenlistele();
            ogretmenlistele.Show();
        }
    }
}
