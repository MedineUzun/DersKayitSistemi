namespace YazLab_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            y�netici = new Button();
            hoca = new Button();
            �grenci = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // y�netici
            // 
            y�netici.BackColor = Color.PaleTurquoise;
            y�netici.Location = new Point(79, 211);
            y�netici.Name = "y�netici";
            y�netici.Size = new Size(291, 259);
            y�netici.TabIndex = 0;
            y�netici.Text = "Y�NET�C�";
            y�netici.UseVisualStyleBackColor = false;
            y�netici.Click += button1_Click;
            // 
            // hoca
            // 
            hoca.BackColor = Color.PeachPuff;
            hoca.Location = new Point(416, 211);
            hoca.Name = "hoca";
            hoca.Size = new Size(291, 259);
            hoca.TabIndex = 1;
            hoca.Text = "��RETMEN";
            hoca.UseVisualStyleBackColor = false;
            hoca.Click += button2_Click;
            // 
            // �grenci
            // 
            �grenci.BackColor = Color.Thistle;
            �grenci.ForeColor = SystemColors.ActiveCaptionText;
            �grenci.Location = new Point(754, 211);
            �grenci.Name = "�grenci";
            �grenci.Size = new Size(291, 259);
            �grenci.TabIndex = 2;
            �grenci.Text = "��RENC�";
            �grenci.UseVisualStyleBackColor = false;
            �grenci.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(200, 124);
            label1.Name = "label1";
            label1.Size = new Size(726, 43);
            label1.TabIndex = 3;
            label1.Text = "DERS KAYIT S�STEM�NE HO� GELD�N�Z";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1186, 620);
            Controls.Add(label1);
            Controls.Add(�grenci);
            Controls.Add(hoca);
            Controls.Add(y�netici);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "G�R��";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ogretmen ogretmen1 = new Ogretmen();
            ogretmen1.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Yonetici yonetici1 = new Yonetici();
            yonetici1.Show();
        }
    }
}