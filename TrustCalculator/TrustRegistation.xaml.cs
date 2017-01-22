using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
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
    /// Interaction logic for TrustRegistation.xaml
    /// </summary>
    public partial class TrustRegistation : Window
    {
        TrustCalculatorEntities dbcon = new TrustCalculatorEntities();
        bool ret=false;

        public TrustRegistation()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            filterclass();
            if (ret)
            {
                var value = (from p in dbcon.TrustDetails
                             where p.TrustName == txt_TrustName.Text.Trim()
                             select p
                             ).SingleOrDefault();
                if (value == null)
                {
                    try
                    {

                        TrustDetail TD = new TrustDetail();
                        TD.TrustName = txt_TrustName.Text.Trim();
                        TD.Address = txt_Address.Text.Trim();
                        TD.PanNo = txt_PanNo.Text;
                        TD.ContPerson = txt_Person.Text;
                        TD.PhoneNo = txt_PhoneNO.Text;
                        dbcon.TrustDetails.Add(TD);
                        dbcon.SaveChanges();
                        this.Close();
                        Calculator Cal = new Calculator(txt_TrustName.Text, false);                 
                        Cal.ShowDialog();
                    }
                    catch (Exception)
                    {

                    }
                }

                else
                {

                    MessageBox.Show("It is already existed!...");
                }
            }
        }

        void filterclass()
        {
            if (txt_TrustName.Text == string.Empty)
            {
                MessageBox.Show("Enter Trust Name!...");
            }
            else
            {
                ret = true;
            }

           
        }

    }
}
