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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] dataRow = { txtName.Text, txtDesc.Text, txtPrice.Text };
            ListViewItem item = new ListViewItem(dataRow);
            item.ImageIndex = 0;
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

        private void mnView_List_Click(object sender, EventArgs e)
        {
            lvProductList.View = View.List;
        }

        private void mnView_Details_Click(object sender, EventArgs e)
        {
            lvProductList.View = View.Details;
        }

        private void mnView_SmallIcons_Click(object sender, EventArgs e)
        {
            lvProductList.View = View.SmallIcon;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            lvProductList.Items.Add(new ListViewItem(new string[] { "Tiger", "", "2000" }));
            lvProductList.Items.Add(new ListViewItem(new string[] { "Heineken", "", "15000" }));


            lvProductList.Items[0].ImageIndex = 0;


        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();

            lvProductList.ForeColor = dlg.Color;
        }
    }
}
