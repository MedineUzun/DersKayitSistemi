namespace YazLab_1
{
    partial class OgrenciGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            label6 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            dataGridView3 = new DataGridView();
            label4 = new Label();
            label7 = new Label();
            button6 = new Button();
            dataGridView4 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(755, 83);
            label2.Name = "label2";
            label2.Size = new Size(0, 106);
            label2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 65);
            label5.Name = "label5";
            label5.Size = new Size(465, 41);
            label5.TabIndex = 5;
            label5.Text = "Pdf eklemek için butona tıklayınız:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumAquamarine;
            button1.Location = new Point(495, 77);
            button1.Name = "button1";
            button1.Size = new Size(128, 29);
            button1.TabIndex = 6;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 158);
            label1.Name = "label1";
            label1.Size = new Size(695, 31);
            label1.TabIndex = 7;
            label1.Text = "İlgi alanınızın ortak olduğu hocaların listesini görmek için tıklayınız:";
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.Location = new Point(735, 163);
            button2.Name = "button2";
            button2.Size = new Size(113, 29);
            button2.TabIndex = 8;
            button2.Text = "GÖR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LemonChiffon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(717, 198);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(160, 148);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 245);
            label3.Name = "label3";
            label3.Size = new Size(338, 28);
            label3.TabIndex = 10;
            label3.Text = "Almak istediğiniz dersin ismini giriniz:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(385, 249);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Thistle;
            button3.Location = new Point(395, 291);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "GÖR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.LemonChiffon;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(375, 326);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(145, 142);
            dataGridView2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(34, 490);
            label6.Name = "label6";
            label6.Size = new Size(572, 31);
            label6.TabIndex = 14;
            label6.Text = "Talepte bulunmak istediğiniz öğretmenin ismini giriniz:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(604, 494);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackColor = Color.LightBlue;
            button4.Location = new Point(604, 545);
            button4.Name = "button4";
            button4.Size = new Size(140, 29);
            button4.TabIndex = 16;
            button4.Text = "TALEP";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Tan;
            button5.Location = new Point(659, 77);
            button5.Name = "button5";
            button5.Size = new Size(142, 29);
            button5.TabIndex = 17;
            button5.Text = "BİLGİLERİ GÖR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.Pink;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(831, 20);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(370, 137);
            dataGridView3.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(286, 20);
            label4.Name = "label4";
            label4.Size = new Size(231, 33);
            label4.TabIndex = 19;
            label4.Text = " HOŞ GELDİNİZ :)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(580, 404);
            label7.Name = "label7";
            label7.Size = new Size(436, 31);
            label7.TabIndex = 20;
            label7.Text = "Öğretmenlerle mesajlaşmak için tıklayınız";
            // 
            // button6
            // 
            button6.BackColor = Color.DarkGray;
            button6.Location = new Point(1022, 409);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 21;
            button6.Text = "MESAJ";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = Color.Pink;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(910, 158);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.Size = new Size(291, 162);
            dataGridView4.TabIndex = 22;
            // 
            // OgrenciGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1213, 709);
            Controls.Add(dataGridView4);
            Controls.Add(button6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(dataGridView3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(dataGridView2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label2);
            Name = "OgrenciGiris";
            Text = "OgrenciGiris";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label5;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Label label1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox1;
        private Button button3;
        private DataGridView dataGridView2;
        private Label label6;
        private TextBox textBox2;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView3;
        private Label label4;
        private Label label7;
        private Button button6;
        private DataGridView dataGridView4;
    }
}