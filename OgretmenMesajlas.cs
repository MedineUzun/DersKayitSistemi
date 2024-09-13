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
    public partial class OgretmenMesajlas : Form
    {
        private string ogretmenAdi;
        public OgretmenMesajlas(string ogretmenadi)
        {
            InitializeComponent();
            this.ogretmenAdi = ogretmenadi;
        }
        List<string> mesaj = new List<string>();


        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "Yazlab1";
        private static string Password = "b123";
        private static string Port = "5432";

        string connString =
           String.Format(
               "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=prefer",
               Host,
               User,
               DBname,
               Port,
               Password);


        private void button1_Click(object sender, EventArgs e)
        {
            string ogrencii = textBox1.Text;
            long ogrenci = Convert.ToInt64(ogrencii);


            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM mesajtablo WHERE ogrencinumara = @ogrenci AND ogretmenadi=@ogretmenadi;";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("ogrenci", ogrenci);
                    command.Parameters.AddWithValue("ogretmenadi", ogretmenAdi);

                    long count = (long)command.ExecuteScalar();
                    if (count == 0)
                    {
                        string query2 = "INSERT INTO mesajtablo (ogretmenadi, ogrencinumara) VALUES (@ogretmenadi,@ogrenci);";
                        using (NpgsqlCommand command2 = new NpgsqlCommand(query2, connection))
                        {
                            command2.Parameters.AddWithValue("ogrenci", ogrenci);
                            command2.Parameters.AddWithValue("ogretmenadi", ogretmenAdi);

                            command2.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    else
                    {
                        connection.Close();

                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ogrencii = textBox1.Text;
            long ogrenci = Convert.ToInt64(ogrencii);
            mesaj.Add(textBox2.Text);
            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();

                string query2 = "UPDATE mesajtablo SET ogretmenmesaj = @mesaj WHERE ogretmenadi = @ogretmenAdi AND ogrencinumara = @ogrenci;";


                using (NpgsqlCommand command2 = new NpgsqlCommand(query2, connection))
                {
                    command2.Parameters.AddWithValue("ogretmenAdi", ogretmenAdi);
                    command2.Parameters.AddWithValue("ogrenci", ogrenci);
                    command2.Parameters.AddWithValue("mesaj", mesaj);
                    command2.ExecuteNonQuery();

                }

                connection.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();

                string query = "SELECT ogrencinumara, ogrencimesaj FROM mesajtablo WHERE ogretmenadi = @ogretmenAdi;";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ogretmenAdi", ogretmenAdi); // Parametreyi düzgün şekilde tanımla

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table); // Verileri veritabanından çek ve DataTable'a doldur
                                             // DataGridView kontrolünü verilere bağla
                        dataGridView1.DataSource = table;
                    }
                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }


}