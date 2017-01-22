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
    public partial class TrustList : Form
    {
        TrustCalculatorEntities dbcon = new TrustCalculatorEntities();

        public TrustList()
        {
            InitializeComponent();
        }

        private void TrustList_Load(object sender, EventArgs e)
        {
            var value = (from p in dbcon.TrustDetails orderby p.TrustID  descending
                         select new
                         {
                             TrustName = p.TrustName,
                             TotalCorpus=p.Total_Corps,
                             Advance=p.Advances,
                             PanNo = p.PanNo,
                             ContactPerson = p.ContPerson,
                             PhoneNo = p.PhoneNo
                         }
                         ).Take(10).ToList();
            dgv_Detail.DataSource = value;
          

        }

        private void dgv_Detail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Calculator cal = new Calculator(dgv_Detail.CurrentRow.Cells[0].Value.ToString(), true);
            cal.Show();

        }

        private void dgv_Detail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var results = (from p in dbcon.TrustDetails
                          where p.TrustName.Contains(txt_TrustName.Text)
                          select new
                          {
                              TrustName = p.TrustName,
                              TotalCorpus = p.Total_Corps,
                              Advance = p.Advances,
                              PanNo = p.PanNo,
                              ContactPerson = p.ContPerson,
                              PhoneNo = p.PhoneNo
                          }).ToList();
            dgv_Detail.DataSource =results;

        }
    }
}
