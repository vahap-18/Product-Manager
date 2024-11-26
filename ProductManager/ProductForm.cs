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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        EntityProductDBEntities db = new EntityProductDBEntities();

        void List()
        {
            var product = (from x in db.TblProduct
                           select new
                           {
                               x.Id,
                               x.Name,
                               x.Price,
                               x.Stok,
                               x.Station,
                               CategoryName = x.TblCategory.Name
                           }).ToList();
            dataGridView1.DataSource = product;
        }

        void Clear()
        {
            tbId.Text = string.Empty;
            tbName.Text = string.Empty;
            tbPrice.Text = string.Empty;
            tbStock.Text = string.Empty;
            tbStation.Text = string.Empty;
            comboCategory.SelectedIndex = -1;
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            List();
            var category = (from x in db.TblCategory
                            select new
                            {
                                x.Id,
                                x.Name
                            }).ToList();
            comboCategory.ValueMember = "Id";
            comboCategory.DisplayMember = "Name";
            comboCategory.DataSource = category;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
            this.Hide();
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblProduct product = new TblProduct();
            product.Name = tbName.Text;
            product.Stok = Convert.ToInt16(tbStock.Text);
            product.Price = Convert.ToInt64(tbPrice.Text);
            product.Station = true;
            product.CategoryId = Convert.ToInt32(comboCategory.SelectedValue.ToString());

            db.TblProduct.Add(product);
            db.SaveChanges();
            lblStation.Text = $"{tbName.Text} eklendi";
            List();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int del = Convert.ToInt32(tbId.Text);
            var product = db.TblProduct.Find(del);
            db.TblProduct.Remove(product);
            db.SaveChanges();

            lblStation.Text = $"{tbName.Text} silindi.";
            List();
            Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbId.Text = dataGridView1.Rows[secilen].Cells[0].Value?.ToString() ?? "";
            tbName.Text = dataGridView1.Rows[secilen].Cells[1].Value?.ToString() ?? "";
            tbStock.Text = dataGridView1.Rows[secilen].Cells[3].Value?.ToString() ?? "";
            tbPrice.Text = dataGridView1.Rows[secilen].Cells[2].Value?.ToString() ?? "";
            tbDurum.Text = dataGridView1.Rows[secilen].Cells[4].Value != null &&
                 (bool)dataGridView1.Rows[secilen].Cells[4].Value == true
                 ? "Var"
                 : "Yok";
            var selectedValue = dataGridView1.Rows[secilen].Cells[5].Value?.ToString();

            foreach (var item in comboCategory.Items)
            {
                if (item.ToString() == selectedValue)
                {
                    comboCategory.SelectedItem = item;
                    break;
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int edit = Convert.ToInt32(tbId.Text);
            var product = db.TblProduct.Find(edit);
            product.Name = tbName.Text;
            product.Stok = Convert.ToInt16(tbStock.Text);
            product.Price = Convert.ToInt64(tbPrice.Text);
            product.Station = Convert.ToBoolean(tbStation.Text);
            product.CategoryId = Convert.ToInt32(comboCategory.SelectedValue.ToString());

        }
    }
}
