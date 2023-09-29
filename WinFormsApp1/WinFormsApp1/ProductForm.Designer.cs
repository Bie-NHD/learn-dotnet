namespace WinFormsApp1
{
    partial class ProductForm
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
            lblProductName = new Label();
            lblProductDesc = new Label();
            lblProductPrice = new Label();
            lblTitle = new Label();
            txtName = new TextBox();
            txtDesc = new TextBox();
            txtPrice = new TextBox();
            groupBox1 = new GroupBox();
            lvProductList = new ListView();
            ProductName = new ColumnHeader();
            ProductDesc = new ColumnHeader();
            ProductPrice = new ColumnHeader();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(10, 67);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(171, 32);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Tên sản phẩm";
            // 
            // lblProductDesc
            // 
            lblProductDesc.AutoSize = true;
            lblProductDesc.Location = new Point(13, 132);
            lblProductDesc.Name = "lblProductDesc";
            lblProductDesc.Size = new Size(81, 32);
            lblProductDesc.TabIndex = 1;
            lblProductDesc.Text = "Mô tả";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(6, 204);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(104, 32);
            lblProductPrice.TabIndex = 2;
            lblProductPrice.Text = "Đơn giá";
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(10);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10);
            lblTitle.Size = new Size(2082, 52);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "THÔNG TIN SẢN PHẨM";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Location = new Point(206, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(426, 39);
            txtName.TabIndex = 4;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(206, 125);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(426, 39);
            txtDesc.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(206, 197);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(426, 39);
            txtPrice.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(lvProductList);
            groupBox1.Controls.Add(lblProductName);
            groupBox1.Controls.Add(txtDesc);
            groupBox1.Controls.Add(lblProductDesc);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(lblProductPrice);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2082, 973);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // lvProductList
            // 
            lvProductList.BorderStyle = BorderStyle.FixedSingle;
            lvProductList.CheckBoxes = true;
            lvProductList.Columns.AddRange(new ColumnHeader[] { ProductName, ProductDesc, ProductPrice });
            lvProductList.FullRowSelect = true;
            lvProductList.Location = new Point(703, 60);
            lvProductList.Name = "lvProductList";
            lvProductList.Size = new Size(1379, 714);
            lvProductList.TabIndex = 8;
            lvProductList.UseCompatibleStateImageBehavior = false;
            lvProductList.View = View.Details;
            lvProductList.SelectedIndexChanged += lvProductList_SelectedIndexChanged;
            // 
            // ProductName
            // 
            ProductName.Tag = "Name";
            ProductName.Text = "Tên SP";
            ProductName.Width = 300;
            // 
            // ProductDesc
            // 
            ProductDesc.Tag = "Desc";
            ProductDesc.Text = "Mô tả";
            ProductDesc.Width = 300;
            // 
            // ProductPrice
            // 
            ProductPrice.Tag = "Price";
            ProductPrice.Text = "Đơn giá";
            ProductPrice.Width = 300;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 825);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2082, 200);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(1016, 69);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 3;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(796, 69);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 2;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(576, 69);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 46);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(356, 69);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2082, 1025);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            Name = "ProductForm";
            Text = "ProductForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblProductName;
        private Label lblProductDesc;
        private Label lblProductPrice;
        private Label lblTitle;
        private TextBox txtName;
        private TextBox txtDesc;
        private TextBox txtPrice;
        private GroupBox groupBox1;
        private ListView lvProductList;
        private GroupBox groupBox2;
        private ColumnHeader ProductName;
        private ColumnHeader ProductDesc;
        private ColumnHeader ProductPrice;
        private Button button3;
        private Button btnEdit;
        private Button btnAdd;
        private Button button4;
    }
}