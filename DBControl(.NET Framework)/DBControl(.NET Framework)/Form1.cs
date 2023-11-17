using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBControl_.NET_Framework_
{
    public partial class Form1 : Form
    {
        const string CONNSTR = @"Data Source=localhost;Initial Catalog=localhost;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {




            string query = "SELECT * FROM [Category];";
            dataGridView1.DataSource = execSql(query);

        }
        DataTable execSql(string query, params Object[] args)
        {
            SqlConnection connection = new SqlConnection(CONNSTR);
            connection.Open();



            SqlCommand cmd = new SqlCommand(query, connection);


            if (args.Length > 0)
            {
                string[] processQuery = query.Split(' ');
                List<string> paramList = new List<string>();

                foreach ( string str in processQuery )
                {
                    if (str.StartsWith("@"))
                    {
                        if (str.EndsWith(",")||str.EndsWith(";"))
                        {
                            str.Remove(str.Length - 1);
                        }
                    }
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            connection.Close();

            return dataTable;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
