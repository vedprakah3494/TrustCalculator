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
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using System.IO;

using System.Diagnostics;
namespace TrustCalculator
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        bool update = false,Flag;
        string trustName;
        TrustCalculatorEntities dbcon = new TrustCalculatorEntities();

        public Calculator(string Name, bool flag)
        {
            InitializeComponent();
            trustName = Name;
            Flag = flag;          
        }
        void loaddata()
        {
            var value = (from p in dbcon.TrustDetails
                         where p.TrustName == lbl_Name.Content
                         select new
                         {
                             p.TrustID,
                             p.PanNo,
                             p.Advances,
                             p.Total_Corps

                         }).SingleOrDefault();
            Global.trustID = value.TrustID;
            txt_TotalAmt.Text = value.Total_Corps.ToString();
            txt_advances.Text = value.Advances.ToString();
            Prortfolio();
            LoadData_Existing(value.TrustID);

        }

        void LoadData_Existing(int ID)
        {

            var value = (from p in dbcon.InvestmentDetails
                         where p.TrustID == ID
                         select new
                         {
                             InvestmentValue = p.InvestmentValue,
                             Comment = p.Comment

                         }).ToList();

            //Category I
            txt_GoiCurrent.Text = value[0].InvestmentValue.ToString();
            txt_GoiComment.Text = value[0].Comment;

            txt_GGSExisting.Text = value[1].InvestmentValue.ToString();
            txt_GGSComment.Text = value[1].Comment;


            txt_GiltCurrent.Text = value[2].InvestmentValue.ToString();
            txt_GiltComment.Text = value[2].Comment;

            //Category II


            txt_BcbExisting.Text = value[3].InvestmentValue.ToString();
            txt_bcbComment.Text = value[3].Comment;

            txt_BbExisting.Text = value[4].InvestmentValue.ToString();
            txt_BbComment.Text = value[4].Comment;

            txt_RbExisting.Text = value[5].InvestmentValue.ToString();
            txt_RbComment.Text = value[5].Comment;

         
            txt_TibExisting.Text = value[6].InvestmentValue.ToString();
            txt_Comment.Text= value[6].Comment;


            txt_DmfExisting.Text = value[7].InvestmentValue.ToString();
            txt_DmfComment.Text = value[7].Comment;

            txt_IdiExisting.Text = value[8].InvestmentValue.ToString();
            txt_IdiComment.Text = value[8].Comment;

            // Cetegory III
            txt_MmiExisting.Text = value[9].InvestmentValue.ToString();
            txt_MmiComment.Text= value[9].Comment;

            txt_LmfExisting.Text = value[10].InvestmentValue.ToString();
            txt_LmfComment.Text = value[10].Comment;

            txt_SttExisting.Text = value[11].InvestmentValue.ToString();
            txt_SttComment.Text= value[11].Comment;

            //Category 4th
            txt_EsExisting.Text = value[12].InvestmentValue.ToString();
            txt_EsComment.Text = value[12].Comment;

            txt_EmfExisting.Text = value[13].InvestmentValue.ToString();
            txt_EmfComment.Text = value[13].Comment;

            txt_EifExisting.Text = value[14].InvestmentValue.ToString();
            txt_EifComment.Text = value[14].Comment;

            txt_EiSebiExisting.Text = value[15].InvestmentValue.ToString();
            txt_EiSebiComment.Text = value[15].Comment;

            txt_EdExisting.Text = value[16].InvestmentValue.ToString();
            txt_EdComment.Text = value[16].Comment;


            //Category5
            txt_CmExisting.Text = value[17].InvestmentValue.ToString();
            txt_CmComment.Text = value[17].Comment;

            txt_ReitExisting.Text = value[18].InvestmentValue.ToString();
            txt_ReitComment.Text = value[18].Comment;

            txt_AbsExisting.Text = value[19].InvestmentValue.ToString();
            txt_AbsComment.Text = value[19].Comment;

            txt_IiTExisting.Text = value[20].InvestmentValue.ToString();
            txt_IiTComment.Text = value[20].Comment;


            var Cvalue = (from p in dbcon.CategoryDetails
                          where p.TrustID == ID
                          select new
                          {
                              ExistingValue = p.TotalCatValue,
                              Comment = p.Comment

                          }).ToList();

            txt_TICurrent.Text = Cvalue[0].ExistingValue.Value.ToString();
            txt_TIComment.Text = Cvalue[0].Comment;

            txt_TIIExisting.Text= Cvalue[1].ExistingValue.Value.ToString();
            txt_TIIComment.Text = Cvalue[1].Comment;

            txt_TIIIExisting.Text = Cvalue[2].ExistingValue.Value.ToString();
            txt_TIIIComment.Text = Cvalue[2].Comment;

            txt_TVIExisting.Text = Cvalue[3].ExistingValue.Value.ToString();
            txt_TVIComment.Text = Cvalue[3].Comment;

            txt_TVExisting.Text = Cvalue[4].ExistingValue.Value.ToString();
            txt_TVComment.Text = Cvalue[4].Comment;


        }


        private void txt_CatI_Click(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedItem = CategoryII;
        }

        private void btn_NextCatII_Click(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedItem = CategoryIII;
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        void NetCalculation()
        {
            decimal first = 0;
            decimal second = 0;
            decimal output;
            try
            {
              
                if (!Decimal.TryParse(txt_advances.Text.Trim(), out second))
                {
                    MessageBox.Show("Please Enter correct Advance Amount!....");

                }
                if (!Decimal.TryParse(txt_TotalAmt.Text.Trim(), out first))
                {
                    MessageBox.Show("Please Enter correct No.!....");

                }
               
                output = first - second;
                txt_NetAmt.Text = (output.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Enter Correct Amount!...");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Prortfolio();
        }

        private void Prortfolio()
        {
            NetCalculation();
            categoryI_A();
            categoryI_B();
            categoryI_C();
            categoryI_T();
            //Second category
            categoryII_A();
            categoryII_B();
            categoryII_C();
            categoryII_D();
            categoryII_E();
            categoryII_F();
            categoryII_T();
            //third Category
            categoryIII_A();
            categoryIII_B();
            categoryIII_C();
            categoryIII_T();
            //4th Category
            categoryVI_A();
            categoryVI_B();
            categoryVI_C();
            categoryVI_D();
            categoryVI_E();
            categoryVI_T();
            //5th Category
            categoryV_A();
            categoryV_B();
            categoryV_C();
            categoryV_D();
            categoryV_T();
        }

        void categoryI_A()
        {

            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 1 && p.InvestmentID == 1
                         select p).SingleOrDefault();
            txt_GoiMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_GoiMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        void categoryI_B()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 1 && p.InvestmentID == 2
                         select p).SingleOrDefault();
            txt_GiltMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_GiltMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        void categoryI_C()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 1 && p.InvestmentID == 3
                         select p).SingleOrDefault();
            txt_GGSMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_GGsMini.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        void categoryI_T()
        {
            var value = (from p in dbcon.ms_CategoryDetail
                         where p.CategoryID == 1
                         select p).SingleOrDefault();
            txt_TIMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_TIMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }

        //second category
        void categoryII_A()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 2 && p.InvestmentID == 4
                         select p).SingleOrDefault();
            txt_BcbMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_BcbMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }

        void categoryII_B()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 2 && p.InvestmentID == 5
                         select p).SingleOrDefault();
            txt_BbMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_BbMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        void categoryII_C()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 2 && p.InvestmentID == 6
                         select p).SingleOrDefault();
            txt_RbMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_RbMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        void categoryII_D()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 2 && p.InvestmentID == 7
                         select p).SingleOrDefault();
            txt_TibMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_TibMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        void categoryII_E()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 2 && p.InvestmentID == 8
                         select p).SingleOrDefault();
            txt_DmfMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_DmfMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        void categoryII_F()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 2 && p.InvestmentID == 9
                         select p).SingleOrDefault();
            txt_IdiMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_IdiMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        void categoryII_T()
        {
            var value = (from p in dbcon.ms_CategoryDetail
                         where p.CategoryID == 2
                         select p).SingleOrDefault();
            txt_TIIMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_TIIMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        // 2nd Category Total

        void categoryIII_A()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 3 && p.InvestmentID == 10
                         select p).SingleOrDefault();
            txt_MmiMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_MmiMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        void categoryIII_B()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 3 && p.InvestmentID == 11
                         select p).SingleOrDefault();
            txt_LmfMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_LmfMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        void categoryIII_C()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 3 && p.InvestmentID == 12
                         select p).SingleOrDefault();
            txt_SttMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_SttMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        // 3rd Category Total
        void categoryIII_T()
        {
            var value = (from p in dbcon.ms_CategoryDetail
                         where p.CategoryID == 3
                         select p).SingleOrDefault();
            txt_TIIIMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_TIIIMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }

        //4th category start

        void categoryVI_A()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 4 && p.InvestmentID == 13
                         select p).SingleOrDefault();
            txt_EsMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_EsMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";
        }
        void categoryVI_B()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 4 && p.InvestmentID == 14
                         select p).SingleOrDefault();
            txt_EmfMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_EmfMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        void categoryVI_C()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 4 && p.InvestmentID == 15
                         select p).SingleOrDefault();
            txt_EifMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_EifMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        void categoryVI_D()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 4 && p.InvestmentID == 16
                         select p).SingleOrDefault();
            txt_EiSebiMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_EifMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        void categoryVI_E()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 4 && p.InvestmentID == 17
                         select p).SingleOrDefault();
            txt_EdMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_EdMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        //total 4th Category
        void categoryVI_T()
        {
            var value = (from p in dbcon.ms_CategoryDetail
                         where p.CategoryID == 4
                         select p).SingleOrDefault();
            txt_TVIMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_TVIMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        //5th Category
        void categoryV_A()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 5 && p.InvestmentID == 18
                         select p).SingleOrDefault();
            txt_CmMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_CmMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";
        }
        void categoryV_B()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 5 && p.InvestmentID == 19
                         select p).SingleOrDefault();
            txt_ReitMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_ReitMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }

        void categoryV_C()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 5 && p.InvestmentID == 20
                         select p).SingleOrDefault();
            txt_AbsMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_AbsMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        void categoryV_D()
        {
            var value = (from p in dbcon.ms_InvestmentOption
                         where p.CategoryID == 5 && p.InvestmentID == 21
                         select p).SingleOrDefault();
            txt_IiTMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_IiTMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }
        //5th total
        void categoryV_T()
        {
            var value = (from p in dbcon.ms_CategoryDetail
                         where p.CategoryID == 5
                         select p).SingleOrDefault();
            txt_TVMax.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Maximum / 100) + "";
            txt_TVMin.Text = Convert.ToDecimal(txt_NetAmt.Text.Trim()) * Convert.ToDecimal(value.Minimum / 100) + "";

        }

        private void txt_GoiCurrent_TextChanged(object sender, TextChangedEventArgs e)
        {
            CategoryICal();
            if (txt_GoiCurrent.Text.Trim() != "")
            {
                txt_GoiStatus.Text = StatusTest(txt_GoiMax.Text, txt_GoiMin.Text, txt_GoiCurrent.Text);
            }

        }


        private void txt_GiltCurrent_TextChanged(object sender, TextChangedEventArgs e)
        {
            CategoryICal();
            if (txt_GiltCurrent.Text.Trim() != "")
            {
                txt_GiltStatus.Text = StatusTest(txt_GiltMax.Text, txt_GiltMin.Text, txt_GiltCurrent.Text);
            }
        }

        private void txt_GGSExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            CategoryICal();
            if (txt_GGSExisting.Text.Trim() != "")
            {
                txt_GGSStatus.Text = StatusTest(txt_GGSMax.Text, txt_GGsMini.Text, txt_GGSExisting.Text);
            }

        }

        string StatusTest(string Max, string Min, string Existing)
        {
             decimal max = Convert.ToDecimal(Max);
             decimal min = Convert.ToDecimal(Min);
             decimal existing = Convert.ToDecimal(Existing);
             string calvalue = string.Empty;
            try
            {
                if (existing > max)
                {
                    calvalue = "+" + (existing - max).ToString();

                }
                else if (existing < min)
                {

                    calvalue = "-" + (min - existing).ToString();
                }
                else if ((max >= existing) && (existing >= min))
                {
                    calvalue = "0";

                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Enter Correct No.!....");
            }
           return calvalue;
        }

        private void txt_TICurrent_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                if (txt_TICurrent.Text.Trim() != "")
                {
                    txt_TIStatus.Text = StatusTest(txt_TIMax.Text, txt_TIMin.Text, txt_TICurrent.Text);
                }
            }
            catch (Exception ex)
            {
               
            }

        }
        void CategoryICal()
        {
            try
            {

                txt_TICurrent.Text = (Convert.ToDecimal(txt_GGSExisting.Text.Trim()) + Convert.ToDecimal(txt_GoiCurrent.Text.Trim()) + Convert.ToDecimal(txt_GiltCurrent.Text.Trim())).ToString();

            }
            catch (Exception)
            {

            }

        }

        private void txt_BcbExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                CategoryIICal();
                if (txt_BcbExisting.Text.Trim() != "")
                {
                    txt_BcbCurrent.Text = StatusTest(txt_BcbMax.Text, txt_BcbMin.Text, txt_BcbExisting.Text);
                }
            }
            catch (Exception)
            {

            }

        }

        private void txt_RbExisting_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                CategoryIICal();
                if (txt_RbExisting.Text.Trim() != "")
                {
                    txt_RbCurrent.Text = StatusTest(txt_RbMax.Text, txt_RbMin.Text, txt_RbExisting.Text);
                }
            }
            catch (Exception)
            {

            }

        }

        private void txt_BbExisting_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                CategoryIICal();
                if (txt_BbExisting.Text.Trim() != "")
                {
                    txt_BbCurrent.Text = StatusTest(txt_BbMax.Text, txt_BbMin.Text, txt_BbExisting.Text);
                }
            }
            catch (Exception)
            {

            }

        }

        private void txt_TibExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                CategoryIICal();
                if (txt_TibExisting.Text.Trim() != "")
                {
                    txt_TibCurrent.Text = StatusTest(txt_TibMax.Text, txt_TibMin.Text, txt_TibExisting.Text);
                }
            }
            catch (Exception)
            {

            }

        }

        private void txt_DmfExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                CategoryIICal();
                if (txt_DmfExisting.Text.Trim() != "")
                {
                    txt_DmfCurrent.Text = StatusTest(txt_DmfMax.Text, txt_DmfMin.Text, txt_DmfExisting.Text);
                }
            }
            catch (Exception)
            {

            }


        }

        private void txt_IdiExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                CategoryIICal();
                if (txt_IdiExisting.Text.Trim() != "")
                {
                    txt_IdiCurrent.Text = StatusTest(txt_IdiMax.Text, txt_IdiMin.Text, txt_IdiExisting.Text);
                }
            }
            catch (Exception)
            {

            }

        }


        void CategoryIICal()
        {
            try
            {

                txt_TIIExisting.Text = (Convert.ToDecimal(txt_IdiExisting.Text.Trim()) +
                  Convert.ToDecimal(txt_DmfExisting.Text.Trim()) +
                  Convert.ToDecimal(txt_TibExisting.Text.Trim()) +
                   Convert.ToDecimal(txt_BbExisting.Text.Trim()) +
                    Convert.ToDecimal(txt_RbExisting.Text.Trim()) +
                  Convert.ToDecimal(txt_BcbExisting.Text.Trim())).ToString();
                txt_TIICurrent.Text = StatusTest(txt_TIIMax.Text, txt_TIIMin.Text, txt_TIIExisting.Text);

            }
            catch (Exception)
            {

            }

        }

        private void txt_MmiExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                CategoryIIICal();
                if (txt_MmiExisting.Text.Trim() != "")
                {
                    txt_MmiCurrent.Text = StatusTest(txt_MmiMax.Text, txt_MmiMin.Text, txt_MmiExisting.Text);
                }
            }
            catch (Exception)
            {

            }
        }

        private void txt_LmfExisting_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                CategoryIIICal();
                if (txt_LmfExisting.Text.Trim() != "")
                {
                    txt_LmfCurrent.Text = StatusTest(txt_LmfMax.Text, txt_LmfMin.Text, txt_LmfExisting.Text);
                }
            }
            catch (Exception)
            {

            }

        }

        private void txt_SttExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                CategoryIIICal();
                if (txt_SttExisting.Text.Trim() != "")
                {
                    txt_SttCurrent.Text = StatusTest(txt_SttMax.Text, txt_SttMin.Text, txt_SttExisting.Text);
                }
            }
            catch (Exception)
            {

            }
        }
        void CategoryIIICal()
        {
            try
            {

                txt_TIIIExisting.Text = (Convert.ToDecimal(txt_SttExisting.Text.Trim()) +
                  Convert.ToDecimal(txt_LmfExisting.Text.Trim()) +
                  Convert.ToDecimal(txt_MmiExisting.Text.Trim())).ToString();
                txt_TIIICurrent.Text = StatusTest(txt_TIIIMax.Text, txt_TIIIMin.Text, txt_TIIIExisting.Text);

            }
            catch (Exception)
            {

            }

        }


        void CategoryVICal()
        {
            try
            {

                txt_TVIExisting.Text = (Convert.ToDecimal(txt_EdExisting.Text.Trim()) +
                  Convert.ToDecimal(txt_EsExisting.Text.Trim()) +
                  Convert.ToDecimal(txt_EiSebiExisting.Text.Trim()) +
                  Convert.ToDecimal(txt_EifExisting.Text.Trim()) +
                  Convert.ToDecimal(txt_EmfExisting.Text.Trim())).ToString();
                txt_TVICurrent.Text = StatusTest(txt_TVIMax.Text, txt_TVIMin.Text, txt_TVIExisting.Text);

            }
            catch (Exception)
            {

            }

        }

        private void txt_EsExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                CategoryVICal();
                if (txt_EsExisting.Text.Trim() != "")
                {
                    txt_EsCurrent.Text = StatusTest(txt_EsMax.Text, txt_EsMin.Text, txt_EsExisting.Text);
                }
            }
            catch (Exception)
            {

            }
        }

        private void txt_EmfExisting_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                CategoryVICal();
                if (txt_EmfExisting.Text.Trim() != "")
                {
                    txt_EmfCurrent.Text = StatusTest(txt_EmfMax.Text, txt_EmfMin.Text, txt_EmfExisting.Text);
                }
            }
            catch (Exception)
            {

            }
        }

        private void txt_EifExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                CategoryVICal();
                if (txt_EifExisting.Text.Trim() != "")
                {
                    txt_EifCurrent.Text = StatusTest(txt_EifMax.Text, txt_EifMin.Text, txt_EifExisting.Text);
                }
            }
            catch (Exception)
            {

            }

        }

        private void txt_EiSebiExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                CategoryVICal();
                if (txt_EiSebiExisting.Text.Trim() != "")
                {
                    txt_EiSebiCurrent.Text = StatusTest(txt_EiSebiMax.Text, txt_EiSebiMin.Text, txt_EiSebiExisting.Text);
                }
            }
            catch (Exception)
            {

            }

        }

        private void txt_EdExisting_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                CategoryVICal();
                if (txt_EdExisting.Text.Trim() != "")
                {
                    txt_EdCurrent.Text = StatusTest(txt_EdMax.Text, txt_EdMin.Text, txt_EdExisting.Text);
                }
            }
            catch (Exception)
            {

            }
        }

        private void txt_ReitExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                CategoryVCal();
                if (txt_ReitExisting.Text.Trim() != "")
                {
                    txt_ReitCurrent.Text = StatusTest(txt_ReitMax.Text, txt_ReitMin.Text, txt_ReitExisting.Text);
                }
            }
            catch (Exception)
            {

            }
        }

        private void txt_CmExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                CategoryVCal();
                if (txt_CmExisting.Text.Trim() != "")
                {
                    txt_CmCurrent.Text = StatusTest(txt_CmMax.Text, txt_CmMin.Text, txt_CmExisting.Text);
                }
            }
            catch (Exception)
            {

            }

        }

        private void txt_AbsExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                CategoryVCal();
                if (txt_AbsExisting.Text.Trim() != "")
                {
                    txt_AbsCurrent.Text = StatusTest(txt_AbsMax.Text, txt_AbsMin.Text, txt_AbsExisting.Text);
                }
            }
            catch (Exception)
            {

            }

        }

        private void txt_IiTExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                CategoryVCal();
                if (txt_IiTExisting.Text.Trim() != "")
                {
                    txt_IiTCurrent.Text = StatusTest(txt_IiTMax.Text, txt_IiTMin.Text, txt_IiTExisting.Text);
                }
            }
            catch (Exception)
            {

            }

        }
        void CategoryVCal()
        {
            try
            {

                txt_TVExisting.Text = (Convert.ToDecimal(txt_ReitExisting.Text.Trim()) +
                  Convert.ToDecimal(txt_CmExisting.Text.Trim()) +
                  Convert.ToDecimal(txt_AbsExisting.Text.Trim()) +
                  Convert.ToDecimal(txt_IiTExisting.Text.Trim())).ToString();
                txt_TVCurrent.Text = StatusTest(txt_TVMax.Text, txt_TVMin.Text, txt_TVExisting.Text);

            }
            catch (Exception)
            {

            }
        }



        private void btn_NextCatIII_Click(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedItem = CategoryIV;
        }

        private void btn_NextCatIV_Click(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedItem = CategoryV;
        }

        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TrustDetail DD = dbcon.TrustDetails.Find(Global.trustID);
                DD.Total_Corps = Convert.ToDecimal(txt_TotalAmt.Text.Trim());
                DD.Advances = Convert.ToDecimal(txt_advances.Text.Trim());
                dbcon.TrustDetails.Add(DD);
                dbcon.Entry(DD).State = EntityState.Modified;
                dbcon.SaveChanges();

            }
            catch (Exception ex)
            {
                
            }
            if (update == false)
            {
                savedata();
            }
            else
            {
                updatedata();
            }
            this.Close();
            if (chk_Print.IsChecked==true)
            {
                Print_withComment print = new Print_withComment(lbl_Name.Content.ToString());
                print.ShowDialog();
            }
            else
            {
                frm_Print Cal = new frm_Print(lbl_Name.Content.ToString());
                Cal.ShowDialog();
            }
        }
        void updatedata()
        {
            var value = (from p in dbcon.InvestmentDetails
                         where p.TrustID == Global.trustID
                         select p).ToList();
            var Cat = (from p in dbcon.CategoryDetails
                       where p.TrustID == Global.trustID
                       select p).ToList();
            CategoryDetail CD;
            InvestmentDetail ID;
            //Category I
            ID = dbcon.InvestmentDetails.Find(value[0].ID);
            ID.InvestmentID = 1;
            ID.Maximum = Convert.ToDecimal(txt_GoiMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_GoiMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_GoiCurrent.Text);
            ID.ExcessShortfall = txt_GoiStatus.Text;
            ID.Comment = txt_GoiComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[1].ID);
            ID.InvestmentID = 2;
            ID.Maximum = Convert.ToDecimal(txt_GGSMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_GGsMini.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_GGSExisting.Text);
            ID.ExcessShortfall = txt_GGSStatus.Text;
            ID.Comment = txt_GGSComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[2].ID);
            ID.InvestmentID = 3;
            ID.Maximum = Convert.ToDecimal(txt_GiltMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_GiltMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_GiltCurrent.Text);
            ID.ExcessShortfall = txt_GiltStatus.Text;
            ID.Comment = txt_GiltComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            CD = dbcon.CategoryDetails.Find(Cat[0].ID);
            CD.Maximum = Convert.ToDecimal(txt_TIMax.Text);
            CD.Minimum = Convert.ToDecimal(txt_TIMin.Text);
            CD.TotalCatValue = Convert.ToDecimal(txt_TICurrent.Text);
            CD.Status = txt_TIStatus.Text.Trim();
            CD.Comment =txt_TIComment.Text;
            dbcon.CategoryDetails.Add(CD);
            dbcon.Entry(CD).State = EntityState.Modified;
            dbcon.SaveChanges();


            //Category II
            ID = dbcon.InvestmentDetails.Find(value[3].ID);
            ID.InvestmentID = 4;
            ID.Maximum = Convert.ToDecimal(txt_BcbMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_BcbMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_BcbExisting.Text);
            ID.ExcessShortfall = txt_BcbCurrent.Text;
            ID.Comment = txt_bcbComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[4].ID);
            ID.InvestmentID = 5;
            ID.Maximum = Convert.ToDecimal(txt_BbMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_BbMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_BbExisting.Text);
            ID.ExcessShortfall = txt_BbCurrent.Text;
            ID.Comment = txt_BbComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[5].ID);
            ID.InvestmentID = 6;
            ID.Maximum = Convert.ToDecimal(txt_RbMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_RbMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_RbExisting.Text);
            ID.ExcessShortfall = txt_RbCurrent.Text;
            ID.Comment = txt_RbComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[6].ID);
            ID.InvestmentID = 7;
            ID.Maximum = Convert.ToDecimal(txt_TibMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_TibMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_TibExisting.Text);
            ID.ExcessShortfall = txt_TibCurrent.Text;
            ID.Comment = txt_Comment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[7].ID);
            ID.InvestmentID = 8;
            ID.Maximum = Convert.ToDecimal(txt_DmfMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_DmfMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_DmfExisting.Text);
            ID.ExcessShortfall = txt_DmfCurrent.Text;
            ID.Comment = txt_DmfComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[8].ID);
            ID.InvestmentID = 9;
            ID.Maximum = Convert.ToDecimal(txt_IdiMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_IdiMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_IdiExisting.Text);
            ID.ExcessShortfall = txt_IdiCurrent.Text;
            ID.Comment = txt_IdiComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            CD = dbcon.CategoryDetails.Find(Cat[1].ID);
            CD.Maximum = Convert.ToDecimal(txt_TIIMax.Text);
            CD.Minimum = Convert.ToDecimal(txt_TIIMin.Text);
            CD.TotalCatValue = Convert.ToDecimal(txt_TIIExisting.Text);
            CD.Status = txt_TIICurrent.Text;
            CD.Comment = txt_TIIComment.Text;
            dbcon.CategoryDetails.Add(CD);
            dbcon.Entry(CD).State = EntityState.Modified;
            dbcon.SaveChanges();

            // Cetegory III
            ID = dbcon.InvestmentDetails.Find(value[9].ID);
            ID.InvestmentID = 10;
            ID.Maximum = Convert.ToDecimal(txt_MmiMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_MmiMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_MmiExisting.Text);
            ID.ExcessShortfall = txt_MmiCurrent.Text;
            ID.Comment = txt_MmiComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[10].ID);
            ID.InvestmentID = 11;
            ID.Maximum = Convert.ToDecimal(txt_LmfMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_LmfMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_LmfExisting.Text);
            ID.ExcessShortfall = txt_LmfCurrent.Text;
            ID.Comment = txt_LmfComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[11].ID);
            ID.InvestmentID = 12;
            ID.Maximum = Convert.ToDecimal(txt_SttMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_SttMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_SttExisting.Text);
            ID.ExcessShortfall = txt_SttCurrent.Text;
            ID.Comment = txt_SttComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();


            CD = dbcon.CategoryDetails.Find(Cat[2].ID);
            CD.Maximum = Convert.ToDecimal(txt_TIIIMax.Text);
            CD.Minimum = Convert.ToDecimal(txt_TIIIMin.Text);
            CD.TotalCatValue = Convert.ToDecimal(txt_TIIIExisting.Text);
            CD.Status = txt_TIIICurrent.Text;
            CD.Comment = txt_TIIIComment.Text;
            dbcon.CategoryDetails.Add(CD);
            dbcon.Entry(CD).State = EntityState.Modified;
            dbcon.SaveChanges();

            //Category 4th
            ID = dbcon.InvestmentDetails.Find(value[12].ID);
            ID.InvestmentID = 13;
            ID.Maximum = Convert.ToDecimal(txt_EsMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_EsMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_EsExisting.Text);
            ID.ExcessShortfall = txt_EsCurrent.Text;
            ID.Comment = txt_EsComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[13].ID);
            ID.InvestmentID = 14;
            ID.Maximum = Convert.ToDecimal(txt_EmfMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_EmfMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_EmfExisting.Text);
            ID.Comment = txt_EmfComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[14].ID);
            ID.InvestmentID = 15;
            ID.Maximum = Convert.ToDecimal(txt_EifMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_EifMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_EifExisting.Text);
            ID.ExcessShortfall = txt_EifCurrent.Text;
            ID.Comment = txt_EifComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[15].ID);
            ID.InvestmentID = 16;
            ID.Maximum = Convert.ToDecimal(txt_EiSebiMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_EiSebiMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_EiSebiExisting.Text);
            ID.ExcessShortfall = txt_EiSebiCurrent.Text;
            ID.Comment = txt_EiSebiComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[16].ID);
            ID.InvestmentID = 17;
            ID.Maximum = Convert.ToDecimal(txt_EdMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_EdMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_EdExisting.Text);
            ID.ExcessShortfall = txt_EdCurrent.Text;
            ID.Comment = txt_EdComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();


            CD = dbcon.CategoryDetails.Find(Cat[3].ID);
            CD.Maximum = Convert.ToDecimal(txt_TVIMax.Text);
            CD.Minimum = Convert.ToDecimal(txt_TVIMin.Text);
            CD.TotalCatValue = Convert.ToDecimal(txt_TVIExisting.Text);
            CD.Status = txt_TVICurrent.Text;
            CD.Comment = txt_TVIComment.Text;
            dbcon.CategoryDetails.Add(CD);
            dbcon.Entry(CD).State = EntityState.Modified;
            dbcon.SaveChanges();

            //Category5
            ID = dbcon.InvestmentDetails.Find(value[17].ID);
            ID.InvestmentID = 18;
            ID.Maximum = Convert.ToDecimal(txt_CmMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_CmMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_CmExisting.Text);
            ID.ExcessShortfall = txt_CmCurrent.Text;
            ID.Comment = txt_CmComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[18].ID);
            ID.InvestmentID = 19;
            ID.Maximum = Convert.ToDecimal(txt_ReitMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_ReitMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_ReitExisting.Text);
            ID.ExcessShortfall = txt_ReitCurrent.Text;
            ID.Comment = txt_ReitComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();


            ID = dbcon.InvestmentDetails.Find(value[19].ID);
            ID.InvestmentID = 20;
            ID.Maximum = Convert.ToDecimal(txt_AbsMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_AbsMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_AbsExisting.Text);
            ID.ExcessShortfall = txt_AbsCurrent.Text;
            ID.Comment = txt_AbsComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            ID = dbcon.InvestmentDetails.Find(value[20].ID);
            ID.InvestmentID = 21;
            ID.Maximum = Convert.ToDecimal(txt_IiTMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_IiTMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_IiTExisting.Text);
            ID.ExcessShortfall = txt_IiTCurrent.Text;
            ID.Comment = txt_IiTComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.Entry(ID).State = EntityState.Modified;
            dbcon.SaveChanges();

            CD = dbcon.CategoryDetails.Find(Cat[4].ID);
            CD.Maximum = Convert.ToDecimal(txt_TVMax.Text);
            CD.Minimum = Convert.ToDecimal(txt_TVMin.Text);
            CD.TotalCatValue = Convert.ToDecimal(txt_TVCurrent.Text);
            CD.Status =txt_TVCurrent.Text;
            CD.Comment =txt_TVComment.Text;
            dbcon.CategoryDetails.Add(CD);
            dbcon.Entry(CD).State = EntityState.Modified;
            dbcon.SaveChanges();



        }
        void savedata()
        {


            var value = (from p in dbcon.TrustDetails
                         where p.TrustName == lbl_Name.Content
                         select p.TrustID).SingleOrDefault();
            InvestmentDetail ID = new InvestmentDetail();
            CategoryDetail CD = new CategoryDetail();

            //Category I
            ID.InvestmentID = 1;
            ID.Maximum = Convert.ToDecimal(txt_GoiMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_GoiMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_GoiCurrent.Text);
            ID.ExcessShortfall = txt_GoiStatus.Text;
            ID.TrustID = value;
            ID.Comment = txt_GoiComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();

            ID.InvestmentID = 2;
            ID.Maximum = Convert.ToDecimal(txt_GGSMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_GGsMini.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_GGSExisting.Text);
            ID.ExcessShortfall = txt_GGSStatus.Text;
            ID.TrustID = value;
            ID.Comment = txt_GGSComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();

            ID.InvestmentID = 3;
            ID.Maximum = Convert.ToDecimal(txt_GiltMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_GiltMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_GiltCurrent.Text);
            ID.ExcessShortfall = txt_GiltStatus.Text;
            ID.TrustID = value;
            ID.Comment = txt_GiltComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();

            CD.Maximum = Convert.ToDecimal(txt_TIMax.Text);
            CD.Minimum = Convert.ToDecimal(txt_TIMin.Text);
            CD.TotalCatValue = Convert.ToDecimal(txt_TICurrent.Text);
            CD.Status = txt_TIStatus.Text;
            CD.Comment = txt_TIComment.Text;
            CD.TrustID = value;
            CD.CategoryID = 1;
            dbcon.CategoryDetails.Add(CD);
            dbcon.SaveChanges();


            //Category II
            ID.InvestmentID = 4;
            ID.Maximum = Convert.ToDecimal(txt_BcbMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_BcbMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_BcbExisting.Text);
            ID.ExcessShortfall = txt_BcbCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_bcbComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();

            ID.InvestmentID = 5;
            ID.Maximum = Convert.ToDecimal(txt_BbMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_BbMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_BbExisting.Text);
            ID.ExcessShortfall = txt_BbCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_BbComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();

            ID.InvestmentID = 6;
            ID.Maximum = Convert.ToDecimal(txt_RbMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_RbMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_RbExisting.Text);
            ID.ExcessShortfall = txt_RbCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_RbComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();

            ID.InvestmentID = 7;
            ID.Maximum = Convert.ToDecimal(txt_TibMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_TibMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_TibExisting.Text);
            ID.ExcessShortfall = txt_TibCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_Comment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();

            ID.InvestmentID = 8;
            ID.Maximum = Convert.ToDecimal(txt_DmfMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_DmfMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_DmfExisting.Text);
            ID.ExcessShortfall = txt_DmfCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_DmfComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();

            ID.InvestmentID = 9;
            ID.Maximum = Convert.ToDecimal(txt_IdiMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_IdiMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_IdiExisting.Text);
            ID.ExcessShortfall = txt_IdiCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_IdiComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();

            CD.Maximum = Convert.ToDecimal(txt_TIIMax.Text);
            CD.Minimum = Convert.ToDecimal(txt_TIIMin.Text);
            CD.TotalCatValue = Convert.ToDecimal(txt_TIIExisting.Text);
            CD.Status = txt_TIICurrent.Text;
            CD.Comment = txt_TIIComment.Text;
            CD.TrustID = value;
            CD.CategoryID = 2;
            dbcon.CategoryDetails.Add(CD);
            dbcon.SaveChanges();

            // Cetegory III
            ID.InvestmentID = 10;
            ID.Maximum = Convert.ToDecimal(txt_MmiMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_MmiMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_MmiExisting.Text);
            ID.ExcessShortfall = txt_MmiCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_MmiComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();

            ID.InvestmentID = 11;
            ID.Maximum = Convert.ToDecimal(txt_LmfMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_LmfMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_LmfExisting.Text);
            ID.ExcessShortfall = txt_LmfCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_LmfComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();

            ID.InvestmentID = 12;
            ID.Maximum = Convert.ToDecimal(txt_SttMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_SttMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_SttExisting.Text);
            ID.ExcessShortfall = txt_SttCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_SttComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();



            CD.Maximum = Convert.ToDecimal(txt_TIIIMax.Text);
            CD.Minimum = Convert.ToDecimal(txt_TIIIMin.Text);
            CD.TotalCatValue = Convert.ToDecimal(txt_TIIIExisting.Text);
            CD.Status = txt_TIIICurrent.Text;
            CD.Comment = txt_TIIIComment.Text;
            CD.TrustID = value;
            CD.CategoryID = 3;
            dbcon.CategoryDetails.Add(CD);
            dbcon.SaveChanges();

            //Category 4th
            ID.InvestmentID = 13;
            ID.Maximum = Convert.ToDecimal(txt_EsMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_EsMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_EsExisting.Text);
            ID.ExcessShortfall = txt_EsCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_EsComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();

            ID.InvestmentID = 14;
            ID.Maximum = Convert.ToDecimal(txt_EmfMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_EmfMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_EmfExisting.Text);
            ID.ExcessShortfall = txt_EmfCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_EmfComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();


            ID.InvestmentID = 15;
            ID.Maximum = Convert.ToDecimal(txt_EifMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_EifMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_EifExisting.Text);
            ID.ExcessShortfall = txt_EifCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_EifComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();


            ID.InvestmentID = 16;
            ID.Maximum = Convert.ToDecimal(txt_EiSebiMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_EiSebiMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_EiSebiExisting.Text);
            ID.ExcessShortfall = txt_EiSebiCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_EiSebiComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();


            ID.InvestmentID = 17;
            ID.Maximum = Convert.ToDecimal(txt_EdMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_EdMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_EdExisting.Text);
            ID.ExcessShortfall = txt_EdCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_EdComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();



            CD.Maximum = Convert.ToDecimal(txt_TVIMax.Text);
            CD.Minimum = Convert.ToDecimal(txt_TVIMin.Text);
            CD.TotalCatValue = Convert.ToDecimal(txt_TVIExisting.Text);
            CD.Status = txt_TVICurrent.Text;
            CD.Comment = txt_TVIComment.Text;
            CD.TrustID = value;
            CD.CategoryID = 4;
            dbcon.CategoryDetails.Add(CD);
            dbcon.SaveChanges();

            //Category5

            ID.InvestmentID = 18;
            ID.Maximum = Convert.ToDecimal(txt_CmMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_CmMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_CmExisting.Text);
            ID.ExcessShortfall = txt_CmCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_CmComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();

            ID.InvestmentID = 19;
            ID.Maximum = Convert.ToDecimal(txt_ReitMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_ReitMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_ReitExisting.Text);
            ID.ExcessShortfall = txt_ReitCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_ReitComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();


            ID.InvestmentID = 20;
            ID.Maximum = Convert.ToDecimal(txt_AbsMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_AbsMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_AbsExisting.Text);
            ID.ExcessShortfall = txt_AbsCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_AbsComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();

            ID.InvestmentID = 21;
            ID.Maximum = Convert.ToDecimal(txt_IiTMax.Text);
            ID.Minimum = Convert.ToDecimal(txt_IiTMin.Text);
            ID.InvestmentValue = Convert.ToDecimal(txt_IiTExisting.Text);
            ID.ExcessShortfall = txt_IiTCurrent.Text;
            ID.TrustID = value;
            ID.Comment = txt_IiTComment.Text;
            dbcon.InvestmentDetails.Add(ID);
            dbcon.SaveChanges();


            CD.Maximum = Convert.ToDecimal(txt_TVMax.Text);
            CD.Minimum = Convert.ToDecimal(txt_TVMin.Text);
            CD.TotalCatValue = Convert.ToDecimal(txt_TVExisting.Text);
            CD.Status = txt_TVCurrent.Text;
            CD.Comment = txt_TVComment.Text;
            CD.TrustID = value;
            CD.CategoryID = 5;
            dbcon.CategoryDetails.Add(CD);
            dbcon.SaveChanges();
        }

     

        private void txt_TIIExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                if (txt_TIIExisting.Text.Trim()!= "")
                {
                    txt_TIICurrent.Text= StatusTest(txt_TIIMax.Text, txt_TIIMin.Text,txt_TIIExisting.Text);
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void txt_TVIExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                if (txt_TVIExisting.Text.Trim()!= "")
                {
                    txt_TVICurrent.Text = StatusTest(txt_TVIMax.Text, txt_TVIMin.Text,txt_TVIExisting.Text);
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        private void txt_TIIIExisting_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                if (txt_TIIExisting.Text.Trim() != "")
                {
                    txt_TIIICurrent.Text = StatusTest(txt_TIIIMax.Text, txt_TIIIMin.Text, txt_TIIIExisting.Text);
                }
            }
            catch (Exception ex)
            {
              
            }

        }

      
        private void Cal_window_Loaded(object sender, RoutedEventArgs e)
        {
            lbl_Name.Content = trustName;
            if (Flag == true)
            {
                btn_Submit.Content = "Update";
                update = true;
                loaddata();
            }
            else
            {

                var value = (from p in dbcon.TrustDetails
                             where p.TrustName == lbl_Name.Content
                             select p.TrustID).SingleOrDefault();
                Global.trustID = value;
            }
        }
    }
}
