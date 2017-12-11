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
    public partial class Admin_dashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=172.28.134.1;Initial Catalog=saadDB;Persist Security Info=True;User ID=m.abbas;Password=7ePbtsmMtN;Pooling=False");
        SqlCommand cmd = new SqlCommand();
        public Admin_dashboard()
        {
            InitializeComponent();
        }

        private void btnn_update_Click(object sender, EventArgs e)
        {
            string id = textuserid.Text;
            string forename = textforname.Text;
            string surname = textsurname.Text;
            string username = textsurname.Text;
            string password = textpassword.Text;
            string acc_level = combobox_accesslevel.Text;
            bool flag = update_value(id,forename,surname,username,password,acc_level);
        }
        //this method getting the value from unittest 

        public bool update_value(string id, string forename,string surname,string username,string password,string acc_level)
        {
            bool flag = false;
            try
            {
                con.Open();
                //string query = "Update [Username] SET [User id] = '" + textuserid.Text + "',[Forename]='" + textforname.Text + "',[Surname]='" + textsurname.Text + "',[Username] ='" + textpassword.Text + "',[Password] = '" + textpassword.Text + "',[Access Level] = '" + combobox_accesslevel.Text+ "'";
                string query = @"UPDATE Username SET [Forename] = '" + forename + "', [Surname] = '" + surname + "', [Username] = '" + username + "', [Password] = '" + password + "', [Access Level] = '" + acc_level + "' WHERE [User id] = '" + id + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            catch { }
            return flag;
            }
        private void Btnn_vieww_Click(object sender, EventArgs e)
        {
            string a = "btnclick";
            bool flag = view(a);
        }
        //this method getting the value from unittest 

        public bool view(string a)
        {
            bool flag = false;
            try
            {
                if (a=="btnclick") {
                    con.Open();
                    string query = "Select * from [Username]";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViiew_userdetails.DataSource = dt;
                    con.Close();
                    flag = true;
                }
            }
            catch { }
            return flag;
        }
        private void Btnn_savee_Click(object sender, EventArgs e)
        {
            string id = textuserid.Text;
            string forename = textforname.Text;
            string surname = textsurname.Text;
            string username = textsurname.Text;
            string password = textpassword.Text;
            string acc_level = combobox_accesslevel.Text;
            bool flag = save_value(id, forename, surname, username, password, acc_level);

        }
        //this method getting the value from unittest 

        public bool save_value(string id, string forename, string surname, string username, string password, string acc_level)
        {
            bool flag = false;
            if (acc_level == "1" || acc_level == "2")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [Username] Values('" + id + "','" + forename + "','" + surname + "','" + username + "','" + password + "','" + acc_level + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    flag = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
               
            }
            else
            {
                MessageBox.Show("Please select access level number", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return flag;
        }
        private void dataGridViiew_userdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textuserid.Text = dataGridViiew_userdetails.SelectedRows[0].Cells[0].Value.ToString();
            textforname.Text = dataGridViiew_userdetails.SelectedRows[0].Cells[1].Value.ToString();
            textsurname.Text = dataGridViiew_userdetails.SelectedRows[0].Cells[2].Value.ToString();
            textusename.Text = dataGridViiew_userdetails.SelectedRows[0].Cells[3].Value.ToString();
            textpassword.Text = dataGridViiew_userdetails.SelectedRows[0].Cells[4].Value.ToString();
            combobox_accesslevel.Text = dataGridViiew_userdetails.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equipment_Info equip = new Equipment_Info();
            equip.Show();
        }
        //this method getting the value from unittest 

        private void Btnn_deletee_Click(object sender, EventArgs e)
        {
            string id = textuserid.Text;
            
            bool flag = delete_value(id);
                    }
        //this method getting the value from unittest 

        public bool delete_value(string id)
        {
            bool flag = false;

            try
            {
                con.Open();
                string query = "Delete From [Username] Where [User id]= '" + id + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            catch { }
            return flag;

        }
    }
}
