﻿namespace YazLab_1
{
    partial class OgretmenEkle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 56);
            label1.Name = "label1";
            label1.Size = new Size(633, 41);
            label1.TabIndex = 0;
            label1.Text = "Eklemek istediğiniz öğretmen bilgilerini giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(106, 150);
            label2.Name = "label2";
            label2.Size = new Size(164, 31);
            label2.TabIndex = 1;
            label2.Text = "Sicil Numarası:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(209, 203);
            label3.Name = "label3";
            label3.Size = new Size(61, 31);
            label3.TabIndex = 2;
            label3.Text = "İsim:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(173, 250);
            label4.Name = "label4";
            label4.Size = new Size(97, 31);
            label4.TabIndex = 3;
            label4.Text = "Soyisim:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(206, 304);
            label5.Name = "label5";
            label5.Size = new Size(64, 31);
            label5.TabIndex = 4;
            label5.Text = "Şifre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(291, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(291, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(291, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(291, 308);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(190, 27);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(291, 360);
            button1.Name = "button1";
            button1.Size = new Size(190, 35);
            button1.TabIndex = 9;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OgretmenEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1054, 620);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgretmenEkle";
            Text = "OgretmenEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}