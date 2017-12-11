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
//always use above command before introducing sql connection
namespace New_CA2_Assignment
{
    public partial class Most_services_company : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=172.28.134.1;Initial Catalog=saadDB;Persist Security Info=True;User ID=m.abbas;Password=7ePbtsmMtN;Pooling=False");
        SqlCommand cmd = new SqlCommand();
        public Most_services_company()
        {
            InitializeComponent();
        }

        private void btnn_update_Click(object sender, EventArgs e)
        {
            // This method is being tested in the below method
            string sno = textBox1.Text;
            string Nameofcompany = textBox2.Text;
            string numofservperformed = textBox3.Text;
            string TeleNum = textBox4.Text;
            string cont_num = textBox5.Text;

            bool flag = updatevalues(sno, Nameofcompany, numofservperformed, TeleNum, cont_num);

        }
        //this method getting the value from unittest 
        public bool updatevalues(string sno, string Nameofcompany, string numofservperformed, string TeleNum, string cont_num)
        {
            bool flag = false;
            try
            {
                //to add connection to the database first open connection
                // then a query was used to tell the dataadapter what to do and with this connection
                //Executes a Transact-SQL statement against the connection and returns the number of rows affected.
                //In the query the statement is telling to update datatable[name] set [coloum name] = the string in textbox and so on...
                //after open a connection a connection must be close otherwise you ll get con.close() error message
                con.Open();
                string query = @"UPDATE Services_by_a_Company SET [Name of the Company] = '" + Nameofcompany + "', [Number of services Performed] = '" + numofservperformed + "', [Telephone Number] = '" + TeleNum + "', [Contact Number] = '" + cont_num + "' WHERE Sno = '" + sno + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            catch { }
            return flag;
        }
        private void Btnn_savee_Click(object sender, EventArgs e)
        {
            // This method is being tested in the below method
            string sno = textBox1.Text;
            string Nameofcompany = textBox2.Text;
            string numofservperformed = textBox3.Text;
            string TeleNum = textBox4.Text;
            string cont_num = textBox5.Text;

            bool flag = savevalues(sno, Nameofcompany, numofservperformed, TeleNum, cont_num);

        }
        public bool savevalues(string sno, string Nameofcompany, string numofservperformed, string TeleNum, string cont_num)
        {
            bool flag = false;
            //try and catch exception is used to stop thedisturbance in the program flow
            //query insert into [database name] whose  values are in the textboxes(texbox names)
            //in the message box showing the confirmation
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Services_by_a_Company] Values('" + sno + "','" + Nameofcompany + "','" + numofservperformed + "','" + TeleNum + "','" + cont_num + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return flag;
        }
        private void Btnn_vieww_Click(object sender, EventArgs e)
        {
            string a = "btnclick"; // this is to make the statement true.
            bool flag = view(a);//Insert the value btnclick in the same method if the btn is clicked 
        }
        public bool view(string a)
        {
            bool flag = false;
            try
            {
                if (a == "btnclick") {
                    //to show data in the data on the datagrid view.
                    //Query used to tell the the dataadapter to select *(all) from smaintenance
                    //dataadapter will use the method fill to populate the datagrid view
                    //datasource was used to fill the database
                    // always use connection close command when theconnection was opened 
                    //In the last convert it to .tostring because textbox cannot woerk with int values
                    con.Open();
                    string query = "Select * from [Services_by_a_Company]";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViiew22.DataSource = dt;
                    con.Close();
                    flag = true;
                }
            }
            catch { }
            return flag;
        }

        private void Btnn_deletee_Click(object sender, EventArgs e)
        {
            // This method is being tested in the below method
            string sno = textBox1.Text;

            bool flag = deletevalues(sno);

        }
        public bool deletevalues(string sno)        //this method getting the value from unittest 

        {
            bool Flag = false;
            try
            {
                //To delete the data from database a query is used to tell the dataadapter to delete  from the [table name] where textbox containing sno
                //try and catch exception is used to stop thedisturbance in the program flow
                //query insert into [database name] whose  values are in the textboxes(texbox names)

                con.Open();
                string query = "Delete From [Services_by_a_Company] Where [Sno]= '" + sno + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully deleted..", "info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Flag = true;
            }
            catch { }
            return Flag;
        }
        private void dataGridViiew_1_MouseClick(object sender, MouseEventArgs e)
        {
            //Created a single click element on a full row
            //when a row is selected then get the data from data grid where selectedrows represents coloumbs andcells represent rows, where value is used to  capture data
            textBox1.Text = dataGridViiew22.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridViiew22.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridViiew22.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridViiew22.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridViiew22.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void dataGridViiew_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void btn_dashb_Click(object sender, EventArgs e)
        {///
           //goto dashboard
            Dashboard dd = new Dashboard();
            dd.Show();
            this.Hide();
        }

        private void btnn_log_Click(object sender, EventArgs e)
        {
            //goto login page
            this.Hide();
            MainWindow login = new MainWindow();
            login.Show();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            //in the below query the command is telling to select everything(*) from smaintainance table
            // then this query was used to tell the dataadapter what to do and with this connection
            //Create a new object called dt
            // da.fill(dt) In this command da is using fil method to fill the data table
            //In the last command Datasource is used to import the data from database to data table

            con.Open();
            string query = "Select * from [Services_by_a_Company]";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView11.DataSource = dt;
            con.Close();
        }
    }
}
