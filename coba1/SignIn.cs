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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            if(auth.AuthUser(txt_username.Text, txt_password.Text))
            {
                UserController userController = new UserController();
                User user = userController.getUserByUsername(txt_username.Text);
                AdminDashboard adminDashboard = new AdminDashboard(user.username, user.isAuth);
                adminDashboard.Show();
                this.Hide();
            }
        }
    }
}
