﻿namespace YazLab_1
{
    partial class Ogretmen
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ogretmengiris = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(404, 902);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(1454, 90);
            button1.TabIndex = 0;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(186, 217);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 41);
            label1.TabIndex = 1;
            label1.Text = "KULLANICI ADI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(304, 299);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 41);
            label2.TabIndex = 2;
            label2.Text = "ŞİFRE:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(416, 217);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 47);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(416, 299);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 47);
            textBox2.TabIndex = 4;
            // 
            // ogretmengiris
            // 
            ogretmengiris.Location = new Point(127, 445);
            ogretmengiris.Name = "ogretmengiris";
            ogretmengiris.Size = new Size(774, 47);
            ogretmengiris.TabIndex = 5;
            ogretmengiris.Text = "GİRİŞ";
            ogretmengiris.UseVisualStyleBackColor = true;
            ogretmengiris.Click += ogretmengiris_Click;
            // 
            // Ogretmen
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1054, 620);
            Controls.Add(ogretmengiris);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Ogretmen";
            Text = "Ogretmen";
            Load += Ogretmen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
       
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button ogretmengiris;
    }
}