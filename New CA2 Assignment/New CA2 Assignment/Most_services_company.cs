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
            //to add connection to the database first open connection
            // then a query was used to tell the dataadapter what to do and with this connection
            //Executes a Transact-SQL statement against the connection and returns the number of rows affected.
            //In the query the statement is telling to update datatable[name] set [coloum name] = the string in textbox and so on...
            //after open a connection a connection must be close otherwise you ll get con.close() error message

            con.Open();
            string query= @"UPDATE Services_by_a_Company SET [Name of the Company] = '" + textBox2.Text + "', [Number of services Performed] = '" + textBox3.Text + "', [Telephone Number] = '" + textBox4.Text + "', [Contact Number] = '" + textBox5.Text + "' WHERE Sno = '" + textBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Btnn_savee_Click(object sender, EventArgs e)
        {
            //try and catch exception is used to stop thedisturbance in the program flow
            //query insert into [database name] whose  values are in the textboxes(texbox names)
            //in the message box showing the confirmation
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Services_by_a_Company] Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text +  "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btnn_vieww_Click(object sender, EventArgs e)
        {
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
        }

        private void Btnn_deletee_Click(object sender, EventArgs e)
        {
            //To delete the data from database a query is used to tell the dataadapter to delete  from the [table name] where textbox containing sno
         //try and catch exception is used to stop thedisturbance in the program flow
         //query insert into [database name] whose  values are in the textboxes(texbox names)

            con.Open();
            string query = "Delete From [Services_by_a_Company] Where [Sno]= '" + textBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
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
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
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
