using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EricGrehan_10375977.DataAccess
{
    public class Connection
    {
        private SqlConnection conn;
        public Connection()
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;" +
            "Integrated Security=True;" +
            "Initial Catalog=AdvancedProgrammingStudentDB");
        }
        //static string ConnectionString = "" + "Data Source=(localdb)\\MSSQLLocalDB;" +
        //"Integrated Security=True;" +
        //"Initial Catalog=AdvancedProgrammingStudentDB";

        public SqlConnection openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed ||
                conn.State == System.Data.ConnectionState.Broken)
                conn.Open();
            return conn;
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        //public class UserNameandPassword
        //{
        //    Connection conn = new Connection();
        //    //public GetUserNameandPasswrd()
        //    //{

        //    //}
        //}
    }

   

}
