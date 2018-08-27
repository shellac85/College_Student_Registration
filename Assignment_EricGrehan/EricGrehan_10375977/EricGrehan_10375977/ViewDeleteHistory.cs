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
    public partial class ViewDeleteHistory : Form
    {
        Connection conn = new Connection();
        //private DataGridView dataGridView1 = new DataGridView();
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        //DataTable dt;
        DataSet ds;

        public ViewDeleteHistory()
        {
            InitializeComponent();
        }

        private void ViewDeleteHistory_Load(object sender, EventArgs e)
        {

            var select = "SELECT * FROM AuditStudentTableDeleted";


            sda = new SqlDataAdapter(select, conn.openConnection());
            scb = new SqlCommandBuilder(sda);
            ds = new DataSet();
            sda.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GridForm FORM1 = new GridForm();
            FORM1.Show();
            this.Close();
        }
    }
}
