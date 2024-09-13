using System;
using System.Windows.Forms;
using Npgsql;

namespace YazLab_1
{
    public partial class OgrenciEklecs : Form
    {
        public OgrenciEklecs()
        {
            InitializeComponent();
        }

        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "Yazlab1";
        private static string Password = "b123";
        private static string Port = "5432";
        private int numara;
        private string isim;
        private string soyisim;
        private string ilgialani;
        private string sifre;
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            int.TryParse(textBox1.Text, out numara);
            isim = textBox2.Text;
            soyisim = textBox3.Text;
            ilgialani = textBox4.Text;
            sifre = textBox5.Text;

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
                    using (var command = new NpgsqlCommand("INSERT INTO ogrencitablo (ogrencinumarasi,isim, soyisim, ilgialani, sifre) VALUES (@a,@b, @c, @d, @e)", conn))
                    {
                        command.Parameters.AddWithValue("a", numara);
                        command.Parameters.AddWithValue("b", isim);
                        command.Parameters.AddWithValue("c", soyisim);
                        command.Parameters.AddWithValue("d", ilgialani);
                        command.Parameters.AddWithValue("e", sifre);

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
