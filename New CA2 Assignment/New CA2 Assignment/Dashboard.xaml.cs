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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
       
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Equipment_Info equip = new Equipment_Info();
            equip.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            equip.Show();
            this.Hide();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            saad ss = new saad();
            ss.Show();
            this.Hide();
        }

        private void btn_Componenet_info_Click(object sender, RoutedEventArgs e)
        {
            Component_info comp = new Component_info();
            comp.Show();
            this.Hide();
        }

        private void Btn_ainte_service_Click(object sender, RoutedEventArgs e)
        {
            Qualified_employees qqq = new Qualified_employees();
            qqq.Show();
            this.Hide();
        }
    }
}