using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EricGrehan_10375977.DataAccess;

namespace EricGrehan_10375977
{
    public partial class EditStudentForm : Form
    {
        Connection conn = new Connection();
        // var commandBuilder;
        //SqlDataAdapter sda;
        //SqlCommandBuilder scb;
        //DataTable dt;
       
        public string message = " ";
        DataSet ds = new DataSet();
        public EditStudentForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.ValueMember = "StudentId";
            //comboBox1.SelectedValue
            //ValMemlabel.Text = comboBox1.ValueMember.ToString();
        }

        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void FillComboBox()
        {
            try
            {
                conn.openConnection();
                SqlCommand cmd = new SqlCommand("select StudentId,FirstName,SurName from Student group by StudentId, FirstName, SurName", conn.openConnection());
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                comboBox1.DisplayMember = "FirstName SurName";//this one
                comboBox1.DisplayMember = "SurName";
                comboBox1.ValueMember = "StudentId";
                comboBox1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //Exception Message
            }
            finally
            {
                conn.closeConnection();
            }
        }

        private void SelectStudent_Click(object sender, EventArgs e)
        {
            //When item picked from the drop down
            conn.openConnection();
            string sqlQuery = "SELECT * FROM Student WHERE StudentId = " + comboBox1.SelectedValue; 
            SqlCommand cmd = new SqlCommand(sqlQuery, conn.openConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtFirstNm.Text = (dr["FirstName"].ToString());
                txtSurNm.Text = (dr["SurName"].ToString());
                txtStuNum.Text = (dr["StudentId"].ToString());
                txtEmail.Text = (dr["Email"].ToString());
                txtPhone.Text = (dr["Phone"].ToString());
                txtAddressL1.Text = (dr["addressLine1"].ToString());
                //txtAddressL2.Text = (dr["addressLine2"].ToString());
                txtCity.Text = (dr["city"].ToString());
                textCounty.Text = (dr["county"].ToString());
                textLevel.Text = (dr["level"].ToString());
                txtCourse.Text = (dr["course"].ToString());
            }
            conn.closeConnection();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //Delete a Student
            
            if (txtStuNum.Text == null || txtFirstNm.Text == " " || txtSurNm.Text == " " )
            {
                MessageBox.Show("Please Select a Student To Delete");
            }
            else {
                Student s = new Student();
                s.DeleteStudent(int.Parse(txtStuNum.Text));
                Result.Text = "Student Record Deleted";
                txtStuNum.Clear(); txtFirstNm.Clear(); txtSurNm.Clear(); txtEmail.Clear(); txtPhone.Clear(); txtAddressL1.Clear();
                txtAddressL2.Clear(); txtCity.Clear();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            GridForm fm = new GridForm();
            fm.Show();
            this.Hide();
        }

        private void butXML_Click(object sender, EventArgs e)
        {
            DataTable dt; /*=  new DataTable();*/
            ds = new DataSet("Student");
            dt = new DataTable("Student");
            dt.Columns.Add("FirstName");
            dt.Columns.Add("SurName");
            dt.Columns.Add("StudentId");
            dt.Columns.Add("Email");
            dt.Columns.Add("Phone");
            dt.Columns.Add("addressLine1");
            dt.Columns.Add("addressLine2");
            dt.Columns.Add("city");
            dt.Columns.Add("county");
            dt.Columns.Add("level");
            dt.Columns.Add("course");
            ds.Tables.Add(dt);

            dt = ds.Tables["Student"];
            DataRow row = dt.NewRow();
            row["FirstName"] = txtFirstNm.Text;
            row["SurName"] = txtSurNm.Text;
            row["StudentId"] = txtStuNum.Text;
            row["Email"] = txtEmail.Text;
            row["Phone"] = txtPhone.Text;
            row["addressLine1"] = txtAddressL1.Text;
            row["addressLine2"] = txtAddressL2.Text;
            row["city"] = txtCity.Text;
            row["county"] = textCounty.Text;
            row["level"] = textLevel.Text;
            row["course"] = txtCourse.Text;

            dt.Rows.Add(row);
            dt.AcceptChanges();
            dt.WriteXml("StudentOutput");
            Result.Text = "Student Record Exported to XML";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.openConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Student SET /*StudentId=@a1,*/FirstName=@a2,SurName=@a3,email=@a4,phone=@a5,addressLine1=@a6,addrtessLine2=@a7,city=@a8,county=@a9,level=@a10,course=@a11  WHERE StudentId =  " + comboBox1.SelectedValue, conn.openConnection());
            //cmd.Parameters.AddWithValue("@a1", txtStuNum.Text);
            cmd.Parameters.AddWithValue("@a2", txtFirstNm.Text);
            cmd.Parameters.AddWithValue("@a3", txtSurNm.Text);
            cmd.Parameters.AddWithValue("@a4", txtEmail.Text);
            cmd.Parameters.AddWithValue("@a5", txtPhone.Text);
            cmd.Parameters.AddWithValue("@a6", txtAddressL1.Text);
            cmd.Parameters.AddWithValue("@a7", txtAddressL2.Text);
            cmd.Parameters.AddWithValue("@a8", txtCity.Text);
            cmd.Parameters.AddWithValue("@a9", textCounty.Text);
            cmd.Parameters.AddWithValue("@a10", textLevel.Text);
            cmd.Parameters.AddWithValue("@a11", txtCourse.Text);
            cmd.ExecuteNonQuery();
            conn.closeConnection();
            MessageBox.Show("Student Record Updated");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
