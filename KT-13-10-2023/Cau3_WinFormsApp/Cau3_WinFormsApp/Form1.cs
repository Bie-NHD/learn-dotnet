namespace Cau3_WinFormsApp
{
    public partial class StorageAdminForm : Form
    {
        public StorageAdminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void lblProductPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblImportDate_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void StorageAdminForm_Load(object sender, EventArgs e)
        {
            cbProductCategory.SelectedIndex = 0;
            radWarehouseHCM.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đang thoát chương trình", "Cảnh báo thoát chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                // blank 
            }
        }
    }
}