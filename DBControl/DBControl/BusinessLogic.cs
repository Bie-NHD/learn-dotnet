using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBControl
{
    internal class BusinessLogic
    {
        private static BusinessLogic instance;

        public static BusinessLogic Instance
        {
            get
            {
                if (instance == null) { instance = new BusinessLogic(); }
                return instance;
            }
        }
        public BusinessLogic() { }

        public void View(DataGridView dataGridView)
        {
            dataGridView.DataSource = DataAccessObject.Instance.View();
            dataGridView.Columns[0].ReadOnly = true;
        }
        public void Search(DataGridView dataGridView,string ProductName)
        {
            dataGridView.DataSource = DataAccessObject.Instance.Search(name: ProductName);
        }
        public bool Insert(DataGridView dataGridView)
        {
            DataGridViewRow row = dataGridView.Rows[dataGridView.CurrentRow.Index];
            ProductModel product = new ProductModel()
            {
                ProductName = row.Cells["ProductName"].Value.ToString()??"N/A",
                ProductPrice = Convert.ToInt32(row.Cells["ProductPrice"].Value),
            };
            return DataAccessObject.Instance.Insert(product);
        }
        public bool Delete(DataGridView dgv) 
        { 
            string ProductId = dgv.Rows[dgv.CurrentRow.Index].Cells[0].Value.ToString();

            return DataAccessObject.Instance.Delete(ProductId);
        
        }
        public bool Update(DataGridView dgv)
        {
            DataGridViewRow row = dgv.Rows[dgv.CurrentRow.Index];

            ProductModel product = new ProductModel()
            {
                ProductID = row.Cells[0].Value.ToString(),
                ProductName = row.Cells["ProductName"].Value.ToString(),
                ProductPrice = Convert.ToInt32(row.Cells["ProductPrice"].Value),
            };

            return DataAccessObject.Instance.Update(product);
        }
    }
}
