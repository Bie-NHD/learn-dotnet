using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DBControl
{
    internal class DBConnection
    {
        private const string CONNSTR = @"Data Source=localhost; Initial Catalog=personal_finance; Intergrated Security=True";
        public DataTable dbQuery(string query)
        {
            SqlConnection connection = new SqlConnection(CONNSTR);
        }
    }
}
