using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dataRow = { txtName.Text, txtDesc.Text, txtPrice.Text };
            ListViewItem item = new ListViewItem(dataRow);
            lvProductList.Items.Add(item);

            txtPrice.Clear();
            txtName.Clear();
            txtDesc.Clear();
        }

        private void lvProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProductList.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnAdd.Enabled = false;


                txtName.Text = lvProductList.SelectedItems[0].SubItems[0].Text;
                txtDesc.Text = lvProductList.SelectedItems[0].SubItems[1].Text;
                txtPrice.Text = lvProductList.SelectedItems[0].SubItems[2].Text;
            }
            else
            {

                btnEdit.Enabled = false;
                btnAdd.Enabled = true;

                txtName.Clear();
                txtDesc.Clear();
                txtPrice.Clear();

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string[] itemData = { txtName.Text, txtDesc.Text, txtPrice.Text };
            lvProductList.Items[lvProductList.SelectedIndices[0]] = new ListViewItem(itemData);



        }
    }
}
