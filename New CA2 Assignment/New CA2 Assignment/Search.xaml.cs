using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace New_CA2_Assignment
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source=172.28.134.1;Initial Catalog=saadDB;Persist Security Info=True;User ID=m.abbas;Password=7ePbtsmMtN;Pooling=False");
        DataSet ds1 = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        public Search()
        {
            InitializeComponent();
        }
        
        private void loadtablename()
        {
           
            comboBox.Items.Clear();
            cmd.CommandText = "Select * from [information_schema.tables] where [table_type]='base table'";
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    comboBox.Items.Add(dr["Table_name"].ToString());
                }
            }
            con.Close();
        }
        private void loadtablecolumb()
        {
            listBox.Items.Clear();
            cmd.CommandText = "Select Sno from [smaintenance] where [Maintenance Date]='april'";
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox.Items.Add(dr[0].ToString());
                }
            }
            con.Close();
        }

        private void btn_searh_Click(object sender, RoutedEventArgs e)
        {
            loadtablename();
            try
            {
                cmd.CommandText = textBox.Text.ToString();
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listBox.Items.Add(dr[0].ToString());
                    }
                }
                else
                {
                    listBox.Items.Add("No data found");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                con.Close();
            }

        }
    }

}
