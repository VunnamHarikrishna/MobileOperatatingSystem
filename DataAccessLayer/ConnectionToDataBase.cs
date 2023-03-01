using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Entities
{
   public class ConnectionToDataBase
    {
        private static string str = ConfigurationManager.ConnectionStrings["Dbcon"].ConnectionString;

        private static SqlConnection con = new SqlConnection(str);
        public SqlConnection getConnection()
        {
            return con;
        }
        public void OpenConnection()
        {

            con.Open();
            Console.WriteLine("connection established");
        }
        public void CloseConnection()
        {
            con.Close();
            Console.WriteLine("connection closed");
        }

    }

}
