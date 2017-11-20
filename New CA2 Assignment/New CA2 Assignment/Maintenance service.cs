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
    public partial class Qualified_employees : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=172.28.134.1;Initial Catalog=saadDB;Persist Security Info=True;User ID=m.abbas;Password=7ePbtsmMtN;Pooling=False");
        SqlCommand cmd = new SqlCommand();
        public Qualified_employees()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //Created a single click element on a full row
            //when a row is selected then get the data from data grid where selectedrows represents coloumbs andcells represent rows, where value is used to  capture data
            textid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textsocial_security_num.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            text_department.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textcost.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textcontact.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //to add connection to the database first open connection
            // then a query was used to tell the dataadapter what to do and with this connection.
            //In the query the statement is telling to update datatable[name] set [coloum name] = the string in textbox and so on...
            //after open a connection a connection must be close otherwise you ll get con.close() error message
            //cmd.ExecuteNonQuery(); Executes a Transact-SQL statement against the connection and returns the number of rows affected.
            con.Open();
            string query = @"UPDATE Qualified_employees SET [Social Security Number] = '" + textsocial_security_num.Text + "', [Name] = '" + textName.Text + "', [Department] = '" + textcost.Text + "', [Cost] = '" + textcost.Text + "', [Contact Numbet] = '" + textcontact.Text + "' WHERE Id = '" + textid.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated","Info",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            //try and catch exception is used to stop the disturbance in the program flow
            //query insert into [database name] whose  values are in the textboxes(texbox names)
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Qualified_employees] Values('" + textid.Text + "','" + textsocial_security_num.Text + "','" + textName.Text + "','" + text_department.Text + "','" + textcost.Text + "','" +textcontact.Text+ "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_view_Click(object sender, EventArgs e)
        {
            //to show data in the data on the datagrid view.
            //Query used to tell the the dataadapter to select *(all) from smaintenance
            //dataadapter will use the method fill to populate the datagrid view
            //datasource was used to fill the database
            // always use connection close command when theconnection was opened 
            //In the last convert it to .tostring because textbox cannot woerk with int values
            con.Open();
            string query = "Select * from [Qualified_employees]";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            //To delete the data from database a query is used to tell the dataadapter to delete  from the [table name] where textbox containing sno
            //try and catch exception is used to stop thedisturbance in the program flow
            //query insert into [database name] whose  values are in the textboxes(texbox names)
            con.Open();
            string query = "Delete From [Qualified_employees] Where [Id]= '" + textid.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
        }

        // =======================================================================================
        //PLEASE NOTE: The code below is for Maintenance company that can perform the service under Maintenance services: 
        private void btn_update_Maintenance_company_Click(object sender, EventArgs e)
        {
            //to add connection to the database first open connection
         // then a query was used to tell the dataadapter what to do and with this connection.
         //In the query the statement is telling to update datatable[name] set [coloum name] = the string in textbox and so on...
         //after open a connection a connection must be close otherwise you ll get con.close() error message
         //cmd.ExecuteNonQuery(); Executes a Transact-SQL statement against the connection and returns the number of rows affected.
            con.Open();
            string query = @"UPDATE Name_of_maintenance_Company SET [Name of the Company] = '" + textname_of_company.Text + "', [Contact Person Name] = '" + textcontact_per_name.Text + "', [Contact Person Telephone] = '" + textcont_per_telephone.Text + "', [Cost] = '" + text_cost.Text + "', [Address] = '" + text_address.Text + "' WHERE Id = '" + text_id.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_Save_Maintenance_company_Click(object sender, EventArgs e)
        {
            //try and catch exception is used to stop thedisturbance in the program flow
            //query insert into [database name] whose  values are in the textboxes(texbox names)
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Name_of_maintenance_Company] Values('" + text_id.Text + "','" + textname_of_company.Text + "','" + textcontact_per_name.Text + "','" + textcont_per_telephone.Text + "','" + text_cost.Text + "','" + text_address.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_View_Maintenance_company_Click(object sender, EventArgs e)
        {
            //to show data in the data on the datagrid view.
            //Query used to tell the the dataadapter to select *(all) from [datatable name]
            //dataadapter will use the method fill to populate the datagrid view
            //datasource was used to fill the database
            // always use connection close command when theconnection was opened 
            //In the last convert it to .tostring because textbox cannot woerk with int values
            con.Open();
            string query = "Select * from [Name_of_maintenance_Company]";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt; //datagridview = grid for maintenace Maintenance_company
            con.Close();
        }

        private void btn_Delete_Maintenance_company_Click(object sender, EventArgs e)
        {
            //To delete the data from database a query is used to tell the dataadapter to delete  from the [table name] where textbox containing sno
         //try and catch exception is used to stop thedisturbance in the program flow
         //query insert into [database name] whose  values are in the textboxes(texbox names)
            con.Open();
            string query = "Delete From [Name_of_maintenance_Company] Where [Id]= '" + text_id.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//Created a single click element on a full row
            //when a row is selected then get the data from data grid where selectedrows represents coloumbs and cells represent rows, where value is used to  capture data

            text_id.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textname_of_company.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textcontact_per_name.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textcont_per_telephone.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            text_cost.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            text_address.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_search_Click(object sender, EventArgs e)
        {   //To view the details of records using single combobox.
            //select the options and press the search option t display the results
       
            if(comboBox1.Text == "Names of qualified employees")
            {
                con.Open();
                string query = "Select * from [Qualified_employees]";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;//datagridview3 = grid for qualified employees
                con.Close();
            }
            else if (comboBox1.Text== "Name of maintenance Company")
            {
                con.Open();
                string query = "Select * from [Name_of_maintenance_Company]";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt; //datagridview3 = grid for maintenace Maintenance_company
                con.Close();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_dashb_Click(object sender, EventArgs e)
        {
            // goto dashboard
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            //goto login page
            this.Hide();
            MainWindow login = new MainWindow();
            login.Show();
        }
    }
}
