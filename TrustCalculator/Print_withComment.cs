using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrustCalculator
{
    public partial class Print_withComment : Form
    {
        TrustCalculatorEntities dbcon = new TrustCalculatorEntities();
        int Trust;
        public Print_withComment(string TrustName)
        {
            InitializeComponent();
            trustID(TrustName);
        }
        
        

        void trustID(string TrustName)
        {


            var value = (from p in dbcon.TrustDetails
                         where p.TrustName == TrustName
                         select p.TrustID
                            ).SingleOrDefault();
            Trust = value;
        }

        private void Print_withComment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TrustCalculatorDataSet.TrustDetail' table. You can move, or remove it, as needed.
            this.TrustDetailTableAdapter.Fill(this.TrustCalculatorDataSet.TrustDetail,Trust);
            // TODO: This line of code loads data into the 'TrustCalculatorDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.TrustCalculatorDataSet.DataTable1,Trust);
            // TODO: This line of code loads data into the 'TrustCalculatorDataSet.CategoryII' table. You can move, or remove it, as needed.
            this.CategoryIITableAdapter.Fill(this.TrustCalculatorDataSet.CategoryII,Trust);
            // TODO: This line of code loads data into the 'TrustCalculatorDataSet.CategoryIII' table. You can move, or remove it, as needed.
            this.CategoryIIITableAdapter.Fill(this.TrustCalculatorDataSet.CategoryIII,Trust);
            // TODO: This line of code loads data into the 'TrustCalculatorDataSet.CategoryIV' table. You can move, or remove it, as needed.
            this.CategoryIVTableAdapter.Fill(this.TrustCalculatorDataSet.CategoryIV,Trust);
            // TODO: This line of code loads data into the 'TrustCalculatorDataSet.CategoryV' table. You can move, or remove it, as needed.
            this.CategoryVTableAdapter.Fill(this.TrustCalculatorDataSet.CategoryV,Trust);
            // TODO: This line of code loads data into the 'TrustCalculatorDataSet.CategoryDetail' table. You can move, or remove it, as needed.
            this.CategoryDetailTableAdapter.Fill(this.TrustCalculatorDataSet.CategoryDetail,Trust);
            // TODO: This line of code loads data into the 'TrustCalculatorDataSet.CategoryDetailIII' table. You can move, or remove it, as needed.
            this.CategoryDetailIIITableAdapter.Fill(this.TrustCalculatorDataSet.CategoryDetailIII,Trust);
            // TODO: This line of code loads data into the 'TrustCalculatorDataSet.CategoryDetailII' table. You can move, or remove it, as needed.
            this.CategoryDetailIITableAdapter.Fill(this.TrustCalculatorDataSet.CategoryDetailII,Trust);
            // TODO: This line of code loads data into the 'TrustCalculatorDataSet.CategoryDetailIV' table. You can move, or remove it, as needed.
            this.CategoryDetailIVTableAdapter.Fill(this.TrustCalculatorDataSet.CategoryDetailIV,Trust);
            // TODO: This line of code loads data into the 'TrustCalculatorDataSet.CategoryDetailV' table. You can move, or remove it, as needed.
            this.CategoryDetailVTableAdapter.Fill(this.TrustCalculatorDataSet.CategoryDetailV,Trust);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
