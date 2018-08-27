using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EricGrehan_10375977.DataAccess
{
    class DeleteStudentClass
    {
        Connection conn = new Connection();

        public void DeleteStudent(int studentnumber)
        {
            SqlCommand cmd = new SqlCommand("uspDeleteFromStudent", conn.openConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",studentnumber);
            cmd.ExecuteNonQuery();
            conn.closeConnection();
        }
    }
}
