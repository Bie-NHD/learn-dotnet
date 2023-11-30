namespace WinFormsApp1
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
            label_ChuongTrinh = new Label();
            label_MaDon = new Label();
            label_TenPhim = new Label();
            label_NgayChieu = new Label();
            label_DoTuoi = new Label();
            groupBox_ThongTin = new GroupBox();
            panel1 = new Panel();
            rad2D = new RadioButton();
            rad3D = new RadioButton();
            dtpNgayCongChieu = new DateTimePicker();
            radHanhDong = new RadioButton();
            radTinhCam = new RadioButton();
            txtPhuThu = new TextBox();
            txtDoTuoi = new TextBox();
            txtQuocGia = new TextBox();
            txtTenPhim = new TextBox();
            txtMaDon = new TextBox();
            label_PhuThu = new Label();
            label_DinhDang = new Label();
            label_TheLoai = new Label();
            label_QuocGia = new Label();
            txtGhedoi = new TextBox();
            label_Ghedoi = new Label();
            groupBox_TacVu = new GroupBox();
            btnThongKe = new Button();
            btnXapXep = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            groupBox_DanhSachPhim = new GroupBox();
            lvDanhSach = new ListView();
            colMaDon = new ColumnHeader();
            colTenPhim = new ColumnHeader();
            colTheLoai = new ColumnHeader();
            colNgayCongChieu = new ColumnHeader();
            colQuocGia = new ColumnHeader();
            colDoTuoiQuyDinh = new ColumnHeader();
            colDinhDang = new ColumnHeader();
            colPhuThu = new ColumnHeader();
            groupBox_ThongTin.SuspendLayout();
            panel1.SuspendLayout();
            groupBox_TacVu.SuspendLayout();
            groupBox_DanhSachPhim.SuspendLayout();
            SuspendLayout();
            // 
            // label_ChuongTrinh
            // 
            label_ChuongTrinh.AccessibleRole = AccessibleRole.None;
            label_ChuongTrinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_ChuongTrinh.Location = new Point(268, 9);
            label_ChuongTrinh.Name = "label_ChuongTrinh";
            label_ChuongTrinh.Size = new Size(815, 28);
            label_ChuongTrinh.TabIndex = 0;
            label_ChuongTrinh.Text = "CHƯƠNG TRÌNH QUẢN LÍ DOANH THU PHIM CHIẾU RẠP";
            label_ChuongTrinh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_MaDon
            // 
            label_MaDon.AutoSize = true;
            label_MaDon.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_MaDon.Location = new Point(11, 33);
            label_MaDon.Name = "label_MaDon";
            label_MaDon.Size = new Size(62, 18);
            label_MaDon.TabIndex = 0;
            label_MaDon.Text = "Mã đơn:";
            // 
            // label_TenPhim
            // 
            label_TenPhim.AutoSize = true;
            label_TenPhim.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_TenPhim.Location = new Point(11, 76);
            label_TenPhim.Name = "label_TenPhim";
            label_TenPhim.Size = new Size(73, 18);
            label_TenPhim.TabIndex = 1;
            label_TenPhim.Text = "Tên phim:";
            // 
            // label_NgayChieu
            // 
            label_NgayChieu.AutoSize = true;
            label_NgayChieu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_NgayChieu.Location = new Point(11, 205);
            label_NgayChieu.Name = "label_NgayChieu";
            label_NgayChieu.Size = new Size(122, 18);
            label_NgayChieu.TabIndex = 4;
            label_NgayChieu.Text = "Ngày công chiếu:";
            // 
            // label_DoTuoi
            // 
            label_DoTuoi.AutoSize = true;
            label_DoTuoi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_DoTuoi.Location = new Point(11, 248);
            label_DoTuoi.Name = "label_DoTuoi";
            label_DoTuoi.Size = new Size(118, 18);
            label_DoTuoi.TabIndex = 5;
            label_DoTuoi.Text = "Độ tuổi quy định:";
            // 
            // groupBox_ThongTin
            // 
            groupBox_ThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_ThongTin.Controls.Add(panel1);
            groupBox_ThongTin.Controls.Add(dtpNgayCongChieu);
            groupBox_ThongTin.Controls.Add(radHanhDong);
            groupBox_ThongTin.Controls.Add(radTinhCam);
            groupBox_ThongTin.Controls.Add(txtPhuThu);
            groupBox_ThongTin.Controls.Add(txtDoTuoi);
            groupBox_ThongTin.Controls.Add(txtQuocGia);
            groupBox_ThongTin.Controls.Add(txtTenPhim);
            groupBox_ThongTin.Controls.Add(txtMaDon);
            groupBox_ThongTin.Controls.Add(label_PhuThu);
            groupBox_ThongTin.Controls.Add(label_DinhDang);
            groupBox_ThongTin.Controls.Add(label_TenPhim);
            groupBox_ThongTin.Controls.Add(label_DoTuoi);
            groupBox_ThongTin.Controls.Add(label_NgayChieu);
            groupBox_ThongTin.Controls.Add(label_TheLoai);
            groupBox_ThongTin.Controls.Add(label_QuocGia);
            groupBox_ThongTin.Controls.Add(label_MaDon);
            groupBox_ThongTin.Controls.Add(txtGhedoi);
            groupBox_ThongTin.Controls.Add(label_Ghedoi);
            groupBox_ThongTin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_ThongTin.Location = new Point(0, 48);
            groupBox_ThongTin.Name = "groupBox_ThongTin";
            groupBox_ThongTin.Size = new Size(482, 393);
            groupBox_ThongTin.TabIndex = 1;
            groupBox_ThongTin.TabStop = false;
            groupBox_ThongTin.Text = "Thông tin phim";
            // 
            // panel1
            // 
            panel1.Controls.Add(rad2D);
            panel1.Controls.Add(rad3D);
            panel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(112, 271);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 45);
            panel1.TabIndex = 7;
            // 
            // rad2D
            // 
            rad2D.AutoSize = true;
            rad2D.Checked = true;
            rad2D.Location = new Point(35, 13);
            rad2D.Name = "rad2D";
            rad2D.Size = new Size(48, 22);
            rad2D.TabIndex = 0;
            rad2D.TabStop = true;
            rad2D.Text = "2D";
            rad2D.UseVisualStyleBackColor = true;
            rad2D.CheckedChanged += rad2D_CheckedChanged;
            // 
            // rad3D
            // 
            rad3D.AutoSize = true;
            rad3D.Location = new Point(174, 13);
            rad3D.Name = "rad3D";
            rad3D.Size = new Size(48, 22);
            rad3D.TabIndex = 1;
            rad3D.Text = "3D";
            rad3D.UseVisualStyleBackColor = true;
            rad3D.CheckedChanged += rad3D_CheckedChanged;
            // 
            // dtpNgayCongChieu
            // 
            dtpNgayCongChieu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayCongChieu.Format = DateTimePickerFormat.Short;
            dtpNgayCongChieu.Location = new Point(141, 197);
            dtpNgayCongChieu.Name = "dtpNgayCongChieu";
            dtpNgayCongChieu.Size = new Size(218, 24);
            dtpNgayCongChieu.TabIndex = 5;
            dtpNgayCongChieu.ValueChanged += dtpNgayCongChieu_ValueChanged;
            // 
            // radHanhDong
            // 
            radHanhDong.AutoSize = true;
            radHanhDong.Checked = true;
            radHanhDong.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radHanhDong.Location = new Point(242, 163);
            radHanhDong.Name = "radHanhDong";
            radHanhDong.Size = new Size(101, 22);
            radHanhDong.TabIndex = 4;
            radHanhDong.TabStop = true;
            radHanhDong.Text = "Hành động";
            radHanhDong.UseVisualStyleBackColor = true;

            // 
            // radTinhCam
            // 
            radTinhCam.AutoSize = true;
            radTinhCam.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radTinhCam.Location = new Point(118, 163);
            radTinhCam.Name = "radTinhCam";
            radTinhCam.Size = new Size(90, 22);
            radTinhCam.TabIndex = 3;
            radTinhCam.Text = "Tình cảm";
            radTinhCam.UseVisualStyleBackColor = true;
            // 
            // txtPhuThu
            // 
            txtPhuThu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhuThu.Location = new Point(193, 333);
            txtPhuThu.Name = "txtPhuThu";
            txtPhuThu.Size = new Size(150, 24);
            txtPhuThu.TabIndex = 8;
            txtPhuThu.Visible = false;
            txtPhuThu.TextChanged += txtPhuThu_TextChanged;
            // 
            // txtDoTuoi
            // 
            txtDoTuoi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoTuoi.Location = new Point(141, 241);
            txtDoTuoi.Name = "txtDoTuoi";
            txtDoTuoi.Size = new Size(218, 24);
            txtDoTuoi.TabIndex = 6;
            txtDoTuoi.TextChanged += txtDoTuoi_TextChanged;
            // 
            // txtQuocGia
            // 
            txtQuocGia.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuocGia.Location = new Point(118, 119);
            txtQuocGia.Name = "txtQuocGia";
            txtQuocGia.Size = new Size(241, 24);
            txtQuocGia.TabIndex = 2;
            txtQuocGia.TextChanged += txtQuocGia_TextChanged;
            // 
            // txtTenPhim
            // 
            txtTenPhim.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenPhim.Location = new Point(118, 73);
            txtTenPhim.Name = "txtTenPhim";
            txtTenPhim.Size = new Size(241, 24);
            txtTenPhim.TabIndex = 1;
            txtTenPhim.TextChanged += txtTenPhim_TextChanged;
            // 
            // txtMaDon
            // 
            txtMaDon.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaDon.Location = new Point(118, 27);
            txtMaDon.Name = "txtMaDon";
            txtMaDon.Size = new Size(241, 24);
            txtMaDon.TabIndex = 0;
            txtMaDon.TextChanged += txtMaDon_TextChanged;
            // 
            // label_PhuThu
            // 
            label_PhuThu.AutoSize = true;
            label_PhuThu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_PhuThu.Location = new Point(12, 336);
            label_PhuThu.Name = "label_PhuThu";
            label_PhuThu.Size = new Size(184, 18);
            label_PhuThu.TabIndex = 7;
            label_PhuThu.Text = "Phụ thu suất chiếu đặt biệt:";
            label_PhuThu.Visible = false;
            // 
            // label_DinhDang
            // 
            label_DinhDang.AutoSize = true;
            label_DinhDang.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_DinhDang.Location = new Point(11, 291);
            label_DinhDang.Name = "label_DinhDang";
            label_DinhDang.Size = new Size(78, 18);
            label_DinhDang.TabIndex = 6;
            label_DinhDang.Text = "Định dạng:";
            // 
            // label_TheLoai
            // 
            label_TheLoai.AutoSize = true;
            label_TheLoai.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_TheLoai.Location = new Point(11, 163);
            label_TheLoai.Name = "label_TheLoai";
            label_TheLoai.Size = new Size(64, 18);
            label_TheLoai.TabIndex = 3;
            label_TheLoai.Text = "Thể loại:";
            // 
            // label_QuocGia
            // 
            label_QuocGia.AutoSize = true;
            label_QuocGia.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_QuocGia.Location = new Point(11, 119);
            label_QuocGia.Name = "label_QuocGia";
            label_QuocGia.Size = new Size(72, 18);
            label_QuocGia.TabIndex = 2;
            label_QuocGia.Text = "Quốc gia:";
            // 
            // txtGhedoi
            // 
            txtGhedoi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtGhedoi.Location = new Point(193, 330);
            txtGhedoi.Name = "txtGhedoi";
            txtGhedoi.Size = new Size(150, 24);
            txtGhedoi.TabIndex = 10;
            // 
            // label_Ghedoi
            // 
            label_Ghedoi.AutoSize = true;
            label_Ghedoi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_Ghedoi.Location = new Point(11, 333);
            label_Ghedoi.Name = "label_Ghedoi";
            label_Ghedoi.Size = new Size(125, 18);
            label_Ghedoi.TabIndex = 9;
            label_Ghedoi.Text = "Phụ thu Ghế Đôi :";
            // 
            // groupBox_TacVu
            // 
            groupBox_TacVu.Controls.Add(btnThongKe);
            groupBox_TacVu.Controls.Add(btnXapXep);
            groupBox_TacVu.Controls.Add(btnSua);
            groupBox_TacVu.Controls.Add(btnXoa);
            groupBox_TacVu.Controls.Add(btnLuu);
            groupBox_TacVu.Controls.Add(btnThem);
            groupBox_TacVu.Location = new Point(23, 447);
            groupBox_TacVu.Name = "groupBox_TacVu";
            groupBox_TacVu.Size = new Size(695, 79);
            groupBox_TacVu.TabIndex = 2;
            groupBox_TacVu.TabStop = false;
            groupBox_TacVu.Text = "Tác vụ";
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = SystemColors.GradientActiveCaption;
            btnThongKe.Location = new Point(589, 33);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(94, 29);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnXapXep
            // 
            btnXapXep.BackColor = SystemColors.GradientActiveCaption;
            btnXapXep.Location = new Point(467, 33);
            btnXapXep.Name = "btnXapXep";
            btnXapXep.Size = new Size(94, 29);
            btnXapXep.TabIndex = 4;
            btnXapXep.Text = "Sắp xếp";
            btnXapXep.UseVisualStyleBackColor = false;
            btnXapXep.Click += btnXapXep_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.GradientActiveCaption;
            btnSua.Enabled = false;
            btnSua.Location = new Point(347, 33);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.GradientActiveCaption;
            btnXoa.Location = new Point(229, 33);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.GradientActiveCaption;
            btnLuu.Enabled = false;
            btnLuu.Location = new Point(118, 33);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.GradientActiveCaption;
            btnThem.Enabled = false;
            btnThem.Location = new Point(6, 33);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox_DanhSachPhim
            // 
            groupBox_DanhSachPhim.Controls.Add(lvDanhSach);
            groupBox_DanhSachPhim.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_DanhSachPhim.Location = new Point(447, 48);
            groupBox_DanhSachPhim.Name = "groupBox_DanhSachPhim";
            groupBox_DanhSachPhim.Size = new Size(878, 393);
            groupBox_DanhSachPhim.TabIndex = 3;
            groupBox_DanhSachPhim.TabStop = false;
            groupBox_DanhSachPhim.Text = "Danh sách phim";
            // 
            // lvDanhSach
            // 
            lvDanhSach.BorderStyle = BorderStyle.None;
            lvDanhSach.Columns.AddRange(new ColumnHeader[] { colMaDon, colTenPhim, colTheLoai, colNgayCongChieu, colQuocGia, colDoTuoiQuyDinh, colDinhDang, colPhuThu });
            lvDanhSach.Dock = DockStyle.Fill;
            lvDanhSach.FullRowSelect = true;
            lvDanhSach.HideSelection = true;
            lvDanhSach.Location = new Point(3, 26);
            lvDanhSach.Name = "lvDanhSach";
            lvDanhSach.Size = new Size(872, 364);
            lvDanhSach.TabIndex = 0;
            lvDanhSach.UseCompatibleStateImageBehavior = false;
            lvDanhSach.View = View.Details;
            lvDanhSach.SelectedIndexChanged += lvDanhSach_SelectedIndexChanged;
            // 
            // colMaDon
            // 
            colMaDon.Text = "Mã Đơn";
            colMaDon.Width = 85;
            // 
            // colTenPhim
            // 
            colTenPhim.Text = "Tên Phim";
            colTenPhim.TextAlign = HorizontalAlignment.Center;
            colTenPhim.Width = 85;
            // 
            // colTheLoai
            // 
            colTheLoai.Text = "Thể Loại";
            colTheLoai.TextAlign = HorizontalAlignment.Center;
            colTheLoai.Width = 100;
            // 
            // colNgayCongChieu
            // 
            colNgayCongChieu.Text = "Relestdate";
            colNgayCongChieu.TextAlign = HorizontalAlignment.Center;
            colNgayCongChieu.Width = 145;
            // 
            // colQuocGia
            // 
            colQuocGia.Text = "Quốc gia";
            colQuocGia.TextAlign = HorizontalAlignment.Center;
            colQuocGia.Width = 90;
            // 
            // colDoTuoiQuyDinh
            // 
            colDoTuoiQuyDinh.Text = "Độ tuổi quy định";
            colDoTuoiQuyDinh.TextAlign = HorizontalAlignment.Center;
            colDoTuoiQuyDinh.Width = 160;
            // 
            // colDinhDang
            // 
            colDinhDang.Text = "2D/3D";
            colDinhDang.TextAlign = HorizontalAlignment.Center;
            colDinhDang.Width = 90;
            // 
            // colPhuThu
            // 
            colPhuThu.Text = "Special Class";
            colPhuThu.TextAlign = HorizontalAlignment.Center;
            colPhuThu.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 535);
            Controls.Add(groupBox_DanhSachPhim);
            Controls.Add(groupBox_TacVu);
            Controls.Add(groupBox_ThongTin);
            Controls.Add(label_ChuongTrinh);
            Name = "Form1";
            Text = "6251071050 - Phan Vỹ Kiệt";
            FormClosing += Form1_FormClosing_1;
            groupBox_ThongTin.ResumeLayout(false);
            groupBox_ThongTin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox_TacVu.ResumeLayout(false);
            groupBox_DanhSachPhim.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label_ChuongTrinh;
        private Label label_MaDon;
        private Label label_TenPhim;
        private Label label_NgayChieu;
        private Label label_DoTuoi;
        private GroupBox groupBox_ThongTin;
        private Label label_PhuThu;
        private Label label_DinhDang;
        private Label label_TheLoai;
        private Label label_QuocGia;
        private TextBox txtQuocGia;
        private TextBox txtTenPhim;
        private TextBox txtMaDon;
        private TextBox txtPhuThu;
        private TextBox txtDoTuoi;
        private DateTimePicker dtpNgayCongChieu;
        private RadioButton radHanhDong;
        private RadioButton radTinhCam;
        private GroupBox groupBox_TacVu;
        private Button btnThongKe;
        private Button btnXapXep;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThem;
        private GroupBox groupBox_DanhSachPhim;
        private ListView lvDanhSach;
        private ColumnHeader colMaDon;
        private ColumnHeader colTenPhim;
        private ColumnHeader colTheLoai;
        private ColumnHeader colNgayCongChieu;
        private Panel panel1;
        private RadioButton rad2D;
        private RadioButton rad3D;
        private String sDinhDang;
        private String sTheLoai;
        private ColumnHeader colQuocGia;
        private ColumnHeader colDoTuoiQuyDinh;
        private ColumnHeader colDinhDang;
        private ColumnHeader colPhuThu;
        private Label label_Ghedoi;
        private TextBox txtGhedoi;
    }
}