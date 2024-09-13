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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YazLab_1
{
    public partial class OgretmenEkle : Form
    {
        public OgretmenEkle()
        {
            InitializeComponent();
        }

        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "Yazlab1";
        private static string Password = "b123";
        private static string Port = "5432";
        private int sicilno;
        private string isim;
        private string soyisim;
        private string sifre;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out sicilno);
            isim = textBox2.Text;
            soyisim = textBox3.Text;
            sifre = textBox4.Text;

            string connString =
                String.Format(
                    "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    Console.Out.WriteLine("Opening connection");
                    conn.Open();
                    using (var command = new NpgsqlCommand("INSERT INTO ogretmentablo (sicilnumarasi,isim, soyisim, sifre) VALUES (@a,@b, @c, @d)", conn))
                    {
                        command.Parameters.AddWithValue("a", sicilno);
                        command.Parameters.AddWithValue("b", isim);
                        command.Parameters.AddWithValue("c", soyisim);
                        command.Parameters.AddWithValue("d", sifre);

                        int nRows = command.ExecuteNonQuery();
                        Console.Out.WriteLine(String.Format("Number of rows updated={0}", nRows));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
   }
