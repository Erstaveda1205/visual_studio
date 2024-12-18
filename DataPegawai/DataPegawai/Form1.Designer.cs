namespace DataPegawai
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
            groupBox1 = new GroupBox();
            btnExit = new Button();
            btnClear = new Button();
            btnView = new Button();
            txtGaji = new TextBox();
            txtPosisi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtNamaPegawai = new TextBox();
            label2 = new Label();
            txtIDPegawai = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnTampilkanDataPegawai = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnView);
            groupBox1.Controls.Add(txtGaji);
            groupBox1.Controls.Add(txtPosisi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNamaPegawai);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIDPegawai);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(42, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(674, 257);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Isi Data Pegawai";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(509, 181);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(134, 35);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(509, 115);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(134, 35);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Location = new Point(509, 41);
            btnView.Name = "btnView";
            btnView.Size = new Size(134, 35);
            btnView.TabIndex = 8;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            // 
            // txtGaji
            // 
            txtGaji.Location = new Point(209, 185);
            txtGaji.Name = "txtGaji";
            txtGaji.Size = new Size(256, 31);
            txtGaji.TabIndex = 7;
            // 
            // txtPosisi
            // 
            txtPosisi.Location = new Point(209, 135);
            txtPosisi.Name = "txtPosisi";
            txtPosisi.Size = new Size(256, 31);
            txtPosisi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 185);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 5;
            label4.Text = "Gaji :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 135);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 4;
            label3.Text = "Posisi :";
            // 
            // txtNamaPegawai
            // 
            txtNamaPegawai.Location = new Point(209, 83);
            txtNamaPegawai.Name = "txtNamaPegawai";
            txtNamaPegawai.Size = new Size(256, 31);
            txtNamaPegawai.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 86);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 2;
            label2.Text = "Nama Pegawai:";
            // 
            // txtIDPegawai
            // 
            txtIDPegawai.Location = new Point(209, 35);
            txtIDPegawai.Name = "txtIDPegawai";
            txtIDPegawai.Size = new Size(256, 31);
            txtIDPegawai.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 38);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "ID Pegawai :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(674, 338);
            dataGridView1.TabIndex = 1;
            // 
            // btnTampilkanDataPegawai
            // 
            btnTampilkanDataPegawai.Location = new Point(70, 334);
            btnTampilkanDataPegawai.Name = "btnTampilkanDataPegawai";
            btnTampilkanDataPegawai.Size = new Size(312, 34);
            btnTampilkanDataPegawai.TabIndex = 2;
            btnTampilkanDataPegawai.Text = "Tampilkan Data Pegawai";
            btnTampilkanDataPegawai.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 767);
            Controls.Add(btnTampilkanDataPegawai);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox txtNamaPegawai;
        private Label label2;
        private TextBox txtIDPegawai;
        private Button btnView;
        private TextBox txtGaji;
        private TextBox txtPosisi;
        private Button btnExit;
        private Button btnClear;
        private DataGridView dataGridView1;
        private Button btnTampilkanDataPegawai;
    }
}
