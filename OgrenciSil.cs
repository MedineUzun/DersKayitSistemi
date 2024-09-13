using Npgsql;
using System;
using System.Windows.Forms;

namespace YazLab_1
{
    public partial class OgrenciSil : Form
    {
        public OgrenciSil()
        {
            InitializeComponent();
        }
         
        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "Yazlab1";
        private static string Password = "b123";
        private static string Port = "5432";
        private int numara;

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out numara))
            {
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
                        using (var command = new NpgsqlCommand("DELETE FROM ogrencitablo WHERE ogrencinumarasi = @numara", conn))
                        {
                            command.Parameters.AddWithValue("numara", numara);
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
            else
            {
                MessageBox.Show("Geçersiz öğrenci numarası.");
            }
        }
    }
}
