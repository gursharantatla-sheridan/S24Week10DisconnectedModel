using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace S24Week10DisconnectedModel
{
    public class Data
    {
        private static string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

        public static string ConnectionString
        {
            get { return connStr; }
        }

        public DataTable GetAllProducts()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);

            string query = "select ProductID, ProductName, UnitPrice, UnitsInStock from Products";
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);

            DataSet ds = new DataSet();

            adp.Fill(ds);
            DataTable tbl = ds.Tables[0];

            return tbl;
        }
    }
}
