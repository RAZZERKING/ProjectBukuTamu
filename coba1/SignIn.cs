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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btn_back_MouseHover(object sender, EventArgs e)
        {
            btn_back.BackColor = Color.White;
            btn_back.ForeColor = Color.Black;
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.BackColor = Color.Black;
            btn_back.ForeColor = Color.White;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.White;
            btnLogin.ForeColor = Color.Black;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor= Color.White;
            btnLogin.BackColor = Color.Black;
        }
    }
}
