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

namespace New_CA2_Assignment
{
    /// <summary>
    /// Interaction logic for Equipment_Info.xaml
    /// </summary>
    public partial class Equipment_Info : Window
    {
        public Equipment_Info()
        {
            InitializeComponent();
        }

        private void btn_dash_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Btn_shut_Click(object sender, RoutedEventArgs e)
        {
            Shutdown_Maintenance shut = new Shutdown_Maintenance();
            shut.Show();
            this.Hide();
        }

        private void btn_Break_Click(object sender, RoutedEventArgs e)
        {
            Breakdown_Maintenance brek = new Breakdown_Maintenance();
            brek.Show();
            this.Hide();
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Btn_log_Click(object sender, RoutedEventArgs e)
        {
            MainWindow logut = new MainWindow();
            logut.Show();
            this.Hide();
        }

        private void btn_company_Click(object sender, RoutedEventArgs e)
        {
            Most_services_company most = new Most_services_company();
            most.Show();
            this.Hide();
        }
    }
}
