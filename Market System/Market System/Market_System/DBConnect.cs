using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Market_System
{
    class DBConnect
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ABANS\Documents\MarketDB.mdf;Integrated Security=True;Connect Timeout=30");

        public SqlConnection GetCon()
        {
            return connection;
        }
        public void OpenCon()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
