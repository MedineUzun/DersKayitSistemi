using System;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace YazLab_1
{
    public partial class Ogrencilistele : Form
    {
        private string connectionString;

        public Ogrencilistele()
        {
            InitializeComponent();

            
            connectionString = "Host=localhost;Username=postgres;Password=b123;Database=Yazlab1";
        }

        private void Ogrencilistele_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

               
                string query = "SELECT * FROM ogrencitablo"; 

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView hücre tıklamalarını işleyebilirsiniz, isteğe bağlı olarak burada işlemler yapabilirsiniz.
        }
    }
}
