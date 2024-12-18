namespace Kalkulator
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
            txtHasil = new TextBox();
            label3 = new Label();
            txtAngka2 = new TextBox();
            label2 = new Label();
            txtAngka1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnBagi = new Button();
            BtnKali = new Button();
            BtnKurang = new Button();
            BtnTambah = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(txtHasil);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAngka2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAngka1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(109, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 229);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kalkulator Sederhana";
            // 
            // txtHasil
            // 
            txtHasil.BackColor = SystemColors.ScrollBar;
            txtHasil.Location = new Point(517, 114);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(234, 39);
            txtHasil.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(587, 57);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 4;
            label3.Text = "HASIL";
            // 
            // txtAngka2
            // 
            txtAngka2.Location = new Point(203, 134);
            txtAngka2.Name = "txtAngka2";
            txtAngka2.Size = new Size(279, 39);
            txtAngka2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(25, 134);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 2;
            label2.Text = "Angka 2";
            // 
            // txtAngka1
            // 
            txtAngka1.Location = new Point(203, 63);
            txtAngka1.Name = "txtAngka1";
            txtAngka1.Size = new Size(279, 39);
            txtAngka1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 57);
            label1.Name = "label1";
            label1.Size = new Size(103, 32);
            label1.TabIndex = 0;
            label1.Text = "Angka 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnBagi);
            groupBox2.Controls.Add(BtnKali);
            groupBox2.Controls.Add(BtnKurang);
            groupBox2.Controls.Add(BtnTambah);
            groupBox2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(119, 307);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(442, 122);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operator";
            // 
            // BtnBagi
            // 
            BtnBagi.BackColor = SystemColors.ScrollBar;
            BtnBagi.Location = new Point(345, 39);
            BtnBagi.Name = "BtnBagi";
            BtnBagi.Size = new Size(64, 63);
            BtnBagi.TabIndex = 3;
            BtnBagi.Text = "/";
            BtnBagi.UseVisualStyleBackColor = false;
            BtnBagi.Click += BtnBagi_Click;
            // 
            // BtnKali
            // 
            BtnKali.BackColor = SystemColors.ScrollBar;
            BtnKali.Location = new Point(239, 39);
            BtnKali.Name = "BtnKali";
            BtnKali.Size = new Size(64, 63);
            BtnKali.TabIndex = 2;
            BtnKali.Text = "x";
            BtnKali.UseVisualStyleBackColor = false;
            BtnKali.Click += BtnKali_Click;
            // 
            // BtnKurang
            // 
            BtnKurang.BackColor = SystemColors.ScrollBar;
            BtnKurang.Location = new Point(134, 39);
            BtnKurang.Name = "BtnKurang";
            BtnKurang.Size = new Size(64, 63);
            BtnKurang.TabIndex = 1;
            BtnKurang.Text = "-";
            BtnKurang.UseVisualStyleBackColor = false;
            BtnKurang.Click += BtnKurang_Click;
            // 
            // BtnTambah
            // 
            BtnTambah.BackColor = SystemColors.ScrollBar;
            BtnTambah.Location = new Point(25, 39);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(64, 63);
            BtnTambah.TabIndex = 0;
            BtnTambah.Text = "+";
            BtnTambah.UseVisualStyleBackColor = false;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ScrollBar;
            btnClear.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(626, 316);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 132);
            btnClear.TabIndex = 2;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ScrollBar;
            btnExit.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(784, 316);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 132);
            btnExit.TabIndex = 3;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(974, 566);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtAngka2;
        private Label label2;
        private TextBox txtAngka1;
        private Label label1;
        private GroupBox groupBox2;
        private Button BtnKali;
        private Button BtnKurang;
        private Button BtnTambah;
        private Button BtnBagi;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtHasil;
        private Label label3;
    }
}
