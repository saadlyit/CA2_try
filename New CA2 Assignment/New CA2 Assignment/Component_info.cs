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
    public partial class Component_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=172.28.134.1;Initial Catalog=saadDB;Persist Security Info=True;User ID=m.abbas;Password=7ePbtsmMtN;Pooling=False");
        SqlCommand cmd = new SqlCommand();


        public Component_info()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            // this method is being tested in the below method
            string sno = textId.Text;
            string component = textcomponent_num.Text;
            string name = textName.Text;
            string replace_date = textReplce_date.Text;
            string cost = textCost.Text;
            bool flag = updatevalues(sno, component, name, replace_date, cost);
        }
        public bool updatevalues(string sno, string component, string name, string replace_date, string cost)
        {
            bool flag = false;
            try
            {
                con.Open();
                string query = @"UPDATE Component SET [Component Number] = '" + component + "', [Name] = '" + name + "', [Replacement Date] = '" + replace_date + "', [Cost] = '" + cost + "' WHERE Id = '" + sno + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated");
                flag = true;
            }
            catch { }
            return flag;
        }
        //this method getting the value from unittest 

        public bool savevalue(string sno, string component, string name, string replace_date, string cost)
        {
            bool flag = false;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Component] Values('" + sno + "','" + component + "','" + name + "','" + replace_date + "','" + cost + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("successfuly save", "info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;

            }
            catch { }
            return flag;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // this method is being tested in the below method
            string sno = textId.Text;
            string component = textcomponent_num.Text;
            string name = textName.Text;
            string replace_date = textReplce_date.Text;
            string cost = textCost.Text;
            bool flag = savevalue(sno, component, name, replace_date, cost);
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            string a = "btnclick";
            view(a);
        }
        //this method getting the value from unittest 

        public bool view(string a)
        {
            bool flag = false;
            try
            {
                if (a == "btnclick") {
                    con.Open();
                    string query = "Select * from [Component]";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    con.Close();
                    flag = true; }
            }
            catch { }
            return flag;
        }
        
        private void btndelete_Click(object sender, EventArgs e)
        {
            // this method is being tested in the below method
            string sno = textId.Text;
            bool flag = deletevalue(sno);

        }
        //this method getting the value from unittest 

        public bool deletevalue(string sno)
        {
            bool flag = false;
            try
            {
                con.Open();
                string query = "Delete From [Component] Where [Id]= '" + sno + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record has been deleted successfully");
                flag = true;
            }
            catch { }
            return flag;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {  //goto login page
            this.Hide();
            MainWindow login = new MainWindow();
            login.Show();

        }

        private void Btn_detail_Click(object sender, EventArgs e)
        {//this method is already tested
            con.Open();
            string query = "Select * from [Component]";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridcomponent.DataSource = dt;
            con.Close();
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            textId.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textcomponent_num.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            textName.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            textReplce_date.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            textCost.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
