namespace Cau3_WinFormsApp
{
    partial class StorageAdminForm
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "DT01", "Samsung Note 10+" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "LT01", "" }, -1);
            lblTitle = new Label();
            lvProductList = new ListView();
            ProductID = new ColumnHeader();
            ProductName = new ColumnHeader();
            ProductCategory = new ColumnHeader();
            ProductQuantity = new ColumnHeader();
            ProducPrice = new ColumnHeader();
            Warehouse = new ColumnHeader();
            ImportDate = new ColumnHeader();
            Total = new ColumnHeader();
            lblProductId = new Label();
            lblProductName = new Label();
            lblProductCategory = new Label();
            lblProductQuantity = new Label();
            lblProductPrice = new Label();
            lblWarehouse = new Label();
            lblImportDate = new Label();
            txtProductID = new TextBox();
            txtProductName = new TextBox();
            txtProductQuantity = new TextBox();
            txtProductPrice = new TextBox();
            dtpImportDate = new DateTimePicker();
            radWarehouseHCM = new RadioButton();
            radWareHouseDaNang = new RadioButton();
            radWarehouseHaNoi = new RadioButton();
            grbActions = new GroupBox();
            btnExit = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cbProductCategory = new ComboBox();
            grbActions.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1438, 75);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ SẢN PHẨM NHẬP KHO";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label1_Click;
            // 
            // lvProductList
            // 
            lvProductList.Columns.AddRange(new ColumnHeader[] { ProductID, ProductName, ProductCategory, ProductQuantity, ProducPrice, Warehouse, ImportDate, Total });
            lvProductList.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lvProductList.Location = new Point(0, 564);
            lvProductList.Name = "lvProductList";
            lvProductList.Size = new Size(1438, 263);
            lvProductList.TabIndex = 2;
            lvProductList.UseCompatibleStateImageBehavior = false;
            lvProductList.View = View.Details;
            // 
            // ProductID
            // 
            ProductID.Text = "Mã SP";
            ProductID.Width = 100;
            // 
            // ProductName
            // 
            ProductName.Text = "Tên SP";
            ProductName.Width = 200;
            // 
            // ProductCategory
            // 
            ProductCategory.Text = "Danh mục";
            ProductCategory.Width = 200;
            // 
            // ProductQuantity
            // 
            ProductQuantity.Text = "Số lượng";
            ProductQuantity.Width = 150;
            // 
            // ProducPrice
            // 
            ProducPrice.Text = "Đơn giá";
            ProducPrice.Width = 150;
            // 
            // Warehouse
            // 
            Warehouse.Text = "Kho";
            Warehouse.Width = 200;
            // 
            // ImportDate
            // 
            ImportDate.Text = "Ngày nhập";
            ImportDate.Width = 200;
            // 
            // Total
            // 
            Total.Text = "Thành tiền";
            Total.Width = 200;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(70, 75);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(81, 32);
            lblProductId.TabIndex = 3;
            lblProductId.Text = "Mã SP";
            lblProductId.Click += label1_Click_1;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(70, 131);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(85, 32);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "Tên SP";
            lblProductName.Click += lblProductName_Click;
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.Location = new Point(31, 174);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(124, 32);
            lblProductCategory.TabIndex = 5;
            lblProductCategory.Text = "Danh mục";
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Location = new Point(45, 223);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(110, 32);
            lblProductQuantity.TabIndex = 6;
            lblProductQuantity.Text = "Số lượng";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(53, 283);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(98, 32);
            lblProductPrice.TabIndex = 7;
            lblProductPrice.Text = "Đơn giấ";
            lblProductPrice.Click += lblProductPrice_Click;
            // 
            // lblWarehouse
            // 
            lblWarehouse.AutoSize = true;
            lblWarehouse.Location = new Point(95, 332);
            lblWarehouse.Name = "lblWarehouse";
            lblWarehouse.Size = new Size(56, 32);
            lblWarehouse.TabIndex = 8;
            lblWarehouse.Text = "Kho";
            // 
            // lblImportDate
            // 
            lblImportDate.AutoSize = true;
            lblImportDate.Location = new Point(20, 377);
            lblImportDate.Name = "lblImportDate";
            lblImportDate.Size = new Size(131, 32);
            lblImportDate.TabIndex = 9;
            lblImportDate.Text = "Ngày nhập";
            lblImportDate.Click += lblImportDate_Click;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(172, 74);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(479, 39);
            txtProductID.TabIndex = 10;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(172, 124);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(479, 39);
            txtProductName.TabIndex = 11;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(172, 223);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(479, 39);
            txtProductQuantity.TabIndex = 13;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(172, 276);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(479, 39);
            txtProductPrice.TabIndex = 14;
            // 
            // dtpImportDate
            // 
            dtpImportDate.Location = new Point(172, 377);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(479, 39);
            dtpImportDate.TabIndex = 16;
            // 
            // radWarehouseHCM
            // 
            radWarehouseHCM.AutoSize = true;
            radWarehouseHCM.Location = new Point(172, 332);
            radWarehouseHCM.Name = "radWarehouseHCM";
            radWarehouseHCM.Size = new Size(218, 36);
            radWarehouseHCM.TabIndex = 17;
            radWarehouseHCM.TabStop = true;
            radWarehouseHCM.Text = "Tp. Hồ Chí Minh";
            radWarehouseHCM.TextAlign = ContentAlignment.TopLeft;
            radWarehouseHCM.UseVisualStyleBackColor = true;
            // 
            // radWareHouseDaNang
            // 
            radWareHouseDaNang.AutoSize = true;
            radWareHouseDaNang.Location = new Point(387, 332);
            radWareHouseDaNang.Name = "radWareHouseDaNang";
            radWareHouseDaNang.Size = new Size(139, 36);
            radWareHouseDaNang.TabIndex = 18;
            radWareHouseDaNang.TabStop = true;
            radWareHouseDaNang.Text = "Đà Nẵng";
            radWareHouseDaNang.UseVisualStyleBackColor = true;
            // 
            // radWarehouseHaNoi
            // 
            radWarehouseHaNoi.AutoSize = true;
            radWarehouseHaNoi.Location = new Point(532, 335);
            radWarehouseHaNoi.Name = "radWarehouseHaNoi";
            radWarehouseHaNoi.Size = new Size(119, 36);
            radWarehouseHaNoi.TabIndex = 19;
            radWarehouseHaNoi.TabStop = true;
            radWarehouseHaNoi.Text = "Hà Nội";
            radWarehouseHaNoi.UseVisualStyleBackColor = true;
            // 
            // grbActions
            // 
            grbActions.Controls.Add(btnExit);
            grbActions.Controls.Add(btnEdit);
            grbActions.Controls.Add(btnDelete);
            grbActions.Controls.Add(btnSave);
            grbActions.Controls.Add(btnAdd);
            grbActions.Location = new Point(886, 74);
            grbActions.Name = "grbActions";
            grbActions.Size = new Size(400, 342);
            grbActions.TabIndex = 20;
            grbActions.TabStop = false;
            grbActions.Text = "Chức năng";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(76, 258);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(267, 46);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(76, 201);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(267, 46);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(76, 149);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(267, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(76, 93);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(267, 46);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(76, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(267, 46);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbProductCategory
            // 
            cbProductCategory.FormattingEnabled = true;
            cbProductCategory.Items.AddRange(new object[] { "Điện thoại", "Laptop", "Loa Bluetooth" });
            cbProductCategory.Location = new Point(172, 177);
            cbProductCategory.Name = "cbProductCategory";
            cbProductCategory.Size = new Size(479, 40);
            cbProductCategory.TabIndex = 21;
            // 
            // StorageAdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 827);
            Controls.Add(cbProductCategory);
            Controls.Add(grbActions);
            Controls.Add(radWarehouseHaNoi);
            Controls.Add(radWareHouseDaNang);
            Controls.Add(radWarehouseHCM);
            Controls.Add(dtpImportDate);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductQuantity);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(lblImportDate);
            Controls.Add(lblWarehouse);
            Controls.Add(lblProductPrice);
            Controls.Add(lblProductQuantity);
            Controls.Add(lblProductCategory);
            Controls.Add(lblProductName);
            Controls.Add(lblProductId);
            Controls.Add(lvProductList);
            Controls.Add(lblTitle);
            Name = "StorageAdminForm";
            Text = "Quản lý kho";
            Load += StorageAdminForm_Load;
            grbActions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListView lvProductList;
        private Label lblProductId;
        private Label lblProductName;
        private Label lblProductCategory;
        private Label lblProductQuantity;
        private Label lblProductPrice;
        private Label lblWarehouse;
        private Label lblImportDate;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private TextBox txtProductQuantity;
        private TextBox txtProductPrice;
        private DateTimePicker dtpImportDate;
        private RadioButton radWarehouseHCM;
        private RadioButton radWareHouseDaNang;
        private RadioButton radWarehouseHaNoi;
        private GroupBox grbActions;
        private Button btnExit;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private ColumnHeader ProductID;
        private ColumnHeader ProductName;
        private ColumnHeader ProductCategory;
        private ColumnHeader ProductQuantity;
        private ColumnHeader ProducPrice;
        private ColumnHeader Warehouse;
        private ColumnHeader ImportDate;
        private ColumnHeader Total;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cbProductCategory;
    }
}