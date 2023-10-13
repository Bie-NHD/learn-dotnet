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
                ProductName = row.Cells["ProductName"].Value.ToString(),
                ProductPrice = Convert.ToInt32(row.Cells["ProductPrice"].Value.ToString),
            };
            return DataAccessObject.Instance.Insert(product);
        }
        public void Delete() { }
    }
}
