using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageApp
{
    public partial class Login : Form
    {

        SqlConnection con = new SqlConnection("Connection String");  
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userid = txtUserName.Text;
            string password = txtPassword.Text;
            string LocalPath = txtDirPath.Text;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from [User]  where UserName='" + txtUserName.Text + "'and Password='" + txtPassword.Text + "'", con);
            // SqlCommand cmd = new SqlCommand("select * from TBL_Login where UserName='" + txtUserName.Text + "'and Password='" + txtPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string SUserid = dt.Rows[0]["UserId"].ToString();
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MyTestKey");
                key.SetValue("UserName", userid);
                key.SetValue("Password", password);
                key.SetValue("UserId", SUserid);
                key.SetValue("Path", LocalPath);
                key.Close();
              
                Dashboard Dashboard = new Dashboard();
                Dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtPassword.Text = "";
                txtUserName.Text = "";
                txtUserName.Focus();
            }
            cmd.Dispose();
            con.Close();
        }
    }
}
