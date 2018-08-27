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
    public partial class AddStudentForm : Form
    {
        public string Level;
        public string message = "";
        Connection conn = new Connection();
     
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("uspInsertIntoStudent", conn.openConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            if (txtStuNum.Text == null || txtFirstName.Text == " " || txtSurName.Text == " " || County.SelectedIndex<0)
            {
                MessageBox.Show("Pleae Enter Student Details or Return to Main Window By Pressing Back");
            }
            else
            {
                Student.ADDSTUDENT(int.Parse(txtStuNum.Text), txtFirstName.Text, txtSurName.Text, txtEmail.Text, txtPhone.Text, 
                        txtAddressL1.Text, txtAddressL2.Text,
                         txtCity.Text, County.Items[County.SelectedIndex].ToString(),
                         Level, CourseCombo.Items[CourseCombo.SelectedIndex].ToString());
                Student s1 = new Student();

                //cmd.Parameters.AddWithValue("@studentnumber", txtStuNum.Text);
                //cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                //cmd.Parameters.AddWithValue("@surname", txtSurName.Text);
                //cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                //cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                //cmd.Parameters.AddWithValue("@addressLine1", txtAddressL1.Text);
                //cmd.Parameters.AddWithValue("@addressLine2", txtAddressL2.Text);
                //cmd.Parameters.AddWithValue("@city", txtCity.Text);
                //cmd.Parameters.AddWithValue("@county", County.Items[County.SelectedIndex].ToString());
                //cmd.Parameters.AddWithValue("@level", Level);
                //cmd.Parameters.AddWithValue("@course", CourseCombo.Items[CourseCombo.SelectedIndex].ToString());
                //conn.openConnection();

                //cmd.ExecuteNonQuery();//////////////////////////////////////////////////////////////////////
                Result.Text = "Student Record Created";
                conn.closeConnection();
                //conn.Close();
                txtStuNum.Clear();
                txtFirstName.Clear();
                txtSurName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtAddressL1.Clear();
                txtAddressL2.Clear();
                txtCity.Clear();

                //County.Items.Clear(); CourseCombo.Items.Clear();
            }
            //return count;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            //Form1 fm = new Form1();
            GridForm fm = new GridForm();
            fm.Show();
            this.Hide();
        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {
        }

        private void Undergratuate_CheckedChanged(object sender, EventArgs e)
        {
            Level = "Undergraduate";
        }

        private void Postgratuate_CheckedChanged(object sender, EventArgs e)
        {
            Level = "Postgraduate";
        }

        private void County_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
