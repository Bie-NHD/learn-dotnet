namespace DBControl
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
            splitContainer1 = new SplitContainer();
            dgv = new DataGridView();
            btn_print = new Button();
            btn_export_excel = new Button();
            btnDelete = new Button();
            btnInsert = new Button();
            btnView = new Button();
            btnSearch = new Button();
            txtKeyword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgv);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btn_print);
            splitContainer1.Panel2.Controls.Add(btn_export_excel);
            splitContainer1.Panel2.Controls.Add(btnDelete);
            splitContainer1.Panel2.Controls.Add(btnInsert);
            splitContainer1.Panel2.Controls.Add(btnView);
            splitContainer1.Panel2.Controls.Add(btnSearch);
            splitContainer1.Panel2.Controls.Add(txtKeyword);
            splitContainer1.Size = new Size(1223, 641);
            splitContainer1.SplitterDistance = 700;
            splitContainer1.TabIndex = 0;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(0, 0);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 82;
            dgv.RowTemplate.Height = 41;
            dgv.Size = new Size(700, 641);
            dgv.TabIndex = 0;
            // 
            // btn_print
            // 
            btn_print.Location = new Point(225, 495);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(150, 46);
            btn_print.TabIndex = 6;
            btn_print.Text = "Print Report";
            btn_print.UseVisualStyleBackColor = true;
            btn_print.Click += btn_print_Click;
            // 
            // btn_export_excel
            // 
            btn_export_excel.Location = new Point(53, 495);
            btn_export_excel.Name = "btn_export_excel";
            btn_export_excel.Size = new Size(150, 46);
            btn_export_excel.TabIndex = 5;
            btn_export_excel.Text = "Export Excel";
            btn_export_excel.UseVisualStyleBackColor = true;
            btn_export_excel.Click += btn_export_excel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(39, 233);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(456, 46);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(39, 168);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(456, 46);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Thêm";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(39, 106);
            btnView.Name = "btnView";
            btnView.Size = new Size(456, 46);
            btnView.TabIndex = 2;
            btnView.Text = "Xem";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(345, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(39, 44);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(281, 39);
            txtKeyword.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 641);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgv;
        private Button btnDelete;
        private Button btnInsert;
        private Button btnView;
        private Button btnSearch;
        private TextBox txtKeyword;
        private Button btn_export_excel;
        private Button btn_print;
    }
}