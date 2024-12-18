namespace AngkaMaksimum
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
            txtAngka2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            txtAngkaMaksimum = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(353, 38);
            label1.TabIndex = 0;
            label1.Text = "HITUNG NILAI MAKSIUM ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 89);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Angka 1";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtAngka1
            // 
            txtAngka1.Location = new Point(213, 86);
            txtAngka1.Name = "txtAngka1";
            txtAngka1.Size = new Size(265, 31);
            txtAngka1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 152);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 3;
            label3.Text = "Angka 2";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtAngka2
            // 
            txtAngka2.Location = new Point(213, 149);
            txtAngka2.Name = "txtAngka2";
            txtAngka2.Size = new Size(265, 31);
            txtAngka2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(258, 291);
            button1.Name = "button1";
            button1.Size = new Size(146, 58);
            button1.TabIndex = 5;
            button1.Text = "Hitung Angka";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(569, 86);
            button2.Name = "button2";
            button2.Size = new Size(146, 58);
            button2.TabIndex = 6;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(569, 200);
            button3.Name = "button3";
            button3.Size = new Size(146, 58);
            button3.TabIndex = 7;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 217);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 8;
            label4.Text = "Angka Maksimum";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtAngkaMaksimum
            // 
            txtAngkaMaksimum.Location = new Point(213, 217);
            txtAngkaMaksimum.Name = "txtAngkaMaksimum";
            txtAngkaMaksimum.Size = new Size(265, 31);
            txtAngkaMaksimum.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAngkaMaksimum);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtAngka2);
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
        private TextBox txtAngka2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private TextBox txtAngkaMaksimum;
    }
}
