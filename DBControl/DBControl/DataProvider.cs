﻿using System.Data;
using System.Data.SqlClient;

namespace DBControl
{
    internal class DataProvider
    {
        const string CONNECTION_STRING = @"Data Source=localhost;Initial Catalog=u_quanlybanhang;Integrated Security=True;";
        private static DataProvider instance;
        internal static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
        }
        public static SqlConnection GetSqlConnection() => new SqlConnection(CONNECTION_STRING);

        public DataTable execSql(string sql, params Object[] args)
        {
            DataTable dat = new DataTable();
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                if (args.Length > 0)
                {
                    string[] processSql = sql.Split(' ');
                    List<string> paramList = new List<string>();
                    foreach (string s in processSql)
                        if (s.StartsWith("@"))
                        {
                            if (s.EndsWith(","))
                                paramList.Add(s.Remove(s.Length - 1));
                            else
                                paramList.Add(s);
                        }
                    for (int i = 0; i < args.Length; i++)
                        command.Parameters.AddWithValue(paramList[i], args[i]);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dat);
                connection.Close();
            }
            return dat;
        }

        // INSERT, UPDATE, DELETE ...
        public int execNonSql(string sql, params Object[] args)
        {
            int effectedRows;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                if (args.Length > 0)
                {
                    string[] processSql = sql.Split(' ');
                    List<string> paramList = new List<string>();
                    foreach (string s in processSql)
                        if (s.StartsWith("@"))
                        {
                            if (s.EndsWith(","))
                                s.Remove(s.Length - 1);
                            paramList.Add(s);
                        }
                    for (int i = 0; i < args.Length; i++)
                        command.Parameters.AddWithValue(paramList[i], args[i]);
                }
                effectedRows = command.ExecuteNonQuery();
                connection.Close();
            }
            return effectedRows;
        }
    }
}
