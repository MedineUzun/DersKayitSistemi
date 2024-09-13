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
    public partial class İlgialanigüncelle : Form
    {
        public İlgialanigüncelle()
        {
            InitializeComponent();
        }
        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "Yazlab1";
        private static string Password = "b123";
        private static string Port = "5432";
        private int ilgiid;
        private string ilgiisim;
        private void button1_Click(object sender, EventArgs e)
        {


            int.TryParse(textBox1.Text, out ilgiid);
           
            ilgiisim = textBox2.Text;
            


            string connString = String.Format("Host={0}; Username={1}; Database={2}; Port={3}; Password={4};", Host, User, DBname, Port, Password);

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (var command = new NpgsqlCommand("UPDATE ilgialanitablo SET ilgialani = @a WHERE ilgialaniid = @ilgiid", conn))
                    {
                        command.Parameters.AddWithValue("a", ilgiisim);
                        command.Parameters.AddWithValue("ilgiid", ilgiid);
                       


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
