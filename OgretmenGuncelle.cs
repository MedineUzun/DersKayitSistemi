using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YazLab_1
{
    public partial class OgretmenGuncelle : Form
    {
        private long sicilnumarasi;

        public OgretmenGuncelle()
        {
            InitializeComponent();
        }
        public OgretmenGuncelle(long sicilnumarasi)
        {
            InitializeComponent();
            this.sicilnumarasi= sicilnumarasi;
        }

     

        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 92);
            label1.Name = "label1";
            label1.Size = new Size(798, 41);
            label1.TabIndex = 0;
            label1.Text = "Güncellemek istediğiniz öğretmenin sicil numarasını giriniz:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(804, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(350, 447);
            button1.Name = "button1";
            button1.Size = new Size(179, 39);
            button1.TabIndex = 4;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(117, 179);
            label2.Name = "label2";
            label2.Size = new Size(227, 38);
            label2.TabIndex = 5;
            label2.Text = "Kontenjan bilgisi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(193, 248);
            label3.Name = "label3";
            label3.Size = new Size(151, 38);
            label3.TabIndex = 6;
            label3.Text = "Kriter ders:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(218, 335);
            label4.Name = "label4";
            label4.Size = new Size(126, 38);
            label4.TabIndex = 7;
            label4.Text = "İlgi alanı:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Point(350, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(179, 27);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new Point(350, 259);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(179, 27);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new Point(350, 346);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(179, 27);
            this.textBox4.TabIndex = 10;
            // 
            // OgretmenGuncelle
            // 
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1054, 620);
            Controls.Add(this.textBox4);
            Controls.Add(this.textBox3);
            Controls.Add(this.textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "OgretmenGuncelle";
            Load += OgretmenGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void OgretmenGuncelle_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "Yazlab1";
        private static string Password = "b123";
        private static string Port = "5432";
       private int sicilno;
        private int kontenjanbilgisi;
        private string kriterders;
        private string ilgialani;
        private void button1_Click_2(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out sicilno);
            int.TryParse(textBox2.Text, out kontenjanbilgisi);
            kriterders = textBox3.Text;
            ilgialani = textBox4.Text;
            

            string connString = String.Format("Host={0}; Username={1}; Database={2}; Port={3}; Password={4};", Host, User, DBname, Port, Password);

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (var command = new NpgsqlCommand("UPDATE ogretmentablo SET kontenjanbilgisi = @a,  kriterdersler = @b ,ilgialani = @c WHERE sicilnumarasi = @sicilno", conn))
                    {
                        command.Parameters.AddWithValue("a", kontenjanbilgisi);
                        command.Parameters.AddWithValue("b", kriterders);
                        command.Parameters.AddWithValue("c", ilgialani);
                        command.Parameters.AddWithValue("sicilno", sicilno);

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
    
    
