namespace IfElse
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
            BtnExit = new Button();
            BtnClear = new Button();
            listBox1 = new ListBox();
            BtnHitung = new Button();
            txtNilai = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDark;
            groupBox1.Controls.Add(BtnExit);
            groupBox1.Controls.Add(BtnClear);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(BtnHitung);
            groupBox1.Controls.Add(txtNilai);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(88, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 522);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Konversi Nilai";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = SystemColors.AppWorkspace;
            BtnExit.ForeColor = SystemColors.ActiveCaptionText;
            BtnExit.Location = new Point(400, 237);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(137, 49);
            BtnExit.TabIndex = 5;
            BtnExit.Text = "EXIT";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = SystemColors.AppWorkspace;
            BtnClear.ForeColor = SystemColors.ActiveCaptionText;
            BtnClear.Location = new Point(400, 147);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(137, 49);
            BtnClear.TabIndex = 4;
            BtnClear.Text = "CLEAR";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ScrollBar;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 38;
            listBox1.Location = new Point(31, 157);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(312, 308);
            listBox1.TabIndex = 3;
            // 
            // BtnHitung
            // 
            BtnHitung.BackColor = SystemColors.AppWorkspace;
            BtnHitung.ForeColor = SystemColors.ActiveCaptionText;
            BtnHitung.Location = new Point(400, 61);
            BtnHitung.Name = "BtnHitung";
            BtnHitung.Size = new Size(137, 49);
            BtnHitung.TabIndex = 2;
            BtnHitung.Text = "HITUNG";
            BtnHitung.UseVisualStyleBackColor = false;
            BtnHitung.Click += BtnHitung_Click;
            // 
            // txtNilai
            // 
            txtNilai.Location = new Point(247, 65);
            txtNilai.Name = "txtNilai";
            txtNilai.Size = new Size(122, 45);
            txtNilai.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(17, 65);
            label1.Name = "label1";
            label1.Size = new Size(211, 38);
            label1.TabIndex = 0;
            label1.Text = "Masukan Nilai";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 692);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNilai;
        private Label label1;
        private Button BtnExit;
        private Button BtnClear;
        private ListBox listBox1;
        private Button BtnHitung;
    }
}
