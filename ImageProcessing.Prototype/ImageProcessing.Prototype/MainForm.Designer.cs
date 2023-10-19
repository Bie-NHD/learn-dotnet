namespace ImageProcessing.Prototype
{
    partial class MainForm
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
            btnOpenImageEditor = new Button();
            btnOpenPicSew = new Button();
            SuspendLayout();
            // 
            // btnOpenImageEditor
            // 
            btnOpenImageEditor.Location = new Point(110, 61);
            btnOpenImageEditor.Name = "btnOpenImageEditor";
            btnOpenImageEditor.Size = new Size(137, 23);
            btnOpenImageEditor.TabIndex = 0;
            btnOpenImageEditor.Text = "Edit Image";
            btnOpenImageEditor.UseVisualStyleBackColor = true;
            btnOpenImageEditor.Click += btnOpenImageEditor_Click;
            // 
            // btnOpenPicSew
            // 
            btnOpenPicSew.Location = new Point(110, 107);
            btnOpenPicSew.Name = "btnOpenPicSew";
            btnOpenPicSew.Size = new Size(137, 23);
            btnOpenPicSew.TabIndex = 1;
            btnOpenPicSew.Text = "Stitch Images";
            btnOpenPicSew.UseVisualStyleBackColor = true;
            btnOpenPicSew.Click += btnOpenPicSew_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 187);
            Controls.Add(btnOpenPicSew);
            Controls.Add(btnOpenImageEditor);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenImageEditor;
        private Button btnOpenPicSew;
    }
}