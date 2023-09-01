using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coba1
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard(string username, bool isAuth)
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminGuest adminGuest = new AdminGuest();
            adminGuest.Show();
            this.Hide();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            AdminUser adminUser = new AdminUser();
            adminUser.Show();
            this.Hide();
        }
    }
}
