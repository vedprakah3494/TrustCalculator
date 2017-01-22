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

namespace TrustCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TrustCalculatorEntities dbcon = new TrustCalculatorEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var value = (from p in dbcon.UserDetails
                        where p.UserName==txt_username.Text.Trim()&& p.Password==txt_Password.Password select p.Name).SingleOrDefault();
            if(value!=null)
            {
                Home home = new Home();
                Global.UserID = txt_username.Text;
                home.Show();
                this.Close();
            }
            else
            { 
                MessageBox.Show("You have enter wrong password!....");
                txt_Password.Password = string.Empty;
                txt_username.Text=string.Empty;
            }

        }
    }
}
