using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;


namespace ProductManager
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        EntityProductDBEntities db = new EntityProductDBEntities();

        void List()
        {
            var categories = (from x in db.TblCategory
                              select new
                              {
                                  x.Id,
                                  x.Name
                              }).ToList();
            dataGridView1.DataSource = categories;
        }

        void Clear()
        {
            tbName.Text = string.Empty;
            tbId.Text = string.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tbName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblCategory addCategory = new TblCategory();
            addCategory.Name = tbName.Text;
            db.TblCategory.Add(addCategory);
            db.SaveChanges();
            lblStation.Text = $"{tbName.Text} eklendi"; 
            List();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int del = Convert.ToInt32(tbId.Text);
            var delCategory = db.TblCategory.Find(del);
            db.TblCategory.Remove(delCategory);
            db.SaveChanges();
            lblStation.Text = $"{tbName.Text} silindi";
            List();
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int edit = Convert.ToInt32(tbId.Text);
            var editCategory = db.TblCategory.Find(edit);
            editCategory.Name = tbName.Text;
            db.SaveChanges();
            lblStation.Text = $"{tbName.Text} güncellendi";
            List();
            Clear();

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
            this.Hide();
        }
    }
}
