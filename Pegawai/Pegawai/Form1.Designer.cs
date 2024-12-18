namespace Pegawai
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
            label2 = new Label();
            txtID = new TextBox();
            label3 = new Label();
            txtNama = new TextBox();
            label4 = new Label();
            txtPosisi = new TextBox();
            label5 = new Label();
            txtGaji = new TextBox();
            groupBox1 = new GroupBox();
            Button3 = new Button();
            Button2 = new Button();
            Button1 = new Button();
            dataGridView1 = new DataGridView();
            lblTampil = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(208, 29);
            label1.Name = "label1";
            label1.Size = new Size(309, 32);
            label1.TabIndex = 0;
            label1.Text = "Menampilkan Data Pegawai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 27);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 1;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtID
            // 
            txtID.Location = new Point(204, 24);
            txtID.Name = "txtID";
            txtID.Size = new Size(334, 31);
            txtID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 82);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(204, 79);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(334, 31);
            txtNama.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 140);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 5;
            label4.Text = "Posisi";
            // 
            // txtPosisi
            // 
            txtPosisi.Location = new Point(204, 137);
            txtPosisi.Name = "txtPosisi";
            txtPosisi.Size = new Size(334, 31);
            txtPosisi.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 203);
            label5.Name = "label5";
            label5.Size = new Size(41, 25);
            label5.TabIndex = 7;
            label5.Text = "Gaji";
            // 
            // txtGaji
            // 
            txtGaji.Location = new Point(204, 200);
            txtGaji.Name = "txtGaji";
            txtGaji.Size = new Size(334, 31);
            txtGaji.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Button3);
            groupBox1.Controls.Add(Button2);
            groupBox1.Controls.Add(Button1);
            groupBox1.Controls.Add(txtGaji);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPosisi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNama);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(84, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 256);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Pegawai";
            // 
            // Button3
            // 
            Button3.Location = new Point(629, 190);
            Button3.Name = "Button3";
            Button3.Size = new Size(124, 50);
            Button3.TabIndex = 11;
            Button3.Text = "Exit";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(629, 118);
            Button2.Name = "Button2";
            Button2.Size = new Size(124, 50);
            Button2.TabIndex = 10;
            Button2.Text = "Clear";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Location = new Point(629, 44);
            Button1.Name = "Button1";
            Button1.Size = new Size(124, 50);
            Button1.TabIndex = 9;
            Button1.Text = "View";
            Button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(84, 363);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(778, 261);
            dataGridView1.TabIndex = 10;
            // 
            // lblTampil
            // 
            lblTampil.AutoSize = true;
            lblTampil.Location = new Point(127, 378);
            lblTampil.Name = "lblTampil";
            lblTampil.Size = new Size(202, 25);
            lblTampil.TabIndex = 11;
            lblTampil.Text = "Tampilkan Data Pegawai";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 702);
            Controls.Add(lblTampil);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtID;
        private Label label3;
        private TextBox txtNama;
        private Label label4;
        private TextBox txtPosisi;
        private Label label5;
        private TextBox txtGaji;
        private GroupBox groupBox1;
        private Button Button3;
        private Button Button2;
        private Button Button1;
        private DataGridView dataGridView1;
        private Label lblTampil;
    }
}
