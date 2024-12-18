namespace HitungDiskon
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
            txtTotal = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtBayar = new TextBox();
            txtDiskon = new TextBox();
            btnHitung = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 24);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 0;
            label1.Text = "HITUNG DISKON";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Location = new Point(101, 93);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 1;
            label2.Text = "Jumlah Harga";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(247, 90);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(311, 31);
            txtTotal.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonShadow;
            label3.Location = new Point(101, 205);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 3;
            label3.Text = "Total Bayar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonShadow;
            label4.Location = new Point(101, 145);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 4;
            label4.Text = "Diskon (%)";
            // 
            // txtBayar
            // 
            txtBayar.Location = new Point(247, 199);
            txtBayar.Name = "txtBayar";
            txtBayar.Size = new Size(311, 31);
            txtBayar.TabIndex = 5;
            // 
            // txtDiskon
            // 
            txtDiskon.Location = new Point(247, 145);
            txtDiskon.Name = "txtDiskon";
            txtDiskon.Size = new Size(311, 31);
            txtDiskon.TabIndex = 6;
            // 
            // btnHitung
            // 
            btnHitung.Location = new Point(602, 87);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(141, 46);
            btnHitung.TabIndex = 7;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = true;
            btnHitung.Click += btnHitung_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(604, 153);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(139, 47);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(604, 222);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 47);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 383);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnHitung);
            Controls.Add(txtDiskon);
            Controls.Add(txtBayar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTotal;
        private Label label3;
        private Label label4;
        private TextBox txtBayar;
        private TextBox txtDiskon;
        private Button btnHitung;
        private Button btnClear;
        private Button btnExit;
    }
}
