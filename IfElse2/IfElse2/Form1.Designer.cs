namespace IfElse2
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
            listBox1 = new ListBox();
            BtnClear = new Button();
            BtnExit = new Button();
            BtnHitung = new Button();
            txtNilai = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(BtnClear);
            groupBox1.Controls.Add(BtnExit);
            groupBox1.Controls.Add(BtnHitung);
            groupBox1.Controls.Add(txtNilai);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Rockwell", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(100, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 418);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "KONVERSI NILAI";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 34;
            listBox1.Location = new Point(39, 139);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(326, 242);
            listBox1.TabIndex = 5;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = SystemColors.ActiveBorder;
            BtnClear.Location = new Point(390, 137);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(143, 54);
            BtnClear.TabIndex = 4;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = SystemColors.ActiveBorder;
            BtnExit.Location = new Point(390, 213);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(143, 54);
            BtnExit.TabIndex = 3;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnHitung
            // 
            BtnHitung.BackColor = SystemColors.ActiveBorder;
            BtnHitung.Location = new Point(390, 65);
            BtnHitung.Name = "BtnHitung";
            BtnHitung.Size = new Size(143, 54);
            BtnHitung.TabIndex = 2;
            BtnHitung.Text = "Hitung";
            BtnHitung.UseVisualStyleBackColor = false;
            BtnHitung.Click += BtnHitung_Click;
            // 
            // txtNilai
            // 
            txtNilai.Location = new Point(210, 64);
            txtNilai.Name = "txtNilai";
            txtNilai.Size = new Size(122, 40);
            txtNilai.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 74);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 0;
            label1.Text = "Masukan Nilai";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 652);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnClear;
        private Button BtnExit;
        private Button BtnHitung;
        private TextBox txtNilai;
        private Label label1;
        private ListBox listBox1;
    }
}
