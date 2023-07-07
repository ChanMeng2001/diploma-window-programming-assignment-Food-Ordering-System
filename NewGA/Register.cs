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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        //connect to database
        SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-3L2M79QJ;Initial Catalog=groupAssignment;Integrated Security=True");

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if user press cancel, go back to previous page which is login page
            frmLogin log = new frmLogin();
            this.Hide();
            log.Show();
        }

        private void btnRegister1_Click(object sender, EventArgs e)
        {
            
            bool existence = false;
            //if user do not fill in username or password, show this message.
            if (txtUsername1.Text == "" || txtPassword1.Text == "")
            {
                MessageBox.Show("Please fill in the username and password.");
            }
            else
            {
                /*validation - to avoid user from using the username that has already exists and not allow the
                               program to continue.
                */
                sqlCon.Open();
                SqlCommand cmdselect = new SqlCommand("Select Username from tblNewLogin1", sqlCon);

                SqlDataReader read = cmdselect.ExecuteReader();
                while (read.Read())
                {
                    if (txtUsername1.Text == read["Username"].ToString())
                    {
                        MessageBox.Show("Username Exists! Please choose another.");
                        existence = true;
                    }
                }

                sqlCon.Close();

                //if username does not exists, show this message and register successful.
                sqlCon.Open();
                if (existence == false)
                {
                    SqlCommand cmdinsert = new SqlCommand("Insert into tblNewLogin1 values('" + txtUsername1.Text + "','" + txtPassword1.Text + "')", sqlCon);
                    cmdinsert.CommandType = CommandType.Text;
                    cmdinsert.ExecuteNonQuery();
                    MessageBox.Show("Register successfully!");
                }
                sqlCon.Close();
            }

        }

        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {
            //make the key press of password become * 
            txtPassword1.PasswordChar = '*';
        }
    }
}
