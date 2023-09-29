using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class OrderForm : Form
    {
        bool isDeliveryAtStore = true;
        string orderOutput;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void radDeliveryAtStore_CheckedChanged(object sender, EventArgs e)
        {
            isDeliveryAtStore = true;
        }

        private void radDeliveryToHouse_CheckedChanged(object sender, EventArgs e)
        {
            isDeliveryAtStore = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhone.Text != "" && clbItemList.Items.Count > 0)
            {
                btnConfirm.Enabled = true;

            }
            else { btnConfirm.Enabled = false; }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhone.Text != "" && clbItemList.Items.Count > 0)
            {
                btnConfirm.Enabled = true;

            }
            else { btnConfirm.Enabled = false; }
        }

        private void clbItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text != "" && txtName.Text != "")
            {
                btnConfirm.Enabled = true;
            }
            else { btnConfirm.Enabled = false; }
        }
        private void updateOrderDetails()
        {
            
        }
    }

}
