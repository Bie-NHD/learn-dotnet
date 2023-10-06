namespace CinemaManagement
{
    partial class MovieForm
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
            components = new System.ComponentModel.Container();
            lvMovieList = new ListView();
            OrderID = new ColumnHeader();
            MovieName = new ColumnHeader();
            MovieCategory = new ColumnHeader();
            AiringDate = new ColumnHeader();
            lblTitle = new Label();
            lblOrderID = new Label();
            lblMovieName = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            grbActions = new GroupBox();
            btnStats = new Button();
            btnSort = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            tblpMovieDetails = new TableLayoutPanel();
            lblMovieOrigin = new Label();
            lblMovieCategory = new Label();
            lblMovieAiringDate = new Label();
            lblMovieRestrictAge = new Label();
            lblMovieFormat = new Label();
            txtMovieName = new TextBox();
            txtMovieOrigin = new TextBox();
            txtRestrictAge = new TextBox();
            txtAdditionalFee = new TextBox();
            grbMovieCategory = new GroupBox();
            rad_Actions = new RadioButton();
            rad_Romance = new RadioButton();
            grbMovieFormat = new GroupBox();
            rad_3D = new RadioButton();
            rad_2D = new RadioButton();
            dtpAiringDate = new DateTimePicker();
            lblAdditionalFee = new Label();
            txtOrderId = new TextBox();
            grbMovieDetails = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grbMovieList = new GroupBox();
            errorProvider1 = new ErrorProvider(components);
            grbActions.SuspendLayout();
            tblpMovieDetails.SuspendLayout();
            grbMovieCategory.SuspendLayout();
            grbMovieFormat.SuspendLayout();
            grbMovieDetails.SuspendLayout();
            grbMovieList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lvMovieList
            // 
            lvMovieList.Columns.AddRange(new ColumnHeader[] { OrderID, MovieName, MovieCategory, AiringDate });
            lvMovieList.Dock = DockStyle.Fill;
            lvMovieList.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lvMovieList.FullRowSelect = true;
            lvMovieList.Location = new Point(3, 19);
            lvMovieList.Margin = new Padding(2, 1, 2, 1);
            lvMovieList.Name = "lvMovieList";
            lvMovieList.Size = new Size(486, 308);
            lvMovieList.TabIndex = 0;
            lvMovieList.UseCompatibleStateImageBehavior = false;
            lvMovieList.View = View.Details;
            lvMovieList.ItemSelectionChanged += lvMovieList_ItemSelectionChanged;
            // 
            // OrderID
            // 
            OrderID.Text = "Mã đơn";
            OrderID.Width = 100;
            // 
            // MovieName
            // 
            MovieName.Text = "Tên Phim";
            MovieName.Width = 100;
            // 
            // MovieCategory
            // 
            MovieCategory.Text = "Thể loại";
            MovieCategory.Width = 100;
            // 
            // AiringDate
            // 
            AiringDate.Text = "Ngày công chiếu";
            AiringDate.Width = 100;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(824, 25);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "CHƯƠNG TRÌNH QUẢN LÝ PHIM CHIẾU RẠP";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrderID
            // 
            lblOrderID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblOrderID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderID.Location = new Point(3, 0);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new Size(118, 29);
            lblOrderID.TabIndex = 0;
            lblOrderID.Text = "Mã đơn";
            lblOrderID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMovieName
            // 
            lblMovieName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMovieName.AutoSize = true;
            lblMovieName.Location = new Point(3, 29);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(118, 29);
            lblMovieName.TabIndex = 1;
            lblMovieName.Text = "Tên phim";
            lblMovieName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // grbActions
            // 
            grbActions.BackColor = SystemColors.Control;
            grbActions.Controls.Add(btnStats);
            grbActions.Controls.Add(btnSort);
            grbActions.Controls.Add(btnEdit);
            grbActions.Controls.Add(btnDelete);
            grbActions.Controls.Add(btnSave);
            grbActions.Controls.Add(btnAdd);
            grbActions.Dock = DockStyle.Bottom;
            grbActions.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbActions.ForeColor = SystemColors.ControlText;
            grbActions.Location = new Point(0, 355);
            grbActions.Name = "grbActions";
            grbActions.Size = new Size(824, 74);
            grbActions.TabIndex = 2;
            grbActions.TabStop = false;
            grbActions.Text = "Tác vụ";
            // 
            // btnStats
            // 
            btnStats.Location = new Point(634, 22);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(75, 23);
            btnStats.TabIndex = 5;
            btnStats.Text = "Thống kê";
            btnStats.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(527, 22);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 4;
            btnSort.Text = "Sắp xếp";
            btnSort.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(420, 22);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(313, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(206, 22);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(99, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tblpMovieDetails
            // 
            tblpMovieDetails.AutoSize = true;
            tblpMovieDetails.ColumnCount = 2;
            tblpMovieDetails.ColumnStyles.Add(new ColumnStyle());
            tblpMovieDetails.ColumnStyles.Add(new ColumnStyle());
            tblpMovieDetails.Controls.Add(lblMovieName, 0, 1);
            tblpMovieDetails.Controls.Add(lblMovieOrigin, 0, 2);
            tblpMovieDetails.Controls.Add(lblMovieCategory, 0, 3);
            tblpMovieDetails.Controls.Add(lblMovieAiringDate, 0, 4);
            tblpMovieDetails.Controls.Add(lblMovieRestrictAge, 0, 5);
            tblpMovieDetails.Controls.Add(lblMovieFormat, 0, 6);
            tblpMovieDetails.Controls.Add(txtMovieName, 1, 1);
            tblpMovieDetails.Controls.Add(txtMovieOrigin, 1, 2);
            tblpMovieDetails.Controls.Add(txtRestrictAge, 1, 5);
            tblpMovieDetails.Controls.Add(txtAdditionalFee, 1, 7);
            tblpMovieDetails.Controls.Add(grbMovieCategory, 1, 3);
            tblpMovieDetails.Controls.Add(grbMovieFormat, 1, 6);
            tblpMovieDetails.Controls.Add(dtpAiringDate, 1, 4);
            tblpMovieDetails.Controls.Add(lblAdditionalFee, 0, 7);
            tblpMovieDetails.Controls.Add(txtOrderId, 1, 0);
            tblpMovieDetails.Controls.Add(lblOrderID, 0, 0);
            tblpMovieDetails.Dock = DockStyle.Fill;
            tblpMovieDetails.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tblpMovieDetails.ForeColor = SystemColors.ControlText;
            tblpMovieDetails.Location = new Point(2, 17);
            tblpMovieDetails.Name = "tblpMovieDetails";
            tblpMovieDetails.RowCount = 8;
            tblpMovieDetails.RowStyles.Add(new RowStyle());
            tblpMovieDetails.RowStyles.Add(new RowStyle());
            tblpMovieDetails.RowStyles.Add(new RowStyle());
            tblpMovieDetails.RowStyles.Add(new RowStyle());
            tblpMovieDetails.RowStyles.Add(new RowStyle());
            tblpMovieDetails.RowStyles.Add(new RowStyle());
            tblpMovieDetails.RowStyles.Add(new RowStyle());
            tblpMovieDetails.RowStyles.Add(new RowStyle());
            tblpMovieDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblpMovieDetails.Size = new Size(328, 312);
            tblpMovieDetails.TabIndex = 2;
            // 
            // lblMovieOrigin
            // 
            lblMovieOrigin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMovieOrigin.AutoSize = true;
            lblMovieOrigin.Location = new Point(3, 58);
            lblMovieOrigin.Name = "lblMovieOrigin";
            lblMovieOrigin.Size = new Size(118, 29);
            lblMovieOrigin.TabIndex = 2;
            lblMovieOrigin.Text = "Quốc gia";
            lblMovieOrigin.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMovieCategory
            // 
            lblMovieCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMovieCategory.AutoSize = true;
            lblMovieCategory.Location = new Point(3, 87);
            lblMovieCategory.Name = "lblMovieCategory";
            lblMovieCategory.Size = new Size(118, 69);
            lblMovieCategory.TabIndex = 3;
            lblMovieCategory.Text = "Thể loại";
            lblMovieCategory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMovieAiringDate
            // 
            lblMovieAiringDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMovieAiringDate.AutoSize = true;
            lblMovieAiringDate.Location = new Point(3, 156);
            lblMovieAiringDate.Name = "lblMovieAiringDate";
            lblMovieAiringDate.Size = new Size(118, 29);
            lblMovieAiringDate.TabIndex = 4;
            lblMovieAiringDate.Text = "Ngày công chiếu";
            lblMovieAiringDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMovieRestrictAge
            // 
            lblMovieRestrictAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMovieRestrictAge.AutoSize = true;
            lblMovieRestrictAge.Location = new Point(3, 185);
            lblMovieRestrictAge.Name = "lblMovieRestrictAge";
            lblMovieRestrictAge.Size = new Size(118, 29);
            lblMovieRestrictAge.TabIndex = 5;
            lblMovieRestrictAge.Text = "Độ tuổi quy định";
            lblMovieRestrictAge.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMovieFormat
            // 
            lblMovieFormat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMovieFormat.AutoSize = true;
            lblMovieFormat.Location = new Point(3, 214);
            lblMovieFormat.Name = "lblMovieFormat";
            lblMovieFormat.Size = new Size(118, 69);
            lblMovieFormat.TabIndex = 6;
            lblMovieFormat.Text = "Định dạng";
            lblMovieFormat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMovieName
            // 
            txtMovieName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMovieName.Location = new Point(127, 32);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(290, 23);
            txtMovieName.TabIndex = 9;
            // 
            // txtMovieOrigin
            // 
            txtMovieOrigin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMovieOrigin.Location = new Point(127, 61);
            txtMovieOrigin.Name = "txtMovieOrigin";
            txtMovieOrigin.Size = new Size(290, 23);
            txtMovieOrigin.TabIndex = 10;
            // 
            // txtRestrictAge
            // 
            txtRestrictAge.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRestrictAge.Location = new Point(127, 188);
            txtRestrictAge.Name = "txtRestrictAge";
            txtRestrictAge.Size = new Size(290, 23);
            txtRestrictAge.TabIndex = 11;
            txtRestrictAge.Validating += txtRestrictAge_Validating;
            // 
            // txtAdditionalFee
            // 
            txtAdditionalFee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAdditionalFee.Location = new Point(127, 286);
            txtAdditionalFee.Name = "txtAdditionalFee";
            txtAdditionalFee.Size = new Size(290, 23);
            txtAdditionalFee.TabIndex = 12;
            // 
            // grbMovieCategory
            // 
            grbMovieCategory.Controls.Add(rad_Actions);
            grbMovieCategory.Controls.Add(rad_Romance);
            grbMovieCategory.Location = new Point(127, 90);
            grbMovieCategory.Name = "grbMovieCategory";
            grbMovieCategory.Size = new Size(216, 63);
            grbMovieCategory.TabIndex = 15;
            grbMovieCategory.TabStop = false;
            // 
            // rad_Actions
            // 
            rad_Actions.AutoSize = true;
            rad_Actions.Location = new Point(96, 22);
            rad_Actions.Name = "rad_Actions";
            rad_Actions.Size = new Size(85, 19);
            rad_Actions.TabIndex = 1;
            rad_Actions.TabStop = true;
            rad_Actions.Text = "Hành động";
            rad_Actions.UseVisualStyleBackColor = true;
            // 
            // rad_Romance
            // 
            rad_Romance.AutoSize = true;
            rad_Romance.Location = new Point(6, 22);
            rad_Romance.Name = "rad_Romance";
            rad_Romance.Size = new Size(74, 19);
            rad_Romance.TabIndex = 0;
            rad_Romance.TabStop = true;
            rad_Romance.Text = "Tình cảm";
            rad_Romance.UseVisualStyleBackColor = true;
            // 
            // grbMovieFormat
            // 
            grbMovieFormat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grbMovieFormat.Controls.Add(rad_3D);
            grbMovieFormat.Controls.Add(rad_2D);
            grbMovieFormat.Location = new Point(127, 217);
            grbMovieFormat.Name = "grbMovieFormat";
            grbMovieFormat.Size = new Size(290, 63);
            grbMovieFormat.TabIndex = 16;
            grbMovieFormat.TabStop = false;
            // 
            // rad_3D
            // 
            rad_3D.AutoSize = true;
            rad_3D.Location = new Point(79, 22);
            rad_3D.Name = "rad_3D";
            rad_3D.Size = new Size(39, 19);
            rad_3D.TabIndex = 1;
            rad_3D.TabStop = true;
            rad_3D.Text = "3D";
            rad_3D.UseVisualStyleBackColor = true;
            // 
            // rad_2D
            // 
            rad_2D.AutoSize = true;
            rad_2D.Location = new Point(6, 22);
            rad_2D.Name = "rad_2D";
            rad_2D.Size = new Size(39, 19);
            rad_2D.TabIndex = 0;
            rad_2D.TabStop = true;
            rad_2D.Text = "2D";
            rad_2D.UseVisualStyleBackColor = true;
            // 
            // dtpAiringDate
            // 
            dtpAiringDate.CustomFormat = "dd MM yyyy hh:mm:ss";
            dtpAiringDate.Location = new Point(127, 159);
            dtpAiringDate.Name = "dtpAiringDate";
            dtpAiringDate.Size = new Size(200, 23);
            dtpAiringDate.TabIndex = 17;
            // 
            // lblAdditionalFee
            // 
            lblAdditionalFee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAdditionalFee.AutoSize = true;
            lblAdditionalFee.Location = new Point(3, 283);
            lblAdditionalFee.Name = "lblAdditionalFee";
            lblAdditionalFee.Size = new Size(118, 29);
            lblAdditionalFee.TabIndex = 7;
            lblAdditionalFee.Text = "Phụ thu phí đặc biệt";
            lblAdditionalFee.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtOrderId
            // 
            txtOrderId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrderId.Location = new Point(127, 3);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(290, 23);
            txtOrderId.TabIndex = 8;
            // 
            // grbMovieDetails
            // 
            grbMovieDetails.Controls.Add(tblpMovieDetails);
            grbMovieDetails.Dock = DockStyle.Left;
            grbMovieDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbMovieDetails.ForeColor = SystemColors.ControlText;
            grbMovieDetails.Location = new Point(0, 25);
            grbMovieDetails.Margin = new Padding(2, 1, 2, 1);
            grbMovieDetails.Name = "grbMovieDetails";
            grbMovieDetails.Padding = new Padding(2, 1, 2, 1);
            grbMovieDetails.Size = new Size(332, 330);
            grbMovieDetails.TabIndex = 1;
            grbMovieDetails.TabStop = false;
            grbMovieDetails.Text = "Thông tin phim";
            // 
            // grbMovieList
            // 
            grbMovieList.Controls.Add(lvMovieList);
            grbMovieList.Dock = DockStyle.Fill;
            grbMovieList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbMovieList.Location = new Point(332, 25);
            grbMovieList.Name = "grbMovieList";
            grbMovieList.Size = new Size(492, 330);
            grbMovieList.TabIndex = 4;
            grbMovieList.TabStop = false;
            grbMovieList.Text = "Danh sách phim";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(824, 429);
            Controls.Add(grbMovieList);
            Controls.Add(grbMovieDetails);
            Controls.Add(lblTitle);
            Controls.Add(grbActions);
            Margin = new Padding(2, 1, 2, 1);
            Name = "MovieForm";
            Text = "Form1";
            Load += MovieForm_Load;
            grbActions.ResumeLayout(false);
            tblpMovieDetails.ResumeLayout(false);
            tblpMovieDetails.PerformLayout();
            grbMovieCategory.ResumeLayout(false);
            grbMovieCategory.PerformLayout();
            grbMovieFormat.ResumeLayout(false);
            grbMovieFormat.PerformLayout();
            grbMovieDetails.ResumeLayout(false);
            grbMovieDetails.PerformLayout();
            grbMovieList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvMovieList;
        private ColumnHeader OrderID;
        private ColumnHeader MovieName;
        private ColumnHeader MovieCategory;
        private ColumnHeader AiringDate;
        private Label lblTitle;
        private Label lblOrderID;
        private Label lblMovieName;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox grbActions;
        private TableLayoutPanel tblpMovieDetails;
        private GroupBox grbMovieDetails;
        private Label lblMovieOrigin;
        private Label lblMovieCategory;
        private Label lblMovieAiringDate;
        private Label lblMovieRestrictAge;
        private Label lblMovieFormat;
        private Label lblAdditionalFee;
        private TextBox txtOrderId;
        private TextBox txtMovieName;
        private TextBox txtMovieOrigin;
        private TextBox txtRestrictAge;
        private TextBox txtAdditionalFee;
        private GroupBox grbMovieCategory;
        private RadioButton rad_Romance;
        private RadioButton rad_Actions;
        private GroupBox grbMovieFormat;
        private RadioButton rad_3D;
        private RadioButton rad_2D;
        private DateTimePicker dtpAiringDate;
        private Button btnStats;
        private Button btnSort;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grbMovieList;
        private ErrorProvider errorProvider1;
    }
}