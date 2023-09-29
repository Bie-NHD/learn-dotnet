namespace WinFormsApp1
{
    partial class OrderForm
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
            tblPMain = new TableLayoutPanel();
            lblUser = new Label();
            lblPhone = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            btnConfirm = new Button();
            cbDeliveryService = new GroupBox();
            radDeliveryToHouse = new RadioButton();
            radDeliveryAtStore = new RadioButton();
            cbPresentService = new CheckBox();
            clbItemList = new CheckedListBox();
            lblTitle = new Label();
            tblPMain.SuspendLayout();
            cbDeliveryService.SuspendLayout();
            SuspendLayout();
            // 
            // tblPMain
            // 
            tblPMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblPMain.ColumnCount = 2;
            tblPMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.4473686F));
            tblPMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.5526352F));
            tblPMain.Controls.Add(lblUser, 0, 0);
            tblPMain.Controls.Add(lblPhone, 0, 1);
            tblPMain.Controls.Add(txtName, 1, 0);
            tblPMain.Controls.Add(txtPhone, 1, 1);
            tblPMain.Location = new Point(19, 93);
            tblPMain.Margin = new Padding(10);
            tblPMain.Name = "tblPMain";
            tblPMain.Padding = new Padding(20);
            tblPMain.RowCount = 2;
            tblPMain.RowStyles.Add(new RowStyle(SizeType.Percent, 38.44221F));
            tblPMain.RowStyles.Add(new RowStyle(SizeType.Percent, 61.55779F));
            tblPMain.Size = new Size(800, 192);
            tblPMain.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUser.Location = new Point(23, 20);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(195, 55);
            lblUser.TabIndex = 0;
            lblUser.Text = "Tên khách hàng";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(23, 78);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(195, 32);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Số điện thoại";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(224, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(553, 39);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(224, 81);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(553, 39);
            txtPhone.TabIndex = 3;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(998, 817);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(150, 46);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Đặt hàng";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // cbDeliveryService
            // 
            cbDeliveryService.Controls.Add(radDeliveryToHouse);
            cbDeliveryService.Controls.Add(radDeliveryAtStore);
            cbDeliveryService.Location = new Point(19, 698);
            cbDeliveryService.Name = "cbDeliveryService";
            cbDeliveryService.Size = new Size(731, 153);
            cbDeliveryService.TabIndex = 6;
            cbDeliveryService.TabStop = false;
            cbDeliveryService.Text = "Hình thức giao hàng";
            // 
            // radDeliveryToHouse
            // 
            radDeliveryToHouse.AutoSize = true;
            radDeliveryToHouse.Location = new Point(48, 101);
            radDeliveryToHouse.Name = "radDeliveryToHouse";
            radDeliveryToHouse.Size = new Size(236, 36);
            radDeliveryToHouse.TabIndex = 1;
            radDeliveryToHouse.Text = "Giao hàng tận nơi";
            radDeliveryToHouse.UseVisualStyleBackColor = true;
            radDeliveryToHouse.CheckedChanged += radDeliveryToHouse_CheckedChanged;
            // 
            // radDeliveryAtStore
            // 
            radDeliveryAtStore.AutoSize = true;
            radDeliveryAtStore.Checked = true;
            radDeliveryAtStore.Location = new Point(48, 49);
            radDeliveryAtStore.Name = "radDeliveryAtStore";
            radDeliveryAtStore.Size = new Size(218, 36);
            radDeliveryAtStore.TabIndex = 0;
            radDeliveryAtStore.TabStop = true;
            radDeliveryAtStore.Text = "Lấy tại cửa hàng";
            radDeliveryAtStore.UseVisualStyleBackColor = true;
            radDeliveryAtStore.CheckedChanged += radDeliveryAtStore_CheckedChanged;
            // 
            // cbPresentService
            // 
            cbPresentService.AutoSize = true;
            cbPresentService.Location = new Point(19, 640);
            cbPresentService.Name = "cbPresentService";
            cbPresentService.Size = new Size(309, 36);
            cbPresentService.TabIndex = 5;
            cbPresentService.Text = "Sử dụng dịch vụ gói quà";
            cbPresentService.UseVisualStyleBackColor = true;
            // 
            // clbItemList
            // 
            clbItemList.BorderStyle = BorderStyle.FixedSingle;
            clbItemList.CheckOnClick = true;
            clbItemList.FormattingEnabled = true;
            clbItemList.Items.AddRange(new object[] { "Heineken", "Saporo", "Corona", "Xá sị chương dương", "Cocacola", "Pepsi", "Sting", "Tiger", "Saigon" });
            clbItemList.Location = new Point(19, 305);
            clbItemList.Margin = new Padding(10);
            clbItemList.Name = "clbItemList";
            clbItemList.Size = new Size(801, 290);
            clbItemList.TabIndex = 4;
            clbItemList.SelectedIndexChanged += clbItemList_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(20);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(20);
            lblTitle.Size = new Size(1347, 93);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "ĐƠN ĐẶT HÀNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 926);
            Controls.Add(lblTitle);
            Controls.Add(cbDeliveryService);
            Controls.Add(cbPresentService);
            Controls.Add(btnConfirm);
            Controls.Add(clbItemList);
            Controls.Add(tblPMain);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            tblPMain.ResumeLayout(false);
            tblPMain.PerformLayout();
            cbDeliveryService.ResumeLayout(false);
            cbDeliveryService.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tblPMain;
        private Label lblUser;
        private Label lblPhone;
        private TextBox txtName;
        private TextBox txtPhone;
        private Button btnConfirm;
        private CheckedListBox clbItemList;
        private CheckBox cbPresentService;
        private GroupBox cbDeliveryService;
        private Label lblTitle;
        private RadioButton radDeliveryToHouse;
        private RadioButton radDeliveryAtStore;
    }
}