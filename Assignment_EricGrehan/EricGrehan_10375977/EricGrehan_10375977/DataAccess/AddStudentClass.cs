using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EricGrehan_10375977.DataAccess;

namespace EricGrehan_10375977.DataAccess
{
     class AddStudentClass:Connection
    {
        Connection conn = new Connection();

        public void addStudent(int studentNumber, string firstName, string surName, string email,string phone, string addressLine1, string addressLine2, string city, string county, string course, string level)
        {
            SqlCommand cmd = new SqlCommand("uspInsertIntoStudent", conn.openConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@studentnumber", studentNumber);
            cmd.Parameters.AddWithValue("@firstname", firstName);
            cmd.Parameters.AddWithValue("@surname", surName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@addressLine1", addressLine1);
            cmd.Parameters.AddWithValue("@addressLine2", addressLine2);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@county", county);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.Parameters.AddWithValue("@course", course);

            cmd.ExecuteNonQuery();
            conn.closeConnection();
        }
    }
}
