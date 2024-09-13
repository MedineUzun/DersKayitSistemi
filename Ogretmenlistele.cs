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
    public partial class Ogretmenlistele : Form
    {
        private string connectionString;
        public Ogretmenlistele()
        {
            InitializeComponent();
            connectionString = "Host=localhost;Username=postgres;Password=b123;Database=Yazlab1";

        }

        private void Ogretmenlistele_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();


                string query = "SELECT * FROM ogretmentablo";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // DataGridView kontrolünü verilere bağla
                        dataGridView1.DataSource = table;
                    }
                }

                connection.Close();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
