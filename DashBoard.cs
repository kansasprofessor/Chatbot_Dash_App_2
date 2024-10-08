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
using System.Windows.Forms.DataVisualization.Charting;

namespace MIS566_group_project
{
    public partial class DashBoard : Form
    {
        public Form FormToShowOnClosing { get; set; }

        public DashBoard()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlDataReader readerCust = null;
        SqlDataReader readerTaskList = null;
        

        private void DashBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lNBAirlinesDataSet.Full_Schedule_LNB_Airlines' table. You can move, or remove it, as needed.
            this.full_Schedule_LNB_AirlinesTableAdapter.Fill(this.lNBAirlinesDataSet.Full_Schedule_LNB_Airlines);

            // 1. Start out by connecting to the data source: You will need 
            //    your connection string here
            // 2. multiple active data sets is on for connection string
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
            dsCustListIDs.Load(readerCust, LoadOption.PreserveChanges,
            dsCustListIDs.Tables[0]);
            // 8. Put the retrieved values into the ComboBox
            comboBox1.ValueMember = "LocationID";
            comboBox1.DisplayMember = "LocationName";
            comboBox1.DataSource = dsCustListIDs.Tables[0];
            comboBox1.SelectedIndex = 1;
            comboBox1.SelectedValue = 1;
            readerCust.Close();

            fillchart();

            // chart1.DataSource = dataGridView1.DataSource;

            ///*chart1.Series[*/0] = new Series();
            //chart1.Series[0].XValueMember = dataGridView1.Columns[0].DataPropertyName;
            //chart1.Series[0].YValueMembers = dataGridView1.Columns[1].DataPropertyName;
            //chart1.DataSource = dataGridView1.DataSource;
            //chart1.DataBind();

        }

        private void fillchart()
        {
            conn = new SqlConnection("Data Source=laptop-thfppv9b\\sqlexpress;Initial Catalog=LNBAirlines;Integrated Security=True");
            DataSet ds = new DataSet();
            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT COUNT(*) AS numEmployees, LocationName FROM Full_Schedule_LNB_Airlines WHERE (LocationID = 1 OR LocationID = 2 OR LocationID = 3) " +
                "AND (Sunday = '(Empty)' OR Monday = '(Empty)' OR Tuesday = '(Empty)' OR Wednesday ='(Empty)' OR Thrusday = '(Empty)' OR Friday = '(Empty)' OR Saturday = '(Empty)') GROUP BY LocationName", conn);

            adapt.Fill(ds);
            chart2.DataSource = ds;

            chart2.Series["LocationName"].XValueMember = "LocationName";
            chart2.Series["LocationName"].YValueMembers = "numEmployees";
            chart2.Titles.Add("Empty Shifts per Location");
            //conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (null != FormToShowOnClosing)
                FormToShowOnClosing.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var CB = new Chatbot();
            CB.FormToShowOnClosing = this;
            CB.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Focus();  //Use a Label Here for a holding place
            if (comboBox1.SelectedValue == null)
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
                param.Value = comboBox1.SelectedValue.ToString();
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
                dgvSchedule.DataSource = ds.Tables[0];
                try
                {
                    dgvSchedule.Columns["LocationID"].Visible = false;
                    dgvSchedule.Columns["LocationName"].Visible = false;
                    dgvSchedule.Columns["Shift"].Width = 60;

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("No data for this customer.");
                }
            }
        }

        SqlDataReader suckit = null;
        //SqlDataReader suckitmore = null;

        private void button3_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //SqlCommand sqlCommand = new SqlCommand("SELECT Count(Sunday), Count(Monday), Count(Tuesday) FROM Full_Schedule_LNB_Airlines " +
            //    "WHERE LocationID = 1 Having Count(Sunday) = '(Empty)' AND Monday = '(Empty)' AND Tuesday = '(Empty)'", conn);

            SqlCommand sqlCommand = new SqlCommand(
                //"SELECT Count(Sunday ) FROM Full_Schedule_LNB_Airlines " +
                //"WHERE LocationID = 1 AND Sunday = '(Empty)';", conn); ;

                "SELECT COUNT(*), LocationName FROM Full_Schedule_LNB_Airlines WHERE (LocationID = 1 OR LocationID = 2 OR LocationID = 3) " +
                "AND (Sunday = '(Empty)' OR Monday = '(Empty)' OR Tuesday = '(Empty)' OR Wednesday ='(Empty)' OR Thrusday = '(Empty)' OR Friday = '(Empty)' OR Saturday = '(Empty)') GROUP BY LocationName", conn);
            //OR Monday = '(Empty)' OR Tuesday = '(Empty)'
            //WHERE(LocationID = 1 AND Sunday = '(Empty)') OR(LocationID = 1 AND Monday = '(Empty)')", conn);

            //SqlCommand sqlCommand = new SqlCommand("SELECT Count(Monday) FROM Full_Schedule_LNB_Airlines " +
            //    "WHERE LocationID = 1 AND Monday = '(Empty)'", conn);

            suckit = sqlCommand.ExecuteReader();
            //suckitmore = sqlCommand2.ExecuteReader();


            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable("Table1");
            //dataTable.Load(suckit);
            //dataTable
            dataSet.Tables.Add(dataTable);
            dataSet.Load(suckit, LoadOption.PreserveChanges, dataSet.Tables[0]);
            //dataSet.Load(suckitmore, LoadOption.PreserveChanges, dataSet.Tables[0]);
            suckit.Close();

            //dataGridView1.DataSource = dataSet.Tables[0];
            ////dataGridView1.DataSource = dataTable.Columns[0].ToString();
            //string asdf = dataTable.Columns[0].ToString();

            //label3.Text = asdf;
            
            
        }
    }
}
