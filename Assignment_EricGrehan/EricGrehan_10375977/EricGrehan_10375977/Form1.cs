using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace EricGrehan_10375977
{
    public partial class Form1 : Form
    {
        
        //static string ConnectionString = "" + "Data Source=(localdb)\\MSSQLLocalDB;" +
        //    "Integrated Security=True;" +
        //    "Initial Catalog=AdvancedProgrammingStudentDB";
        //    SqlConnection conn = new SqlConnection(ConnectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //using (conn)
            //{
            //    conn.Open();
            //    if (conn.State == ConnectionState.Open)
            //    {
            //        Progress.Text = "Connection Opened";
            //    }
            //}
        }

        private void AddNewStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm formm = new AddStudentForm();
            formm.Show();
        }

        private void EditStudent_Click(object sender, EventArgs e)
        {
           GridForm form1 = new GridForm();
            form1.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            LoginPage form1 = new LoginPage();
            form1.Show();
            this.Hide();
        }

        private void butXML_Click(object sender, EventArgs e)
        {

        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {

        }

        private void ViewDatabaseHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
