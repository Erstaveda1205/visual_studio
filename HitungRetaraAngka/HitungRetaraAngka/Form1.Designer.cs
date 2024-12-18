namespace HitungRetaraAngka
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
            txtAngka1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtAngka3 = new TextBox();
            txtAngka2 = new TextBox();
            label5 = new Label();
            txtHasil = new TextBox();
            BtnHitung = new Button();
            BtnExit = new Button();
            BtnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 9);
            label1.Name = "label1";
            label1.Size = new Size(348, 38);
            label1.TabIndex = 0;
            label1.Text = "HITUNG RETARA ANGKA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 81);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Angka 1";
            // 
            // txtAngka1
            // 
            txtAngka1.BackColor = SystemColors.Info;
            txtAngka1.Location = new Point(178, 80);
            txtAngka1.Name = "txtAngka1";
            txtAngka1.Size = new Size(229, 31);
            txtAngka1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 205);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 3;
            label3.Text = "Angka 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 143);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 4;
            label4.Text = "Angka 2";
            // 
            // txtAngka3
            // 
            txtAngka3.BackColor = SystemColors.Info;
            txtAngka3.Location = new Point(178, 205);
            txtAngka3.Name = "txtAngka3";
            txtAngka3.Size = new Size(229, 31);
            txtAngka3.TabIndex = 5;
            // 
            // txtAngka2
            // 
            txtAngka2.BackColor = SystemColors.Info;
            txtAngka2.Location = new Point(178, 143);
            txtAngka2.Name = "txtAngka2";
            txtAngka2.Size = new Size(229, 31);
            txtAngka2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 267);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 7;
            label5.Text = "RERATA";
            // 
            // txtHasil
            // 
            txtHasil.BackColor = SystemColors.InactiveCaption;
            txtHasil.Location = new Point(178, 267);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(229, 31);
            txtHasil.TabIndex = 8;
            // 
            // BtnHitung
            // 
            BtnHitung.BackColor = SystemColors.ActiveBorder;
            BtnHitung.Location = new Point(191, 340);
            BtnHitung.Name = "BtnHitung";
            BtnHitung.Size = new Size(195, 49);
            BtnHitung.TabIndex = 9;
            BtnHitung.Text = "Hitung Retara Angka";
            BtnHitung.UseVisualStyleBackColor = false;
            BtnHitung.Click += BtnHitung_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = SystemColors.ActiveBorder;
            BtnExit.Location = new Point(485, 225);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(195, 49);
            BtnExit.TabIndex = 10;
            BtnExit.Text = "EXIT";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = SystemColors.ActiveBorder;
            BtnClear.Location = new Point(485, 107);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(195, 49);
            BtnClear.TabIndex = 11;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnClear);
            Controls.Add(BtnExit);
            Controls.Add(BtnHitung);
            Controls.Add(txtHasil);
            Controls.Add(label5);
            Controls.Add(txtAngka2);
            Controls.Add(txtAngka3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAngka1);
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
        private TextBox txtAngka1;
        private Label label3;
        private Label label4;
        private TextBox txtAngka3;
        private TextBox txtAngka2;
        private Label label5;
        private TextBox txtHasil;
        private Button BtnHitung;
        private Button BtnExit;
        private Button BtnClear;
    }
}
