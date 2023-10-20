using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBControl
{
    internal class DataAccessObject
    {
        private static DataAccessObject instance;

        internal static DataAccessObject Instance
        {
            get
            {
                if (instance == null) { instance = new DataAccessObject(); }
                return instance;
            }
        }
        private DataAccessObject() { }

        public DataTable View()
        {
            string query = "SELECT * FROM Product";

            return DataProvider.Instance.execSql(query);

        }

        public DataTable Search(string name)
        {
            string query = "SELECT * FROM Product WHERE ProductName LIKE @keyword";
            object[] prms = new object[] { "%" + name + "%" };
            return DataProvider.Instance.execSql(query, prms);
        }
        public bool Insert (ProductModel product)
        {
            string query = $"INSERT INTO Product (ProductName, ProductPrice) VALUES ({product.ProductName},{product.ProductPrice})";

            return DataProvider.Instance.execNonSql(query) > 0;
        }

        public bool Update (ProductModel product)
        {
            string query = "UPDATE Product SET ProductName = @PRODUCTNAME, ProductPrice = @PRODUCTPRICE, WHERE ProductId = @PRODUCTID;";

            object[] prms = new object[] { product.ProductName, product.ProductPrice, product.ProductID };

            return DataProvider.Instance.execNonSql (query, prms)>0;
        }

        public bool Delete (string productID)
        {
            string query = "DELETE Product WHERE ProductID = @PRODUCTID";
            object[] prms = new object[] { productID };

            return DataProvider.Instance.execNonSql(query, prms)>0;
        }
    }
}
