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
using MIS566_group_project;
using System.Data.SqlClient;

namespace MIS566_group_project
{
    public partial class scheduleTakeOff : Form
    {
        public Form FormToShowOnClosing { get; set; }

        public scheduleTakeOff()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlDataReader readerCust = null;
        SqlDataReader readerTaskList = null;

        private void monthschedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lNBAirlinesDataSet.Full_Schedule_LNB_Airlines' table. You can move, or remove it, as needed.
            this.full_Schedule_LNB_AirlinesTableAdapter.Fill(this.lNBAirlinesDataSet.Full_Schedule_LNB_Airlines);
            //// TODO: This line of code loads data into the 'lNBAirlinesDataSet.LNBAirlines_Employees' table. You can move, or remove it, as needed.
            //this.lNBAirlines_EmployeesTableAdapter.Fill(this.lNBAirlinesDataSet.LNBAirlines_Employees);

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

            //string queryString = "SELECT Count(Sunday) FROM Full_Schedule_LNB_Airlines WHERE LocationID = 1 AND Sunday = '(Empty)'";
            //using (SqlConnection conn = new SqlConnection("Data Source=laptop-thfppv9b\\sqlexpress;Initial Catalog=LNBAirlines;Integrated Security=True"))
            //{
            //    SqlCommand command = new SqlCommand(
            //        queryString, conn);
            //    conn.Open();
            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            int fuck = reader.
            //            label2.Text = reader.GetString();
            //        }
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }
        public void Schuserin_KeyDown(object sender, KeyEventArgs e)
        {
            string input = Schuserin.Text.ToLower();  // this makes it easier to evaluate user input with it always being lower case.

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

                label1.Focus();  //Use a Label Here for a holding place
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

                    //SqlParameter paramtest = new SqlParameter();
                    //paramtest.

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
                    dataGridView1.DataSource = ds.Tables[0];
                    try
                    {
                        dataGridView1.Columns["LocationID"].Visible = false;
                        dataGridView1.Columns["LocationName"].Visible = false;
                        dataGridView1.Columns["Shift"].Width = 60;
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("No data for this customer.");
                    }
                }
                Schuserin.Clear();

                string Cinput = new CultureInfo("en-US").TextInfo.ToTitleCase(input);
                SchudChatbot.Text += "\n\nUser >   My location is " + Cinput;
                SchudChatbot.Text += "\n\nChatbot >   Please type in your name and then select your shift";
            }
            //else if
            //{
            //    MessageBox.Show("Please type one of the three locations"); // possible chatbot response
            //}


            if (Schuserin.Text.Contains("exit"))
            {
                this.Close();
                if (null != FormToShowOnClosing)
                    FormToShowOnClosing.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void Schuserin_TextChanged(object sender, EventArgs e)
        {

        }

        public void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //string selectedshift = dataGridView1;
            int rowselected = e.RowIndex; // think i can use these for updating the database
            int columnselected = e.ColumnIndex;

            string userShift = dataGridView1.Rows[rowselected].Cells[columnselected].Value.ToString();
            string columnName = dataGridView1.Columns[columnselected].HeaderText;


            if (SchudChatbot.Text.Contains("this shift off type 'Yes' and select") && Schuserin.Text.Contains("yes") && dataGridView1.CanSelect)
            {
                Schuserin.Clear();
                if (SchudChatbot.Text.Contains(columnName))
                {
                    conn = new SqlConnection("Data Source=laptop-thfppv9b\\sqlexpress;Initial Catalog=LNBAirlines;Integrated Security=True");
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Update Full_Schedule_LNB_Airlines " +
                        "set " + columnName + " = '(Empty)' " +
                        "where " + columnName + " = '" + userShift + "'", conn);
                    cmd.ExecuteNonQuery(); 

                    SchudChatbot.Text += "\n\nChatbot >   Schedule has been updated. Type exit to go back to the Dashboard.";
                    dataGridView1.ClearSelection();
                    // didn't work    dataGridView1.Update();
                    conn.Close();

                    // trying to update the data
                    //this.Load
                    //this.full_Schedule_LNB_AirlinesTableAdapter.Update(this.lNBAirlinesDataSet.Full_Schedule_LNB_Airlines);
                }
                
            }
            else if (userShift == Schuserin.Text || SchudChatbot.Text.Contains(userShift)) // the "Max Schnepf" will be current user of application but don't know how to do that yet.
            {
                SchudChatbot.Text += "\n\nChatbot >   " + Schuserin.Text + " you have selected your " + columnName + " shift if you want to confirm taking " +
                    "this shift off type 'Yes' and select your shift again.";
                Schuserin.Clear();
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please pick a shift that is assigned to you.");
            }


            // dataGridView1.DataSource might work for up dating data
        }
    }
}
