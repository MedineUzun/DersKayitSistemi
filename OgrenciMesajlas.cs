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
    public partial class OgrenciMesajlas : Form
    {
        private long kullaniciAdi;
        public OgrenciMesajlas(long kullaniciadi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciadi;
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
            string ogretmen = textBox1.Text;


            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM mesajtablo WHERE ogrencinumara = @kullaniciAdi AND ogretmenadi=@ogretmen;";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("ogretmen", ogretmen);
                    command.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);

                    long count = (long)command.ExecuteScalar();
                    if (count == 0)
                    {
                        string query2 = "INSERT INTO mesajtablo (ogretmenadi, ogrencinumara) VALUES (@ogretmen,@kullaniciAdi);";
                        using (NpgsqlCommand command2 = new NpgsqlCommand(query2, connection))
                        {
                            command2.Parameters.AddWithValue("ogretmen", ogretmen);
                            command2.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);
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


        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();
                string query = "SELECT ogretmenadi, ogretmenmesaj FROM mesajtablo WHERE ogrencinumara = @kullaniciadi;";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi); 

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                                             
                        dataGridView1.DataSource = table;
                    }
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mesaj.Add(textBox2.Text);
            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();
                string query2 = "UPDATE mesajtablo SET ogrencimesaj = @mesaj WHERE ogrencinumara = @kullaniciAdi;";
                using (NpgsqlCommand command = new NpgsqlCommand(query2, connection))
                {

                    using (NpgsqlCommand command2 = new NpgsqlCommand(query2, connection))
                    {
                        command2.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);
                        command2.Parameters.AddWithValue("mesaj", mesaj);
                        command2.ExecuteNonQuery();

                    }

                    connection.Close();
                }
            }
        }
        }
    }