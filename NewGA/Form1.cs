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

namespace NewGA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //connect to database
        SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-3L2M79QJ;Initial Catalog=groupAssignment;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check whether the user input username data and password data are correct or not with the database data
            string query = "Select * from tblNewLogin1 where Username = '" + txtUsername.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            //if username and password is correct, go to next page which is main page
            if (dtbl.Rows.Count == 1)
            {
                frmMain objMain = new frmMain();
                this.Hide();
                objMain.Show();
            }
            else
            {
                //if wrong, show this message.
                MessageBox.Show("Your password or username is not correct. Please try again!");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //after press register, show register page
            frmRegister objRegister = new frmRegister();
            this.Hide();
            objRegister.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //make the key press of password become * 
            txtPassword.PasswordChar = '*';
        }
    }
}
