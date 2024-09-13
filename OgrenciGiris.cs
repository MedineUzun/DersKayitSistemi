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
using System.Threading;
using NpgsqlTypes;
using Tesseract;
using System.Drawing.Imaging;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace YazLab_1
{
    public partial class OgrenciGiris : Form
    {

        private long kullaniciAdi;
        public OgrenciGiris(long kullaniciadi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciadi;
        }


        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "Yazlab1";
        private static string Password = "b123";
        private static string Port = "5432";

        string[] kelimeler;

        string connString =
           String.Format(
               "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=prefer",
               Host,
               User,
               DBname,
               Port,
               Password);
        string language = "eng";

        private void OgrenciGiris_Load(object sender, EventArgs e)
        {
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(286, 20);
            label4.Name = "label4";
            label4.Size = new Size(224, 33);
            label4.TabIndex = 19;
            label4.Text = kullaniciAdi + " HOŞ GELDİNİZ :)";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Thread staThread = new Thread(new ThreadStart(() =>
            {

                string pdfFilePath;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfFilePath = openFileDialog.FileName;
                    byte[] pdfData = File.ReadAllBytes(pdfFilePath);

                    using (var conn = new NpgsqlConnection(connString))
                    {
                        conn.Open();
                        using (NpgsqlCommand command = new NpgsqlCommand("UPDATE pdftablo SET pdf = @pdfdata WHERE ogrenciid = @id", conn))
                        {
                            command.Parameters.AddWithValue("id", kullaniciAdi);
                            command.Parameters.Add(new NpgsqlParameter("@pdfdata", NpgsqlDbType.Bytea));
                            command.Parameters["@pdfdata"].Value = pdfData;
                            command.ExecuteNonQuery();

                            //string textFolderPath = "D:\\ÜNİ";

                            PdfDocument pdfDocument = new PdfDocument(new PdfReader(pdfFilePath));
                            string extractedText = "";
                            List<string> dersAdlari = new List<string>();

                            for (int pageNum = 1; pageNum <= pdfDocument.GetNumberOfPages(); pageNum++)
                            {
                                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                                string pageText = PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(pageNum), strategy);
                                string desen = @"\b[A-Z]+\d+\b";

                                MatchCollection eslesmeler = Regex.Matches(pageText, desen);
                                foreach (Match eslesme in eslesmeler)
                                {
                                    Debug.WriteLine(eslesme.Value);
                                }



                                using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE pdftablo SET dersler = :textArray WHERE ogrenciid = @kullaniciAdi", conn))
                                {
                                    cmd.Parameters.Add(new NpgsqlParameter("textArray", NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Varchar));
                                    cmd.Parameters[0].Value = dersAdlari.ToArray(); // List'ten diziye dönüştürün
                                    cmd.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);
                                    cmd.ExecuteNonQuery();
                                }


                                foreach (Match eslesme in eslesmeler)
                                {
                                    string dersAdi = eslesme.Value;
                                    dersAdlari.Add(dersAdi);

                                    using (NpgsqlCommand command2 = new NpgsqlCommand("INSERT INTO ogrenciderstablo (ogrenciid, dersid) " +
                                        "SELECT @kullaniciAdi , dt.dersid " +
                                        "FROM derstablo AS dt " +
                                        "WHERE dt.dersadi = @dersAdi", conn))
                                    {

                                        {

                                            command2.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);
                                            command2.Parameters.AddWithValue("dersAdi", dersAdi);

                                            command2.ExecuteNonQuery();



                                        }
                                    }
                                }
                                decimal genelortalama = 0;
                                 strategy= new SimpleTextExtractionStrategy();
                                 pageText = PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(pageNum), strategy);

                                string desen2 = @"\b\d+\.\d+\b";

                                eslesmeler = Regex.Matches(pageText, desen2);

                                int sayac = 0;

                                foreach (Match eslesme in eslesmeler)
                                {
                                    if (sayac == 8 && decimal.TryParse(eslesme.Value, out genelortalama))
                                    {

                                        using (NpgsqlCommand command3 = new NpgsqlCommand("UPDATE pdftablo SET genelort = @genelortalama WHERE ogrenciid = @kullaniciAdi", conn))
                                        {
                                            command3.Parameters.AddWithValue("genelortalama", genelortalama);
                                            command3.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);
                                            command3.ExecuteNonQuery();

                                        }
                                        break;
                                    }
                                    sayac++;
                                }



                            }


                        }
                    }


                }
            }));

            staThread.SetApartmentState(ApartmentState.STA);
            staThread.Start();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();


                string query = "SELECT a.isim FROM ogretmentablo a JOIN ogrencitablo b ON b.ilgialani= a.ilgialani WHERE b.ogrencinumarasi=@kullaniciAdi;";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi); 
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

        string ders;
        private void button3_Click(object sender, EventArgs e)
        {

            ders = textBox1.Text;

            dataGridView2.DataSource = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();


                string query = "SELECT isim FROM ogretmentablo WHERE verdigidersler = @ders;";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("ders", ders);
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView2.DataSource = table;
                    }
                }
                connection.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            string o_isim = textBox2.Text;  // dersı almak ıstedıgı hocanın ısmı 


            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();


                string query = "UPDATE ogrencitablo  SET anlasmadurumu = 1 WHERE ogrencinumarasi = @kullaniciAdi;" +
                               "UPDATE ogretmentablo SET anlasmadurumu = 4 WHERE isim = @o_isim;";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("o_isim", o_isim);
                    command.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);
                    int rowsAffected = command.ExecuteNonQuery();
                }
                connection.Close();

            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();


                string query = "UPDATE derstaleptablo SET ogretmenadi = @o_isim, ders = @ders WHERE ogrenciid IN(SELECT ogrenciid FROM ogrencitablo WHERE ogrencinumarasi = @kullaniciAdi);";
                ;


                using (NpgsqlCommand command2 = new NpgsqlCommand(query, connection))
                {
                    command2.Parameters.AddWithValue("o_isim", o_isim);
                    command2.Parameters.AddWithValue("ders", ders);
                    command2.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);
                    int rowsAffected = command2.ExecuteNonQuery();
                }
                connection.Close();

            }







        }

        private void button5_Click(object sender, EventArgs e)
        {



            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();

                string query = "SELECT pdfid, genelort FROM pdftablo WHERE ogrenciid = @kullaniciAdi;";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView3.DataSource = table;
                    }
                }

                string query2 = "SELECT dersler FROM pdftablo WHERE ogrenciid = @kullaniciAdi;";
                using (NpgsqlCommand command = new NpgsqlCommand(query2, connection))
                {
                    command.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("DERSLER", typeof(string));
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            string[] arrayData = (string[])reader.GetValue(0);

                            foreach (string item in arrayData)
                            {

                                dataTable.Rows.Add(item);
                            }
                        }

                    }
                    dataGridView4.DataSource = dataTable;

                }

                connection.Close();
            }



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OgrenciMesajlas ogrencimesaj = new OgrenciMesajlas(kullaniciAdi);
            ogrencimesaj.Show();
        }
    }
}