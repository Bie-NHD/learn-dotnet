using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        void reset()
        {
            txtMaDon.Clear();
            txtMaDon.Focus();
            txtDoTuoi.Clear();
            txtPhuThu.Clear();
            txtQuocGia.Clear();
            txtTenPhim.Clear();
            dtpNgayCongChieu.Value = DateTime.Now;
            radHanhDong.Checked = true;
            radTinhCam.Checked = false;
            rad2D.Checked = false;
            rad3D.Checked = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            if (radTinhCam.Checked)
            {
                sTheLoai = "Tình cảm";
            }
            else sTheLoai = "Hành động";
            if (rad2D.Checked)
            {
                sDinhDang = "2D";
            }
            else sDinhDang = "3D";
            if (rad3D.Checked)
            {
                String[] dataRow = { txtMaDon.Text, txtTenPhim.Text, sTheLoai, dtpNgayCongChieu.Text, txtQuocGia.Text, txtDoTuoi.Text, sDinhDang, txtPhuThu.Text };

                ListViewItem li = new ListViewItem(dataRow);

                lvDanhSach.Items.Add(li);
                reset();
            }
            else
            {
                String[] dataRow = { txtMaDon.Text, txtTenPhim.Text, sTheLoai, dtpNgayCongChieu.Text, txtQuocGia.Text, txtDoTuoi.Text, sDinhDang, txtGhedoi.Text };

                ListViewItem li = new ListViewItem(dataRow);

                lvDanhSach.Items.Add(li);
                reset();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ListViewItem li = lvDanhSach.SelectedItems[0];

            li.SubItems[0].Text = txtMaDon.Text;
            li.SubItems[1].Text = txtTenPhim.Text;
            li.SubItems[2].Text = sTheLoai;
            li.SubItems[3].Text = dtpNgayCongChieu.Text;
            li.SubItems[4].Text = txtQuocGia.Text;
            li.SubItems[5].Text = txtDoTuoi.Text;
            li.SubItems[6].Text = sDinhDang;
            if (rad3D.Checked == true)
            {
                li.SubItems[7].Text = txtGhedoi.Text;
            }
            else
            {
                li.SubItems[7].Text = txtPhuThu.Text;
            }
            MessageBox.Show("Đã lưu thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (lvDanhSach.SelectedItems.Count > 0)
            {
                btnSua.Enabled = true;
                txtMaDon.Text = lvDanhSach.SelectedItems[0].SubItems[0].Text;
                txtTenPhim.Text = lvDanhSach.SelectedItems[0].SubItems[1].Text;
                if (sTheLoai == "Hành động")
                {
                    radHanhDong.Checked = true;
                }
                else radTinhCam.Checked = true;
                dtpNgayCongChieu.Text = lvDanhSach.SelectedItems[0].SubItems[3].Text;
                txtQuocGia.Text = lvDanhSach.SelectedItems[0].SubItems[4].Text;
                txtDoTuoi.Text = lvDanhSach.SelectedItems[0].SubItems[5].Text;
                if (sDinhDang == "2D")
                {
                    rad2D.Checked = true;
                }
                else rad3D.Checked = true;
                txtPhuThu.Text = lvDanhSach.SelectedItems[0].SubItems[7].Text;
            }
            else
            {
                btnSua.Enabled = false;
                btnLuu.Enabled = false;
                reset();
            }


        }

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            if (lvDanhSach.SelectedItems.Count > 0)
            {
                btnSua.Enabled = true;
                txtMaDon.Text = lvDanhSach.SelectedItems[0].SubItems[0].Text;
                txtTenPhim.Text = lvDanhSach.SelectedItems[0].SubItems[1].Text;
                if (sTheLoai == "Hành động")
                {
                    radHanhDong.Checked = true;
                }
                else radTinhCam.Checked = true;
                dtpNgayCongChieu.Text = lvDanhSach.SelectedItems[0].SubItems[3].Text;
                txtQuocGia.Text = lvDanhSach.SelectedItems[0].SubItems[4].Text;
                txtDoTuoi.Text = lvDanhSach.SelectedItems[0].SubItems[5].Text;
                if (sDinhDang == "2D")
                {
                    rad2D.Checked = true;
                }
                else rad3D.Checked = true;
                txtPhuThu.Text = lvDanhSach.SelectedItems[0].SubItems[7].Text;
            }
            else
            {
                btnSua.Enabled = false;
                reset();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lvDanhSach.SelectedItems)
            {
                lvDanhSach.Items.Remove(selectedItem);
            }
        }

        private void btnXapXep_Click(object sender, EventArgs e)
        {


            lvDanhSach.Sorting = SortOrder.Ascending;
            lvDanhSach.Sort();

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int iObjectCount = lvDanhSach.Items.Count;
            MessageBox.Show("Rạp chiếu phim hiện đang có " + iObjectCount.ToString() + "lượt chiếu phim ");
        }

        private void txtMaDon_TextChanged(object sender, EventArgs e)
        {
            if (txtMaDon.Text == "" || txtTenPhim.Text == "" || txtDoTuoi.Text == "" || txtQuocGia.Text == "")
            {
                btnLuu.Enabled = false;
                btnThem.Enabled = false;

            }
            else
            {

                if (btnSua.Enabled)
                {
                    btnLuu.Enabled = true;
                }
                else btnThem.Enabled = true;
            }
        }

        private void txtTenPhim_TextChanged(object sender, EventArgs e)
        {
            if (txtMaDon.Text == "" || txtTenPhim.Text == "" || txtDoTuoi.Text == "" || txtQuocGia.Text == "")
            {
                btnLuu.Enabled = false;
                btnThem.Enabled = false;

            }
            else
            {
                if (btnSua.Enabled)
                {
                    btnLuu.Enabled = true;
                }
                else btnThem.Enabled = true;
            }
        }

        private void txtQuocGia_TextChanged(object sender, EventArgs e)
        {
            if (txtMaDon.Text == "" || txtTenPhim.Text == "" || txtDoTuoi.Text == "" || txtQuocGia.Text == "")
            {
                btnLuu.Enabled = false;
                btnThem.Enabled = false;

            }
            else
            {
                if (btnSua.Enabled)
                {
                    btnLuu.Enabled = true;
                }
                else btnThem.Enabled = true;
            }
        }

        private void dtpNgayCongChieu_ValueChanged(object sender, EventArgs e)
        {
            if (txtMaDon.Text == "" || txtTenPhim.Text == "" || txtDoTuoi.Text == "" || txtQuocGia.Text == "")
            {
                btnLuu.Enabled = false;
                btnThem.Enabled = false;

            }
            else
            {
                if (btnSua.Enabled)
                {
                    btnLuu.Enabled = true;
                }
                else btnThem.Enabled = true;
            }
        }

        private void txtDoTuoi_TextChanged(object sender, EventArgs e)
        {
            if (txtMaDon.Text == "" || txtTenPhim.Text == "" || txtDoTuoi.Text == "" || txtQuocGia.Text == "")
            {
                btnLuu.Enabled = false;
                btnThem.Enabled = false;

            }
            else
            {
                if (btnSua.Enabled)
                {
                    btnLuu.Enabled = true;
                }
                else btnThem.Enabled = true;
            }
        }

        private void txtPhuThu_TextChanged(object sender, EventArgs e)
        {

            if (txtMaDon.Text == "" || txtTenPhim.Text == "" || txtDoTuoi.Text == "" || txtQuocGia.Text == "")
            {
                btnLuu.Enabled = false;
                btnThem.Enabled = false;

            }
            else
            {
                if (btnSua.Enabled)
                {
                    btnLuu.Enabled = true;
                }
                else btnThem.Enabled = true;
            }

        }
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Ngăn chặn việc đóng chương trình
            }
        }

        private void rad3D_CheckedChanged(object sender, EventArgs e)
        {
            if (rad3D.Checked)
            {
                label_Ghedoi.Visible = false;
                txtGhedoi.Visible = false;
                label_PhuThu.Visible = true;
                txtPhuThu.Visible = true;

            }
        }

        private void rad2D_CheckedChanged(object sender, EventArgs e)
        {
            if (rad2D.Checked)
            {
                label_PhuThu.Visible = false;
                txtPhuThu.Visible = false;
                label_Ghedoi.Visible = true;
                txtGhedoi.Visible = true;

            }
        }
    }
}