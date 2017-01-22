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

namespace TrustCalculator
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

      
        private void TrustRegistation_Click(object sender, RoutedEventArgs e)
        {
            TrustRegistation  cal = new  TrustRegistation();
            cal.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_Report(object sender, RoutedEventArgs e)
        {
            TrustList tl = new TrustList();
            tl.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
           MyProfile tl = new MyProfile();
           tl.Show();
        }

        
    }
}
