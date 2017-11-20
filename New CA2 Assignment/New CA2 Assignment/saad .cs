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
    public partial class saad : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=172.28.134.1;Initial Catalog=saadDB;Persist Security Info=True;User ID=m.abbas;Password=7ePbtsmMtN;Pooling=False");
        SqlDataAdapter da = new SqlDataAdapter();
        
        public saad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Shutdown Maintenance")
            {
                DataTable dt = new DataTable();
                con.Open();
                da = new SqlDataAdapter("Select * From [smaintenance] where [Maintenance Date] like '"+textBox1.Text+"%'", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (comboBox1.Text == "Breakdown Maintenance")
            {
                DataTable dt = new DataTable();
                con.Open();
                da = new SqlDataAdapter("Select * From [bmaintenance] where [Maintenance Date] like '" + textBox1.Text + "%'", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (comboBox1.Text == "Shutdown")
            {
                DataTable dt = new DataTable();
                con.Open();
                da = new SqlDataAdapter("Select * From [shutdown] where [Manufacturing Date] like '" + textBox1.Text + "%'", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
