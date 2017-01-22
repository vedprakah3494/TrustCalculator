using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
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
    /// Interaction logic for MyProfile.xaml
    /// </summary>
    public partial class MyProfile : Window
    {
        TrustCalculatorEntities dbcon = new TrustCalculatorEntities();
        bool ret = false;

        public MyProfile()
        {
            InitializeComponent();
            loaddata();
        }
        void loaddata()
        {

            var value = (from p in dbcon.UserDetails
                         where p.UserName == Global.UserID
                         select new
                         {
                             p.Name,
                             p.EmailID,

                         }).SingleOrDefault();
            txt_UserName.Text = Global.UserID;
            txt_Name.Text = value.Name;
            txt_EmailID.Text = value.EmailID;

        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                 if (txt_OldPassword.Text.Trim() != string.Empty)
                {
                    if(txt_NewPassword.Text.Trim()!= string.Empty)
                    {
                        var value = (from p in dbcon.UserDetails
                                     where p.Password == txt_OldPassword.Text
                                     select p.Name
                                     ).SingleOrDefault();
                        if(value != null)
                        {
                            UserDetail TD = dbcon.UserDetails.Find(txt_UserName.Text.Trim());
                            TD.EmailID = txt_EmailID.Text;
                            TD.Password = txt_NewPassword.Text.Trim();
                            dbcon.UserDetails.Add(TD);
                            dbcon.Entry(TD).State=EntityState.Modified;
                            dbcon.SaveChanges();
                            MessageBox.Show("Profile Updated Successfully!...");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Enter Correct Old Password!...");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Enter New Password");
                    }
                }
                else
                 {
                     UserDetail TD = dbcon.UserDetails.Find(txt_UserName.Text.Trim());
                     TD.EmailID = txt_EmailID.Text;                   
                     dbcon.UserDetails.Add(TD);
                     dbcon.Entry(TD).State = EntityState.Modified;
                     dbcon.SaveChanges();
                     this.Close();
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                       MessageBox.Show( validationError.PropertyName+validationError.ErrorMessage);
                    }
                }
            }

        }
    }
}
