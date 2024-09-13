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
    public partial class OgrenciGuncelle : Form
    {
        public OgrenciGuncelle()
        {
            InitializeComponent();
        }
        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "Yazlab1";
        private static string Password = "b123";
        private static string Port = "5432";
        private int ogrencino;
        private string ilgialani;
        private int anlasmatalepsayisi;
        private int anlasmadurumu;
        private void button1_Click(object sender, EventArgs e)
        {


            int.TryParse(textBox1.Text, out ogrencino);
            ilgialani = textBox2.Text;
            int.TryParse(textBox3.Text, out anlasmatalepsayisi);
            int.TryParse(textBox4.Text, out anlasmadurumu);




            string connString = String.Format("Host={0}; Username={1}; Database={2}; Port={3}; Password={4};", Host, User, DBname, Port, Password);

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (var command = new NpgsqlCommand("UPDATE ogrencitablo SET ilgialani = @a,  anlasmatalepsayisi = @b ,anlasmadurumu = @c WHERE ogrencinumarasi = @ogrencino", conn))
                    {
                        command.Parameters.AddWithValue("a", ilgialani);
                        command.Parameters.AddWithValue("b", anlasmatalepsayisi);
                        command.Parameters.AddWithValue("c", anlasmadurumu);
                        command.Parameters.AddWithValue("ogrencino", ogrencino);

                        int nRows = command.ExecuteNonQuery();
                        MessageBox.Show(string.Format("Güncellenen satır sayısı: {0}", nRows));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
        }


    }
    }

