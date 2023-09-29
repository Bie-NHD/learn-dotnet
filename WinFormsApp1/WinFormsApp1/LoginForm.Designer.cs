using System.Drawing.Printing;

namespace WinFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblPassword = new Label();
            groupBox = new GroupBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(64, 119);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(113, 32);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Usename";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(64, 177);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(111, 32);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // groupBox
            // 
            groupBox.AutoSize = true;
            groupBox.Controls.Add(txtPassword);
            groupBox.Controls.Add(txtUsername);
            groupBox.Controls.Add(lblUsername);
            groupBox.Controls.Add(lblPassword);
            groupBox.Controls.Add(btnLogin);
            groupBox.Dock = DockStyle.Fill;
            
            groupBox.Location = new Point(0, 0);
            groupBox.Margin = new Padding(10);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(10);
            groupBox.Size = new Size(800, 450);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            // 
            // textBox1
            // 
            txtUsername.Location = new Point(190, 130);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 39);
            txtUsername.TabIndex = 2;
            // 
            // textBox2
            // 
            txtPassword.Location = new Point(191, 181);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 39);
           
            txtPassword.TabIndex = 3;
            // button Login
            btnLogin.Text = "Login";
            btnLogin.Enabled = false;
            
            btnLogin.AutoSize = true;
            btnLogin.MaximumSize = new Size(300, 100);
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox);
            Name = "LoginForm";
            Text = "LoginForm";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private GroupBox groupBox;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
    }
}