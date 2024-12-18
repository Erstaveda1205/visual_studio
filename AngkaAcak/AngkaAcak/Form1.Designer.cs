namespace AngkaAcak
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
            txtMax = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtMin = new TextBox();
            label1 = new Label();
            this.btnAcak.Click += new System.EventHandler(this.btnAcak_Click);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnAcak);
            groupBox1.Controls.Add(txtHasilAcak);
            groupBox1.Controls.Add(txtMax);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMin);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(62, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(677, 300);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Masukan Angka Min dan Max";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(528, 176);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 49);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(528, 105);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 49);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAcak
            // 
            btnAcak.Location = new Point(528, 44);
            btnAcak.Name = "btnAcak";
            btnAcak.Size = new Size(108, 49);
            btnAcak.TabIndex = 6;
            btnAcak.Text = "Apply";
            btnAcak.UseVisualStyleBackColor = true;
            // 
            // txtHasilAcak
            // 
            txtHasilAcak.Location = new Point(183, 162);
            txtHasilAcak.Name = "txtHasilAcak";
            txtHasilAcak.Size = new Size(307, 34);
            txtHasilAcak.TabIndex = 5;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(183, 105);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(307, 34);
            txtMax.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 160);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 3;
            label3.Text = "Hasil Acak";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 105);
            label2.Name = "label2";
            label2.Size = new Size(169, 28);
            label2.TabIndex = 2;
            label2.Text = "Angka Maksimal";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(183, 49);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(307, 34);
            txtMin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 49);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 0;
            label1.Text = "Angka Minimal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private Label label3;
        private Label label2;
        private TextBox txtMin;
        private TextBox txtHasilAcak;
        private TextBox txtMax;
        private Button btnExit;
        private Button btnClear;
        private Button btnAcak;
    }
}
