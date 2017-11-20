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
            con.Open();
            //string query = "Update [Username] SET [User id] = '" + textuserid.Text + "',[Forename]='" + textforname.Text + "',[Surname]='" + textsurname.Text + "',[Username] ='" + textpassword.Text + "',[Password] = '" + textpassword.Text + "',[Access Level] = '" + combobox_accesslevel.Text+ "'";
            string query = @"UPDATE Username SET [Forename] = '" + textforname.Text + "', [Surname] = '" + textsurname.Text + "', [Username] = '" + textusename.Text + "', [Password] = '" + textpassword.Text + "', [Access Level] = '" + combobox_accesslevel.Text + "' WHERE [User id] = '" + textuserid.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Btnn_vieww_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * from [Username]";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViiew_userdetails.DataSource = dt;
            con.Close();
        }

        private void Btnn_savee_Click(object sender, EventArgs e)
        {
            if (combobox_accesslevel.Text == "1" || combobox_accesslevel.Text == "2")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [Username] Values('" + textuserid.Text + "','" + textforname.Text + "','" + textsurname.Text + "','" + textusename.Text + "','" + textpassword.Text + "','" + combobox_accesslevel.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else {
                MessageBox.Show("Please select access level number", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
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

        private void Btnn_deletee_Click(object sender, EventArgs e)
        {
            
            {
                con.Open();
                string query = "Delete From [Username] Where [User id]= '" + textuserid.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
