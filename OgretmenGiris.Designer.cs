namespace YazLab_1
{
    partial class OgretmenGiris
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
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.PaleVioletRed;
            checkedListBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.ForeColor = SystemColors.InfoText;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Matematik", "Fizik", "Yapay Zeka", "Görüntü İşleme", "Diferansiyel", "Veri Tabanı", "Donanım", "Mobil", "Web Tasarım" });
            checkedListBox1.Location = new Point(58, 135);
            checkedListBox1.Margin = new Padding(6);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(219, 294);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 88);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(327, 41);
            label1.TabIndex = 1;
            label1.Text = "İLGİ ALANINIZI SEÇİNİZ";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(93, 438);
            button1.Name = "button1";
            button1.Size = new Size(134, 42);
            button1.TabIndex = 2;
            button1.Text = "kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(299, 165);
            label2.Name = "label2";
            label2.Size = new Size(608, 31);
            label2.TabIndex = 3;
            label2.Text = "Dersinize talep oluşturan öğrencileri görmek için tıklayınız:";
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(904, 165);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "GÖR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(279, 346);
            label3.Name = "label3";
            label3.Size = new Size(632, 31);
            label3.TabIndex = 6;
            label3.Text = "Talebini onaylamak istediğiniz öğrencinin numarasını yazınız:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(917, 346);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleTurquoise;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(917, 401);
            button3.Name = "button3";
            button3.Size = new Size(125, 40);
            button3.TabIndex = 8;
            button3.Text = "ONAYLA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Wheat;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(807, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(225, 125);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(299, 496);
            label4.Name = "label4";
            label4.Size = new Size(418, 31);
            label4.TabIndex = 10;
            label4.Text = "Öğrencilerle mesajlaşmak için tıklayınız:";
            // 
            // button4
            // 
            button4.BackColor = Color.NavajoWhite;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(723, 498);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "MESAJ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // OgretmenGiris
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1054, 620);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "OgretmenGiris";
            Text = "OgretmenGiris";
            Load += OgretmenGiris_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Label label3;
        private TextBox textBox1;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label4;
        private Button button4;
    }
}