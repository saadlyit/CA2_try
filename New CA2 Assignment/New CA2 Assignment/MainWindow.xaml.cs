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

namespace New_CA2_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        newsaadDBEntities dbbentities = new newsaadDBEntities();
        List<Username> userlist = new List<Username>();
        //make gloabal user list

        private void loadmethod()
        {
            userlist.Clear();
            foreach (var user in dbbentities.Usernames)
            {
                userlist.Add(user);
            }

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Pre-load users into the User global list
            loadmethod();
        }



        public MainWindow()
        {
            InitializeComponent();
        }
        private Username mtdGetUserDetails(string username, string password)
        {
            Username userdetail = new Username();
            foreach (var user in userlist)
            {
                if (username == user.Username1 && password == user.Password)
                {
                    userdetail = user;
                }
            }
            return userdetail;
        }
        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_login_Click(object sender, RoutedEventArgs e)
        {
            Username userdetails = new Username();
            string currentuser = textBox.Text.Trim();
            string xurrentpass = textBox1.Text.Trim();
            userdetails = mtdGetUserDetails(currentuser, xurrentpass);
            if (userdetails.Access_Level == 2)
            {
                this.Hide();
                Dashboard dashBoard = new Dashboard();
                dashBoard.Show();
            }
            else if (userdetails.Access_Level == 1)
            {
                Admin_dashboard ad = new Admin_dashboard();
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid details!");

            }


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Register rr = new Register();
            rr.Show();
            this.Hide();
        }
    }
}
