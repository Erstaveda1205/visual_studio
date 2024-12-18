namespace AcakAngka
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
            btnAcak = new Button();
            txtHasilAcak = new TextBox();
            label2 = new Label();
            txtInput = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnAcak);
            groupBox1.Controls.Add(txtHasilAcak);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtInput);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(68, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(593, 375);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acak Angka";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(406, 239);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(124, 63);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(406, 144);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 63);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnAcak
            // 
            btnAcak.Location = new Point(406, 54);
            btnAcak.Name = "btnAcak";
            btnAcak.Size = new Size(124, 63);
            btnAcak.TabIndex = 4;
            btnAcak.Text = "Acak";
            btnAcak.UseVisualStyleBackColor = true;
            btnAcak.Click += BtnAcak_Click;
            // 
            // txtHasilAcak
            // 
            txtHasilAcak.Location = new Point(23, 226);
            txtHasilAcak.Name = "txtHasilAcak";
            txtHasilAcak.Size = new Size(294, 31);
            txtHasilAcak.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 163);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 2;
            label2.Text = "Hasil Acakan Huruf";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(23, 99);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(294, 31);
            txtInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 54);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "Masukan teks Angka :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 613);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtInput;
        private TextBox txtHasilAcak;
        private Label label2;
        private Button btnExit;
        private Button btnClear;
        private Button btnAcak;
    }
}
