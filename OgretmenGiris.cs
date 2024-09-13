using Microsoft.VisualBasic.ApplicationServices;
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
using System.Xml.Linq;
using NpgsqlTypes;
using iText.Layout.Element;

namespace YazLab_1
{
    public partial class OgretmenGiris : Form
    {

        private string o_isim;
        private string ogretmenAdi;
        public OgretmenGiris(string deger, string ogretmenadi)
        {
            InitializeComponent();
            o_isim = deger;
            this.ogretmenAdi = ogretmenadi;

        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "Yazlab1";
        private static string Password = "b123";
        private static string Port = "5432";
        string checkedItem;
        string connString =
               String.Format(
                   "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=prefer",
                   Host,
                   User,
                   DBname,
                   Port,
                   Password);

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int itemIndex = e.Index;
            bool isChecked = (e.NewValue == CheckState.Checked);
            checkedItem = checkedListBox1.GetItemText(checkedListBox1.Items[itemIndex]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            using (NpgsqlConnection baglanti = new NpgsqlConnection(connString))
            {
                try
                {
                    baglanti.Open();

                    string checkedItem = checkedListBox1.GetItemText(checkedListBox1.SelectedItem);

                    using (NpgsqlConnection connection = new NpgsqlConnection(connString))
                    {
                        connection.Open();
                        string updateQuery = "UPDATE ogretmentablo SET ilgialani = @isChecked WHERE isim = @ogretmenadi";


                        using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@isChecked", checkedItem);
                            command.Parameters.AddWithValue("@ogretmenadi", ogretmenAdi);

                            int etkilenenSatirSayisi = command.ExecuteNonQuery();

                            if (etkilenenSatirSayisi > 0)
                            {
                                MessageBox.Show("Veri başarıyla eklendi.");
                            }
                            else
                            {
                                MessageBox.Show("Veri eklenirken bir hata oluştu.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // derse talep olustutran ogrencılerı yazdırma kodu 


            dataGridView1.DataSource = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();


                string query = "SELECT isim ,ogrencinumarasi FROM ogrencitablo WHERE anlasmadurumu = 1;";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                    }
                }

                connection.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();

                string query = "UPDATE derstaleptablo SET anlasmadurumu = 2 WHERE ogrenciid IN ( SELECT a.ogrencinumarasi    FROM ogretmentablo o    JOIN ogrencitablo a ON o.isim = ogretmenadi);";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {


                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                        }
                    }
                }
                connection.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OgretmenGiris_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgretmenMesajlas ogretmenmesaj = new OgretmenMesajlas(ogretmenAdi);
            ogretmenmesaj.Show();
        }
    }
}
