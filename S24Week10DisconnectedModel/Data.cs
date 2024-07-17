using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S24Week10DisconnectedModel
{
    public class Data
    {
        private static string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";

        public static string ConnectionString
        {
            get { return connStr; }
        }
    }
}
