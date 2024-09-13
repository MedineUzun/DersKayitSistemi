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
    public partial class İlgialanisil : Form
    {
        public İlgialanisil()
        {
            InitializeComponent();
        }
        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "Yazlab1";
        private static string Password = "b123";
        private static string Port = "5432";
        private int ilgiid;
        

        private void button1_Click(object sender, EventArgs e)
        {


            int.TryParse(textBox1.Text, out ilgiid);
           


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
                    using (var command = new NpgsqlCommand("DELETE FROM ilgialanitablo WHERE ilgialaniid = @ilgiid", conn))
                    {
                        command.Parameters.AddWithValue("ilgiid", ilgiid);


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

