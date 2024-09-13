using Npgsql;
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
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }
        public long kullaniciadi { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "Yazlab1";
        private static string Password = "b123";
        private static string Port = "5432";

        private void ogrencigiris_Click(object sender, EventArgs e)
        {


            string connString =
               String.Format(
                   "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=prefer",
                   Host,
                   User,
                   DBname,
                   Port,
                   Password);

            string ka = textBox1.Text;
            kullaniciadi = Convert.ToInt64(ka);
            //string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connString))
            {
                baglanti.Open();

                string sorgu = "SELECT COUNT(*) FROM ogrencitablo WHERE ogrencinumarasi = @ogrenciid AND sifre = @sifre";

                using (NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@ogrenciid", kullaniciadi);
                    komut.Parameters.AddWithValue("@sifre", sifre);
                    long kullaniciSayisi = (long)komut.ExecuteScalar();

                  //  int kullaniciSayisi = (int)komut.ExecuteScalar();

                    if (kullaniciSayisi > 0)
                    {
                        // Kullanıcı adı ve şifre doğruysa OgrenciGiris formunu aç.
                        OgrenciGiris ogrenciGiris1 = new OgrenciGiris(kullaniciadi);
                        ogrenciGiris1.Show();
                    }
                    else
                    {
                        // Kullanıcı adı veya şifre yanlış.
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                    }
                }
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
