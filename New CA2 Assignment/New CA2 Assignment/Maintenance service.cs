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
            // this method is being tested in the below method
            string id = textid.Text;
            string social_security = textsocial_security_num.Text;
            string name = textName.Text;
            string department = text_department.Text;
            string cost = textcost.Text;
            string contact = textcontact.Text;
            bool flag = Updatevalue(id, social_security, name, department, cost, contact);
        }
        public bool Updatevalue(string id, string social_security, string name, string department, string cost, string contact)
        {
            bool flag = false;
            try
            {
                //to add connection to the database first open connection
                // then a query was used to tell the dataadapter what to do and with this connection.
                //In the query the statement is telling to update datatable[name] set [coloum name] = the string in textbox and so on...
                //after open a connection a connection must be close otherwise you ll get con.close() error message
                //cmd.ExecuteNonQuery(); Executes a Transact-SQL statement against the connection and returns the number of rows affected.
                con.Open();
                string query = @"UPDATE Qualified_employees SET [Social Security Number] = '" + social_security + "', [Name] = '" + name + "', [Department] = '" + department + "', [Cost] = '" + cost + "', [Contact Numbet] = '" + contact + "' WHERE Id = '" + id + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            catch { }
            return flag;
        }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            // this method is being tested in the below method
            string id = textid.Text;
            string social_security = textsocial_security_num.Text;
            string name = textName.Text;
            string department = text_department.Text;
            string cost = textcost.Text;
            string contact = textcontact.Text;
            bool flag = savevalue(id, social_security, name, department, cost, contact);

        }
        public bool savevalue(string id, string social_security, string name, string department, string cost, string contact)
        {
            bool flag = false;
            //try and catch exception is used to stop the disturbance in the program flow
            //query insert into [database name] whose  values are in the textboxes(texbox names)
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Qualified_employees] Values('" + id + "','" + social_security + "','" + name + "','" + department + "','" + cost + "','" + contact + "')";
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

        private void Btn_view_Click(object sender, EventArgs e)
        {
            string a = "";
            bool flag = Qview(a);
        }
        //this method getting the value from unittest 

        public bool Qview(string a)
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
                    string query = "Select * from [Qualified_employees]";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                    flag = true;
                }
            }
            catch { }
            return flag;
        }
        private void Btn_delete_Click(object sender, EventArgs e)
        {
            // this method is being tested in the below method
            string id = textid.Text;
            bool flag = deletevalue(id);
        }
        //this method getting the value from unittest 

        public bool deletevalue(string id)
        {
            bool flag = false;
            try
            {
                //To delete the data from database a query is used to tell the dataadapter to delete  from the [table name] where textbox containing sno
                //try and catch exception is used to stop thedisturbance in the program flow
                //query insert into [database name] whose  values are in the textboxes(texbox names)
                con.Open();
                string query = "Delete From [Qualified_employees] Where [Id]= '" + id + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has been sucessfully deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            catch { }
            return flag;
        }
        // =======================================================================================
        //PLEASE NOTE: The code below is for Maintenance company that can perform the service under Maintenance services: 
        private void btn_update_Maintenance_company_Click(object sender, EventArgs e)
        {
            // this method is being tested in the below method

            string id = text_id.Text;
            string company_name = textname_of_company.Text;
            string contact_per_name = textcontact_per_name.Text;
            string per_tele = textcont_per_telephone.Text;
            string cost = text_cost.Text;
            string address = text_address.Text;
            bool flag = updatemain_value(id, company_name, contact_per_name, per_tele, cost, address);

        }
        //this method getting the value from unittest 

        public bool updatemain_value(string id, string company_name, string contact_per_name, string per_tele, string cost, string address)
        {
            bool flag = false;
            try
            {

                //to add connection to the database first open connection
                // then a query was used to tell the dataadapter what to do and with this connection.
                //In the query the statement is telling to update datatable[name] set [coloum name] = the string in textbox and so on...
                //after open a connection a connection must be close otherwise you ll get con.close() error message
                //cmd.ExecuteNonQuery(); Executes a Transact-SQL statement against the connection and returns the number of rows affected.
                con.Open();
                string query = @"UPDATE Name_of_maintenance_Company SET [Name of the Company] = '" + company_name + "', [Contact Person Name] = '" + contact_per_name + "', [Contact Person Telephone] = '" + per_tele + "', [Cost] = '" + cost + "', [Address] = '" + address + "' WHERE Id = '" + id + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated into Name_of_maintenance_Company", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;

            }
            catch { }
            return flag;
        }
        private void btn_Save_Maintenance_company_Click(object sender, EventArgs e)
        {
            // this method is being tested in the below method

            string id = text_id.Text;
            string company_name = textname_of_company.Text;
            string contact_per_name = textcontact_per_name.Text;
            string per_tele = textcont_per_telephone.Text;
            string cost = text_cost.Text;
            string address = text_address.Text;
            bool flag = savemain_value(id, company_name, contact_per_name, per_tele, cost, address);
        }
        //this method getting the value from unittest 

        public bool savemain_value(string id, string company_name, string contact_per_name, string per_tele, string cost, string address)
        {
            bool flag = false;
            //try and catch exception is used to stop thedisturbance in the program flow
            //query insert into [database name] whose  values are in the textboxes(texbox names)
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Name_of_maintenance_Company] Values('" + id + "','" + company_name + "','" + contact_per_name + "','" + per_tele + "','" + cost + "','" + address + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Saved into Name_of_maintenance_Company ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return flag;
        }
        private void btn_View_Maintenance_company_Click(object sender, EventArgs e)
        {
            string a = "btnclick";
            bool flag = main_view(a);
           
        }
        //this method getting the value from unittest 

        public bool main_view(string a)
        {

            bool flag = false;
            try
            {
                if (a == "btnclick") {
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
                    flag = true; }
                }
            catch { }
            return flag;
            }
            

        private void btn_Delete_Maintenance_company_Click(object sender, EventArgs e)
        {
            string id = text_id.Text;
            bool flag = deletemain_value(id);
        }
        //this method getting the value from unittest 

        public bool deletemain_value(string id)
        {
            bool flag = false;
            try
            {
                //To delete the data from database a query is used to tell the dataadapter to delete  from the [table name] where textbox containing sno
                //try and catch exception is used to stop thedisturbance in the program flow
                //query insert into [database name] whose  values are in the textboxes(texbox names)
                con.Open();
                string query = "Delete From [Name_of_maintenance_Company] Where [Id]= '" + id + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("successfully deleted from the database", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            catch { }
            return flag;
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
        {
            string combo = comboBox1.Text;
            bool flag = search_value(combo);
        }
        //this method getting the value from unittest 

        public bool search_value(string combo)
        {
            bool flag = false;
            try
            {
                //To view the details of records using single combobox.
                //select the options and press the search option t display the results

                if (combo == "Names of qualified employees")
                {
                    con.Open();
                    string query = "Select * from [Qualified_employees]";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView3.DataSource = dt;//datagridview3 = grid for qualified employees
                    con.Close();
                    flag = true;
                }
                else if (combo == "Name of maintenance Company")
                {
                    con.Open();
                    string query = "Select * from [Name_of_maintenance_Company]";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView3.DataSource = dt; //datagridview3 = grid for maintenace Maintenance_company
                    con.Close();
                    flag = true;
                }
            }
            catch {
                MessageBox.Show("search the right value");
            }
            return flag;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
