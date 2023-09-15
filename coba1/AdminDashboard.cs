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
        bool isSideBarExpand = true;
        bool isChildFilled = false;
        private AdminUser adminUser = new AdminUser();
        private AdminGuest AdminGuest = new AdminGuest();
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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximized_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btn_maximized.Image = Properties.Resources.icons8_maximize_window_50;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                btn_maximized.Image = Properties.Resources.icons8_restore_window_50;
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void time_sidebar_Tick(object sender, EventArgs e)
        {
            if(isSideBarExpand)
            {
                sidebar.Width -= 15;
                childForm.Width += 15;
                if(sidebar.Width <= 88)
                {
                    isSideBarExpand = false;
                    time_sidebar.Stop();
                }
            }
            else
            {
                sidebar.Width += 15;
                childForm.Width -= 15;
                if (sidebar.Width >= 216)
                {
                    isSideBarExpand = true;
                    time_sidebar.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            time_sidebar.Start();
        }

        private void removeChildForm()
        {
            foreach(Control control in childForm.Controls)
            {
                childForm.Controls.Remove(control);
            }
            isChildFilled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isChildFilled)
            {
                if (childForm.Controls.Contains(adminUser))
                {
                    childForm.Controls.Remove(adminUser);
                    adminUser.Dispose();
                    isChildFilled=false;
                    return;
                }
                else if (childForm.Controls.Contains(AdminGuest))
                {
                    childForm.Controls.Remove(AdminGuest);
                    AdminGuest.Dispose();
                    showAdminUser();
                    isChildFilled=true;
                    return;
                }
            }
            showAdminUser();
        }

        void showAdminUser()
        {
            adminUser = new AdminUser();
            adminUser.TopLevel = false;
            if (adminUser.Parent != null)
            {
                adminUser.Parent.Controls.Remove(adminUser);
            }
            childForm.Controls.Add(adminUser);
            adminUser.Dock = DockStyle.Fill;
            adminUser.Show();
            isChildFilled = true;
        }

        void showAdminGuest()
        {
            AdminGuest = new AdminGuest();
            AdminGuest.TopLevel = false;
            if (AdminGuest.Parent != null)
            {
                AdminGuest.Parent.Controls.Remove(AdminGuest);
            }
            childForm.Controls.Add(AdminGuest);
            AdminGuest.Dock = DockStyle.Fill;
            AdminGuest.Show();
            isChildFilled = true;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isChildFilled)
            {
                if (childForm.Controls.Contains(adminUser))
                {
                    childForm.Controls.Remove(adminUser);
                    adminUser.Dispose();
                    showAdminGuest();
                    isChildFilled = true;
                    return;
                }
                else if (childForm.Controls.Contains(AdminGuest))
                {
                    childForm.Controls.Remove(AdminGuest);
                    AdminGuest.Dispose();
                    isChildFilled = false;
                    return;
                }
            }
            showAdminGuest();
        }
    }
}
