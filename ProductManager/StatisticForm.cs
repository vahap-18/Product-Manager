using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        EntityProductDBEntities db = new EntityProductDBEntities();
        private void btnHome_Click(object sender, EventArgs e)
        {
            AnaForm anaform = new AnaForm();
            anaform.Show();
            this.Hide();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            lblTotalCategory.Text = db.TblCategory.Count().ToString();
            lblTotalProduct.Text = db.TblProduct.Count().ToString();
            lblActiveCostumer.Text = db.TblCostumer.Where(c => c.Station == true).Count().ToString();
            lblPassiveCostumer.Text = db.TblCostumer.Where(c => c.Station == false).Count().ToString();
            lblWhiteGoods.Text = db.TblProduct.Count(p =>  p.CategoryId == 1).ToString();
            lblTotalStock.Text = db.TblProduct.Sum(p => p.Stok).ToString();
            lblHighedPriceProduct.Text = (from x in db.TblProduct orderby x.Price descending select x.Name).FirstOrDefault();
            lblLowestPriceProduct.Text = (from x in db.TblProduct orderby x.Price select x.Name).FirstOrDefault();
            lbltotalCity.Text =(from x in db.TblCostumer select x.City).Distinct().Count().ToString();
        }
    }
}
