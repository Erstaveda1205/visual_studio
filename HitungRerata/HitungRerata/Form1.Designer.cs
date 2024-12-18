namespace HitungRerata
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
            txtAngka3 = new TextBox();
            txtAngka2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtRerata = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 28);
            label1.Name = "label1";
            label1.Size = new Size(240, 38);
            label1.TabIndex = 0;
            label1.Text = "HITUNG RERATA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 111);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Angka 1";
            // 
            // txtAngka1
            // 
            txtAngka1.Location = new Point(198, 108);
            txtAngka1.Name = "txtAngka1";
            txtAngka1.Size = new Size(248, 31);
            txtAngka1.TabIndex = 2;
            // 
            // txtAngka3
            // 
            txtAngka3.Location = new Point(198, 242);
            txtAngka3.Name = "txtAngka3";
            txtAngka3.Size = new Size(248, 31);
            txtAngka3.TabIndex = 3;
            // 
            // txtAngka2
            // 
            txtAngka2.Location = new Point(198, 176);
            txtAngka2.Name = "txtAngka2";
            txtAngka2.Size = new Size(248, 31);
            txtAngka2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 245);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 5;
            label3.Text = "Angka 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 179);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 6;
            label4.Text = "Angka 2";
            // 
            // txtRerata
            // 
            txtRerata.Location = new Point(198, 300);
            txtRerata.Name = "txtRerata";
            txtRerata.Size = new Size(248, 31);
            txtRerata.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 303);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 8;
            label5.Text = "Rerata";
            // 
            // button1
            // 
            button1.Location = new Point(215, 365);
            button1.Name = "button1";
            button1.Size = new Size(231, 52);
            button1.TabIndex = 9;
            button1.Text = "Hitung Rerata";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(519, 143);
            button2.Name = "button2";
            button2.Size = new Size(231, 52);
            button2.TabIndex = 10;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(519, 276);
            button3.Name = "button3";
            button3.Size = new Size(231, 52);
            button3.TabIndex = 11;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(198, 459);
            label6.Name = "label6";
            label6.Size = new Size(119, 45);
            label6.TabIndex = 12;
            label6.Text = "HASIL ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 620);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txtRerata);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAngka2);
            Controls.Add(txtAngka3);
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
        private TextBox txtAngka3;
        private TextBox txtAngka2;
        private Label label3;
        private Label label4;
        private TextBox txtRerata;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label6;
    }
}
