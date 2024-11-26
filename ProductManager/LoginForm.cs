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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        EntityProductDBEntities db = new EntityProductDBEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var query = from x in db.TblAdmin where x.UserName == tbUserName.Text && x.Password == tbPassword.Text select x;
            if (query.Any())
            {
                AnaForm anaform = new AnaForm();
                anaform.Show();
                this.Hide();
            }
            else
            {
                lblDurum.Text = "Hatalı kullanıcı adı veya parola";
            }
        }
    }
}
