using System.Data.SqlClient;

namespace DBControl
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection();


        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to close?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {


            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BusinessLogic.Instance.Search(dataGridView: dgv, ProductName: txtKeyword.Text);
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            ViewAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (BusinessLogic.Instance.Insert(dataGridView: dgv))
            {
                MessageBox.Show("Thêm thành công");
            }
        }

        private void ViewAll()
        {
            BusinessLogic.Instance.View(dataGridView: dgv);
        }
    }
}