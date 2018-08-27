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
using System.Xml;
using EricGrehan_10375977.DataAccess;

namespace EricGrehan_10375977
{
    public partial class GridForm : Form
    {
        Connection conn = new Connection();
        //var commandBuilder;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        //DataTable dt;
        DataSet ds;

        public GridForm()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(ds); 
            MessageBox.Show("Record Updated");
        }

        private void GridForm_Load(object sender, EventArgs e)
        {
            var select = "SELECT * FROM Student";
            sda = new SqlDataAdapter(select, conn.openConnection());
            scb = new SqlCommandBuilder(sda);
            ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            LoginPage form1 = new LoginPage();
            form1.Show();
            this.Hide();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm form1 = new AddStudentForm();
            form1.Show();
            this.Hide();
        }

        private void butDeleteStudent_Click(object sender, EventArgs e)
        {
            EditStudentForm editform = new EditStudentForm();
            editform.Show();
        }

        private void butViewHistory_Click(object sender, EventArgs e)
        {
            DBHistoryForm FORM1 = new DBHistoryForm();
            FORM1.Show();
            this.Hide();
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ds.WriteXml("StudentOutput", System.Data.XmlWriteMode.IgnoreSchema);
                MessageBox.Show("Student Recored saved to XML FILE");
            }
            else
            {
                MessageBox.Show("Select a Student Recored First Before Exporting To XML");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EditStudentForm f1 = new EditStudentForm();
            f1.Show();
            this.Hide();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            EditStudentForm f1 = new EditStudentForm();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewDeleteHistory f1 = new ViewDeleteHistory();
            f1.Show();
            this.Hide();
        }
    }
}
