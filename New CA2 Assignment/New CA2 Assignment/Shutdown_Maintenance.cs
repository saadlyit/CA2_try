using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //First type this namespace to add sql connection

namespace New_CA2_Assignment
{
    public partial class Shutdown_Maintenance : Form
    {
        //intialize sql connextion
        //intiialize sql command
        SqlConnection con = new SqlConnection(@"Data Source=172.28.134.1;Initial Catalog=saadDB;Persist Security Info=True;User ID=m.abbas;Password=7ePbtsmMtN;Pooling=False");
        SqlCommand cmd = new SqlCommand();
        public Shutdown_Maintenance()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string sno = textsno.Text;
            string maintaindate = textmaintaindate.Text;
            string servicestat = textservicestat.Text;
            string euipdowntime = textequipdown.Text;
            string costmain = textcostmaintain.Text;
            string mainlastsixmonth = textlastsixmonth.Text;

            bool flag = updatevalues(sno, maintaindate, servicestat, euipdowntime, costmain, mainlastsixmonth);

        }
        public bool updatevalues(string sno, string maintaindate, string servicestat, string euipdowntime, string costmain, string mainlastsixmonth)
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
                string query = @"UPDATE smaintenance SET [Maintenance Date] = '" + maintaindate + "', [Service Provider Stats] = '" + servicestat + "', [Equipment Down Time] = '" + euipdowntime + "', [Cost of maintenance] = '" + costmain + "', [Maintenance last six month] = '" + mainlastsixmonth + "' WHERE Sno = '" + sno + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            catch { }
            return flag;
        }
        private void Btn_view_Click(object sender, EventArgs e)
        {
            string a = "btnclick";
            bool flag = view(a);
        }
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
                    string query = "Select * from [smaintenance]";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1_shut.DataSource = dt;
                    con.Close();
                    flag = true;
                }
            }
            catch { }
            return flag;

        }
        private void Btn_delete_Click(object sender, EventArgs e)
        {
            string sno = textsno.Text;
            bool flag = deletevalues(sno);

        }
        public bool deletevalues(string sno)
        {
            bool flag = false;
            try
            {
                //To delete the data from database a query is used to tell the dataadapter to delete  from the [table name] where textbox containing sno
                con.Open();
                string query = "Delete From [smaintenance] Where [Sno]= '" + sno + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            catch { }
            return flag;
        }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            string sno = textsno.Text;
            string maintaindate = textmaintaindate.Text;
            string servicestat = textservicestat.Text;
            string euipdowntime = textequipdown.Text;
            string costmain = textcostmaintain.Text;
            string mainlastsixmonth = textlastsixmonth.Text;

            bool flag = savevalues(sno, maintaindate, servicestat, euipdowntime, costmain, mainlastsixmonth);

        }
        public bool savevalues(string sno, string maintaindate, string servicestat, string euipdowntime, string costmain, string mainlastsixmonth)
        {
            bool flag = false;
            //try and catch exception is used to stop thedisturbance in the program flow
            //query insert into [database name] whose  values are in the textboxes(texbox names)
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [smaintenance] Values('" + sno + "','" + maintaindate + "','" + servicestat + "','" + euipdowntime + "','" + costmain + "','" + mainlastsixmonth + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return flag;
        }
        private void dataGridView1_shut_MouseClick(object sender, MouseEventArgs e)
        {
            //Created a single click element on a full row
            //when a row is selected then get the data from data grid where selectedrows represents coloumbs andcells represent rows, where value is used to  capture data
            //In the last convert it to .tostring because textbox cannot woerk with int values
            textsno.Text = dataGridView1_shut.SelectedRows[0].Cells[0].Value.ToString();
            textmaintaindate.Text = dataGridView1_shut.SelectedRows[0].Cells[1].Value.ToString();
            textservicestat.Text = dataGridView1_shut.SelectedRows[0].Cells[2].Value.ToString();
            textequipdown.Text = dataGridView1_shut.SelectedRows[0].Cells[3].Value.ToString();
            textcostmaintain.Text = dataGridView1_shut.SelectedRows[0].Cells[4].Value.ToString();
            textlastsixmonth.Text = dataGridView1_shut.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //to show data in the data on the datagrid view.
            //Query used to tell the the dataadapter to select *(all) from smaintenance
            //dataadapter will use the method fill to populate the datagrid view
            //datasource was used to fill the database
            // always use connection close command when theconnection was opened 
            con.Open();
            string query = "Select * from [smaintenance]";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Btn_dash_Click(object sender, EventArgs e)
        {
            //when this btn is cliked go to dashboard
            Dashboard dd = new Dashboard();
            dd.Show();
            this.Hide();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            //when this btn is cliked go to logout
            //goto login page
            //goto login page
            this.Hide();
            MainWindow login = new MainWindow();
            login.Show();

        }
    }
}
