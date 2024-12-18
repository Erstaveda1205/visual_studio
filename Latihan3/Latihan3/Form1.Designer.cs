namespace Latihan3
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtWarna = new TextBox();
            txtMusik = new TextBox();
            txtFilm = new TextBox();
            txtKelas = new TextBox();
            txtNama = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTampil = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 18);
            label1.Name = "label1";
            label1.Size = new Size(381, 32);
            label1.TabIndex = 0;
            label1.Text = "MENAMPILKAN DATA DIRI";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtWarna);
            groupBox1.Controls.Add(txtMusik);
            groupBox1.Controls.Add(txtFilm);
            groupBox1.Controls.Add(txtKelas);
            groupBox1.Controls.Add(txtNama);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(65, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(646, 299);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Isikan Data Diri";
            // 
            // button3
            // 
            button3.Location = new Point(499, 209);
            button3.Name = "button3";
            button3.Size = new Size(106, 55);
            button3.TabIndex = 12;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(499, 131);
            button2.Name = "button2";
            button2.Size = new Size(106, 55);
            button2.TabIndex = 11;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(499, 49);
            button1.Name = "button1";
            button1.Size = new Size(106, 55);
            button1.TabIndex = 10;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtWarna
            // 
            txtWarna.Location = new Point(198, 233);
            txtWarna.Name = "txtWarna";
            txtWarna.Size = new Size(267, 31);
            txtWarna.TabIndex = 9;
            // 
            // txtMusik
            // 
            txtMusik.Location = new Point(198, 184);
            txtMusik.Name = "txtMusik";
            txtMusik.Size = new Size(267, 31);
            txtMusik.TabIndex = 8;
            // 
            // txtFilm
            // 
            txtFilm.Location = new Point(198, 143);
            txtFilm.Name = "txtFilm";
            txtFilm.Size = new Size(267, 31);
            txtFilm.TabIndex = 7;
            // 
            // txtKelas
            // 
            txtKelas.Location = new Point(198, 92);
            txtKelas.Name = "txtKelas";
            txtKelas.Size = new Size(267, 31);
            txtKelas.TabIndex = 6;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(198, 46);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(267, 31);
            txtNama.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 239);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 4;
            label6.Text = "Warna Favorit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 190);
            label5.Name = "label5";
            label5.Size = new Size(168, 25);
            label5.TabIndex = 3;
            label5.Text = "Genre Musik Favorit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 143);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 2;
            label4.Text = "Genre Film favorit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 92);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 1;
            label3.Text = "Kelas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 46);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 0;
            label2.Text = "Nama";
            // 
            // lblTampil
            // 
            lblTampil.AutoSize = true;
            lblTampil.Location = new Point(18, 37);
            lblTampil.Name = "lblTampil";
            lblTampil.Size = new Size(165, 25);
            lblTampil.TabIndex = 2;
            lblTampil.Text = "Tampilkan Data Diri";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTampil);
            groupBox2.Location = new Point(63, 406);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(649, 275);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 766);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtWarna;
        private TextBox txtMusik;
        private TextBox txtFilm;
        private TextBox txtKelas;
        private TextBox txtNama;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblTampil;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
    }
}
