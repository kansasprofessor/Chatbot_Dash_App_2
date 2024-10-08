using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MIS566_group_project
{
    public partial class schedulePickUp : Form
    {
        public Form FormToShowOnClosing { get; set; }

        public schedulePickUp()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlDataReader readerCust = null;
        SqlDataReader readerTaskList = null;

        private void schedulePickUp_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lNBAirlinesDataSet.Full_Schedule_LNB_Airlines' table. You can move, or remove it, as needed.
            this.full_Schedule_LNB_AirlinesTableAdapter.Fill(this.lNBAirlinesDataSet.Full_Schedule_LNB_Airlines);

            conn = new SqlConnection("Data Source=laptop-thfppv9b\\sqlexpress;Initial Catalog=LNBAirlines;Integrated Security=True");
            conn.Open();

            // 3. declare a SQL Command. Select the Customers and 
            //    their names from the Customer Table
            //    for use in the ComboBox. 
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT LocationID, LocationName FROM Full_Schedule_LNB_Airlines", conn);
            // 4. Get a data stream set up
            readerCust = cmd.ExecuteReader();

            // 5.Create a Data Set called CustListIDs
            DataSet dsCustListIDs = new DataSet();
            // 6. Create Data Table to hold query results in the Data Set
            DataTable dtCustID = new DataTable("Table1");
            dsCustListIDs.Tables.Add(dtCustID);

            // 7. Load up the Query result (e.g. perform query)
            dsCustListIDs.Load(readerCust, LoadOption.PreserveChanges, dsCustListIDs.Tables[0]);
        }

        private void PUSchuserin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string input = richTextBox1.Text.ToLower();  // this makes it easier to evaluate user input with it always being lower case.

            if (e.KeyCode == Keys.Escape)
            {
                dataGridView2.ClearSelection();
            }

            if (input.Contains("manhattan") || input.Contains("kansas city") || input.Contains("wichita") && e.KeyCode == Keys.Enter)
            {
                int Ninput = 1;
                switch (input)
                {
                    case "manhattan":
                        Ninput = 1;
                        break;
                    case "kansas city":
                        Ninput = 2;
                        break;
                    case "wichita":
                        Ninput = 3;
                        break;
                }

                label2.Focus();  //Use a Label Here for a holding place
                if (input == null)
                {

                }
                else
                {
                    // 10. declare command object with Customer ID for DataGridView
                    SqlCommand cmd = new SqlCommand("SELECT * " +
                    "FROM Full_Schedule_LNB_Airlines "
                        + "WHERE LocationID = @LocationID_par", conn);

                    //// 11. define parameters used in command object for History
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@LocationID_par";

                    //// 12. Get value from ComboBox to populate SQL parameter History    //     dataset selection
                    param.Value = Ninput.ToString();

                    //// 13. add new parameters to command objects
                    cmd.Parameters.Add(param);

                    // 14. Execute the command for history query
                    readerTaskList = cmd.ExecuteReader();

                    // 15. Get the new data set and load it as a table for History
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable("Table1");
                    ds.Tables.Add(dt);
                    ds.Load(readerTaskList, LoadOption.PreserveChanges, ds.Tables[0]);
                    readerTaskList.Close();


                    // 16. Stick the new table into the DataGridView for History
                    dataGridView2.DataSource = ds.Tables[0];
                    try
                    {
                        dataGridView2.Columns["LocationID"].Visible = false;
                        dataGridView2.Columns["LocationName"].Visible = false;
                        dataGridView2.Columns["Shift"].Width = 60;
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("No data for this customer.");
                    }
                }
                richTextBox1.Clear();
                string Cinput = new CultureInfo("en-US").TextInfo.ToTitleCase(input);
                PUSchudChatbot.Text += "\n\nUser >   My location is " + Cinput;
                PUSchudChatbot.Text += "\n\nChatbot >   Please select an empty shift you would like to pick up";
            }
            //else if
            //{
            //    MessageBox.Show("Please type one of the three locations"); // possible chatbot response
            //}


            if (richTextBox1.Text.Contains("exit"))
            {
                this.Close();
                if (null != FormToShowOnClosing)
                    FormToShowOnClosing.Show();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void full_Schedule_LNB_AirlinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //string selectedshift = dataGridView2;
            int rowselected = e.RowIndex; // think i can use these for updating the database
            int columnselected = e.ColumnIndex;

            string userShift = dataGridView2.Rows[rowselected].Cells[columnselected].Value.ToString();
            string columnName = dataGridView2.Columns[columnselected].HeaderText;


            if (PUSchudChatbot.Text.Contains("this shift type your name and select the shift again.") && userShift == "(Empty)"/*richTextBox1.Text.Contains("yes")*/ && dataGridView2.CanSelect)
            {
                if (PUSchudChatbot.Text.Contains(columnName))
                {
                    conn = new SqlConnection("Data Source=laptop-thfppv9b\\sqlexpress;Initial Catalog=LNBAirlines;Integrated Security=True");
                    conn.Open();

         
                    int input = 0;
                    
                    if (PUSchudChatbot.Text.Contains("My location is Manhattan"))
                    {
                        input = 1;
                    }
                    else if (PUSchudChatbot.Text.Contains("My location is Kansas City"))
                    {
                        input = 2;
                    }
                    else if (PUSchudChatbot.Text.Contains("My location is Wichita"))
                    {
                        input = 3;
                    }

                    SqlCommand cmd = new SqlCommand("Update Full_Schedule_LNB_Airlines " +
                        "set " + columnName + " = '" + richTextBox1.Text + "' " +
                        "where " + columnName + " = '(Empty)' " +
                        "and LocationID = " + input + "", conn);
                    cmd.ExecuteNonQuery();
                    
                    PUSchudChatbot.Text += "\n\nChatbot >   Schedule has been updated. Type exit to go back to the Dashboard.";
                    dataGridView2.ClearSelection();
                    richTextBox1.Clear();
                    // didn't work    dataGridView2.Update();
                    conn.Close();

                    // trying to update the data
                    //this.Load
                    //this.full_Schedule_LNB_AirlinesTableAdapter.Update(this.lNBAirlinesDataSet.Full_Schedule_LNB_Airlines);
                }

            }
            else if (userShift == "(Empty)" && richTextBox1.Text.Contains("")/*|| PUSchudChatbot.Text.Contains(userShift)*/) // the "Max Schnepf" will be current user of application but don't know how to do that yet.
            {
                PUSchudChatbot.Text += "\n\nChatbot >   You have selected an empty shift on " + columnName + " if you want to confirm " +
                    "this shift type your name and select the shift again.";
                richTextBox1.Clear();
                dataGridView2.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please pick a shift that is assigned to you.");
            }


            // dataGridView2.DataSource might work for up dating data
        }

        

        private void schedulePickUp_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'lNBAirlinesDataSet.Full_Schedule_LNB_Airlines' table. You can move, or remove it, as needed.
            //this.full_Schedule_LNB_AirlinesTableAdapter.Fill(this.lNBAirlinesDataSet.Full_Schedule_LNB_Airlines);
            ////// TODO: This line of code loads data into the 'lNBAirlinesDataSet.LNBAirlines_Employees' table. You can move, or remove it, as needed.
            ////this.lNBAirlines_EmployeesTableAdapter.Fill(this.lNBAirlinesDataSet.LNBAirlines_Employees);

            //conn = new SqlConnection("Data Source=laptop-thfppv9b\\sqlexpress;Initial Catalog=LNBAirlines;Integrated Security=True");
            //conn.Open();

            //// 3. declare a SQL Command. Select the Customers and 
            ////    their names from the Customer Table
            ////    for use in the ComboBox. 
            //SqlCommand cmd = new SqlCommand("SELECT DISTINCT LocationID, LocationName FROM Full_Schedule_LNB_Airlines", conn);
            //// 4. Get a data stream set up
            //readerCust = cmd.ExecuteReader();

            //// 5.Create a Data Set called CustListIDs
            //DataSet dsCustListIDs = new DataSet();
            //// 6. Create Data Table to hold query results in the Data Set
            //DataTable dtCustID = new DataTable("Table1");
            //dsCustListIDs.Tables.Add(dtCustID);

            //// 7. Load up the Query result (e.g. perform query)
            //dsCustListIDs.Load(readerCust, LoadOption.PreserveChanges, dsCustListIDs.Tables[0]);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
