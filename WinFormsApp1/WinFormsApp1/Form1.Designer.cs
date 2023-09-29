namespace WinFormsApp1
{
    partial class MainForm
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
            btnOK = new Button();
            btnExit = new Button();
            lblHello = new Label();
            lblGreets = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(453, 257);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(150, 46);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(523, 180);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 46);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.Location = new Point(300, 300);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(250, 32);
            lblHello.TabIndex = 1;
            lblHello.Text = "Chao mung den UTC2";
            // 
            // lblGreets
            // 
            lblGreets.AutoSize = true;
            lblGreets.Location = new Point(315, 84);
            lblGreets.Name = "lblGreets";
            lblGreets.Size = new Size(205, 32);
            lblGreets.TabIndex = 0;
            lblGreets.Text = "Welcome to UTC2";
            lblGreets.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGreets);
            Controls.Add(btnOK);
            Controls.Add(lblHello);
            Controls.Add(btnExit);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "First Window Form";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnExit;
        private Label lblHello;
        private Label lblGreets;
    }
}