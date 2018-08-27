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
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (username.Text == " " || password.Text == " ")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                Connection conn = new Connection();
                SqlCommand cmd = new SqlCommand("Select * from dbo.Login where UserName=@username and Password=@password", conn.openConnection());

                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conn.closeConnection();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    //Form1 fm = new Form1();
                    GridForm fm = new GridForm();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
