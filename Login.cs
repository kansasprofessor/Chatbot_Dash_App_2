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

namespace MIS566_group_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            // Create a variable for authentication
            Boolean UserValid;

            // Added New Connection String for SQLServer Express (Note: Provider clause removed)
            string connString = "Data Source=laptop-thfppv9b\\sqlexpress;Initial Catalog=LNBAirlines;Integrated Security=True";

            // Added Try Catch to Check for Issues
            try
            {
                // Use SQL DB to connect with SQLServer Express DB
                // sql connection object (MODIFIED FOR SQLSERVER)
                using (SqlConnection myConnection = new SqlConnection(connString))
                {
                    //Build a select statement to check for user/password combo
                    //string query = "SELECT * from Security WHERE UserID = " + txtUserID.Text + " AND Password = " + txtPassword.Text + "";
                    string query = "SELECT * from LNBAirlines_Login WHERE UserID = '" + tbuserID.Text + "' AND Password = '" + tbpassword.Text + "'";
                    //define the SqlCommand object 
                    SqlCommand cmd = new SqlCommand(query, myConnection);
                    //open connection
                    myConnection.Open();
                    //execute the SQLCommand
                    SqlDataReader readerReturnValue = cmd.ExecuteReader();

                    // If the User/Password combo was found, then set the return value to 'true'
                    if (readerReturnValue.HasRows == true)
                    {
                        UserValid = true;
                        MessageBox.Show("You have been validated! ");

                        var dashBoard = new DashBoard();
                        dashBoard.FormToShowOnClosing = this;
                        dashBoard.Show();
                        this.Hide();
                    }

                    else
                    {
                        // Else indicate user not found
                        UserValid = false;
                        MessageBox.Show("Please try again. You UserID or Password was not found.");
                        tbpassword.Text = "";
                        tbuserID.Text = "";
                    }
                    // close connection to prevent zombie DB connection
                    myConnection.Close();
                }

            }
            // Display Error Message for Exceptions
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }
    }
}
