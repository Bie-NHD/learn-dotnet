using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBControl
{
    internal class ProductModel
    {
        private string productId;
        private string productName;
        private int productPrice;



        public string ProductID { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int ProductPrice { get => productPrice; set => productPrice = value; }

        public ProductModel() { }
    }
}
