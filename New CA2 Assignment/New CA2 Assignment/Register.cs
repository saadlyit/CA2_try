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
//Always use the above command before entering sql connection

namespace New_CA2_Assignment
{
    public partial class Register : Form
    {// connection to sqlserver
        SqlConnection con = new SqlConnection(@"Data Source=172.28.134.1;Initial Catalog=saadDB;Persist Security Info=True;User ID=m.abbas;Password=7ePbtsmMtN;Pooling=False");
        SqlCommand cmd = new SqlCommand();
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {//goto login page
            this.Close();
            MainWindow login = new MainWindow();
            login.Show();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            //if combobox equal to 2 execute comprlte code. if not a message will display to enter acces level 2 
            ////try and catch exception is used to stop thedisturbance in the program flow
            //query insert into [database name] whose  values are in the textboxes(texbox names)
            //cmd.ExecuteNonQuery(); Executes a Transact-SQL statement against the connection and returns the number of rows affected.
            if (comboBox1.Text == "2")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Username] Values('" + textuserid.Text + "','" + textforeneame.Text + "','" + textsurname.Text + "','" + textusername.Text + "','" + textpassword.Text + "','" + comboBox1.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Registered", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Please select number 2 from combobox");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
