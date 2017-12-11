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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace New_CA2_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con = new SqlConnection(@"Data Source=172.28.134.1;Initial Catalog=saadDB;Persist Security Info=True;User ID=m.abbas;Password=7ePbtsmMtN;Pooling=False");

        

       
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }



        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_login_Click(object sender, RoutedEventArgs e)
        {
            // this method is being tested in the below method
            string username = textBox.Text;
            string password = textBox1.Text;
            bool flag = Login_pagess(username, password);

        }
        public bool Login_pagess(string username, string password)
        {
            bool flag = false;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select [Access Level] from [Username] where [Username]='" + username + "'and [Password]='" + password + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Admin_dashboard ad = new Admin_dashboard();
                    ad.Show();
                    flag = true;
                }
                else if (dt.Rows[0][0].ToString() == "2")
                {
                    this.Hide();
                    Dashboard dd = new Dashboard();
                    dd.Show();
                    flag = true;
                }
            }
            catch
            {
                MessageBox.Show("Please enter the right credentials...");
            }
            return flag;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.Show();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
