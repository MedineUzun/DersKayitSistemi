namespace YazLab_1
{
    partial class Ogrenci
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
            ogrencigiris = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // ogrencigiris
            // 
            ogrencigiris.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ogrencigiris.Location = new Point(127, 445);
            ogrencigiris.Name = "ogrencigiris";
            ogrencigiris.Size = new Size(774, 47);
            ogrencigiris.TabIndex = 0;
            ogrencigiris.Text = "GİRİŞ";
            ogrencigiris.UseVisualStyleBackColor = true;
            ogrencigiris.Click += ogrencigiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(186, 217);
            label1.Name = "label1";
            label1.Size = new Size(224, 41);
            label1.TabIndex = 1;
            label1.Text = "KULLANICI ADI:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(416, 231);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(304, 299);
            label2.Name = "label2";
            label2.Size = new Size(97, 41);
            label2.TabIndex = 3;
            label2.Text = "ŞİFRE:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(416, 313);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(330, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Ogrenci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1054, 620);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(ogrencigiris);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Ogrenci";
            Text = "Ogrenci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
     
       


        private Button ogrencigiris;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
    }
}