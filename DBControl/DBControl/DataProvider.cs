using System.Data;
using System.Data.SqlClient;

namespace DBControl
{
    internal class DataProvider
    {
        const string CONNECTION_STRING = @"Data Source=localhost;Initial Catalog=quanlykhohang;Integrated Security=True;";
        private static DataProvider instance;
       internal static DataProvider Instance {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
        }

        public DataTable execSql (string sql, params object[] args)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection
                (CONNECTION_STRING))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(sql, connection);

                if (args.Length > 0)
                {
                    string[] processSql = sql.Split(' ');
                    List<string> paramList = new List<string>();
                    foreach (string s in processSql)
                    {

                    }
                }

                

                connection.Close();
            }

            return dt;
        }

        // INSERT, UPDATE, DELETE ...
         public int  execNonSql (string sql, params object[] args)
        {
           
            int affectedRows;

            using (SqlConnection connection = new SqlConnection
                (CONNECTION_STRING))
            {
                connection.Open ();

                SqlCommand sqlCommand = new SqlCommand(sql, connection);

                if (args.Length > 0)
                {
                    string[] processSql = sql.Split(' ');
                    List<string> paramList = new List<string>();
                    foreach (string s in processSql)
                    {

                    }
                }

                affectedRows = sqlCommand.ExecuteNonQuery ();

                connection.Close ();
            }

            return affectedRows;
        }
    }
}
