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
            
            con.Open();
            string query = @"UPDATE Component SET [Component Number] = '" + textcomponent_num.Text + "', [Name] = '" + textName.Text + "', [Replacement Date] = '" + textReplce_date.Text + "', [Cost] = '" + textCost.Text + "' WHERE Id = '" + textId.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Component] Values('" + textId.Text + "','" + textcomponent_num.Text + "','" + textName.Text + "','" + textReplce_date.Text + "','" + textCost.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("succ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * from [Component]";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Delete From [Component] Where [Id]= '" + textId.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record has been deleted successfully");
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
        {
            MainWindow log = new MainWindow();
            log.Show();
            this.Hide();
        }

        private void Btn_detail_Click(object sender, EventArgs e)
        {
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
