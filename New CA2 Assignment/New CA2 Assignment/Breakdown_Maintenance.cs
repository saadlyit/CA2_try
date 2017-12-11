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

namespace New_CA2_Assignment
{
    public partial class Breakdown_Maintenance : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=172.28.134.1;Initial Catalog=saadDB;Persist Security Info=True;User ID=m.abbas;Password=7ePbtsmMtN;Pooling=False");
        SqlCommand cmd = new SqlCommand();
        public Breakdown_Maintenance()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // this method is being tested in the below method
            string sno = textsno.Text;
            string date = textmaintain_date.Text;
            string serviceprovide = textservice_provide.Text;
            string equipdown = textequip_down.Text;
            string costofmaintain = textcostof_maintain.Text;
            string sixmonth = textmain_sixmonh.Text;

            bool flag = updatevalues(sno, date, serviceprovide, equipdown, costofmaintain, sixmonth);
        }

        public bool updatevalues(string sno, string date, string serviceprovide, string equipdown, string costofmaintain, string sixmonth)
        {
            bool flag = false;
            //to add connection to the database first open connection
            // then a query was used to tell the dataadapter what to do and with this connection
            //Executes a Transact-SQL statement against the connection and returns the number of rows affected.
            //In the query the statement is telling to update datatable[name] set [coloum name] = the string in textbox and so on...
            //after open a connection a connection must be close otherwise you ll get con.close() error message
            try
            {
                con.Open();
                string query = @"UPDATE bmaintenance SET [Maintenance Date] = '" + date + "', [Service Provider Stats] = '" + serviceprovide + "', [Equipment Down Time] = '" + equipdown + "', [Cost of maintenance] = '" + costofmaintain + "', [Maintenance last six month] = '" + sixmonth + "' WHERE Sno = '" + sno + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated into Breakdown maintenance Data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            catch { }
            return flag;
        }

        private void Btn_vieww_Click(object sender, EventArgs e)
        {
            string a=""; 
            bool flag = view(a);
        }
        //this method getting the value from unittest 

        public bool view(string a)
        {
            bool flag = false;
            try
            {
                
                if (a == "btnclick")
                {
                    //in the below query the command is telling to select everything(*) from smaintainance table
                    // then this query was used to tell the dataadapter what to do and with this connection
                    //Create a new object called dt
                    // da.fill(dt) In this command da is using fil method to fill the data table
                    //In the last command Datasource is used to import the data from database to data table
                    con.Open();
                    string query = "Select * from [bmaintenance]";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1_shutt.DataSource = dt;
                    con.Close();
                    flag = true;
                }
            }
            catch { }
            return flag;
        }

        private void Btn_deletee_Click(object sender, EventArgs e)
        {// this method is being tested in the below method
            string sno = textsno.Text;


            bool flag = deletevalues(sno);

        }
        public bool deletevalues(string sno)
        {
            bool flag = false;
            try
            {
                //To delete the data from database a query is used to tell the dataadapter to delete  from the [table name] where textbox containing sno
                //try and catch exception is used to stop thedisturbance in the program flow
                //query insert into [database name] whose  values are in the textboxes(texbox names) because a single click has been created already
                con.Open();
                string query = "Delete From [bmaintenance] Where [Sno]= '" + sno + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted from Breakdown maintenance Data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            catch
            { }
            return flag;
        }

        private void Btn_savee_Click(object sender, EventArgs e)
        {
            string sno = textsno.Text;
            string date = textmaintain_date.Text;
            string serviceprovide = textservice_provide.Text;
            string equipdown = textequip_down.Text;
            string costofmaintain = textcostof_maintain.Text;
            string sixmonth = textmain_sixmonh.Text;

            bool flag = savevalues(sno, date, serviceprovide, equipdown, costofmaintain, sixmonth);

        }
        //this method getting the value from unittest 

        public bool savevalues(string sno, string date, string serviceprovide, string equipdown, string costofmaintain, string sixmonth)
        {
            bool flag = false;
            //try and catch exception is used to stop thedisturbance in the program flow
            //query insert into [database name] whose  values are in the textboxes(texbox names)
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [bmaintenance] Values('" + sno + "','" + date + "','" + serviceprovide + "','" + equipdown + "','" + costofmaintain + "','" + sixmonth + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully saved into Breakdown maintenance Data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return flag;
            //      throw new NotImplementedException();
        }



        private void dataGridView1_shutt_MouseClick(object sender, MouseEventArgs e)
        {
            //to show data in the data on the datagrid view.
            //Query used to tell the the dataadapter to select *(all) from smaintenance
            //dataadapter will use the method fill to populate the datagrid view
            //datasource was used to fill the database
            // always use connection close command when theconnection was opened 
            //In the last convert it to .tostring because textbox cannot woerk with int values
            textsno.Text = dataGridView1_shutt.SelectedRows[0].Cells[0].Value.ToString();
            textmaintain_date.Text = dataGridView1_shutt.SelectedRows[0].Cells[1].Value.ToString();
            textservice_provide.Text = dataGridView1_shutt.SelectedRows[0].Cells[2].Value.ToString();
            textequip_down.Text = dataGridView1_shutt.SelectedRows[0].Cells[3].Value.ToString();
            textcostof_maintain.Text = dataGridView1_shutt.SelectedRows[0].Cells[4].Value.ToString();
            textmain_sixmonh.Text = dataGridView1_shutt.SelectedRows[0].Cells[5].Value.ToString();
        }


        private void Btn_ddash_Click(object sender, EventArgs e)
        {
            // go to dashboard
            Dashboard dd = new Dashboard();
            dd.Show();
            this.Hide();
        }

        private void btn_Loagout_Click(object sender, EventArgs e)
        {

            //goto login page
            this.Hide();
            MainWindow login = new MainWindow();
            login.Show();
        }

        private void Btn_details_Click(object sender, EventArgs e)
        {
            ////to show data in the data ion the datagrid view.
            //Query used to tell the the dataadapter to select *(all) from smaintenance
            //dataadapter will use the method fill to populate the datagrid view
            //datasource was used to fill the database
            // always use connection close command when theconnection was opened 
            //In the last convert it to .tostring because textbox cannot woerk with int values
            con.Open();
            string query = "Select * from [bmaintenance]";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
