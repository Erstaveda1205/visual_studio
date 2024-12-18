namespace coba
{
    partial class Login
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
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 29);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 7;
            label1.Text = "Form Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 115);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 8;
            label2.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(217, 112);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(232, 31);
            txtUsername.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 174);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 10;
            label3.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(217, 174);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(232, 31);
            txtPassword.TabIndex = 11;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(217, 259);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 449);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
