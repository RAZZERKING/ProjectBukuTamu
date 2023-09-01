using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coba1
{
    public partial class AdminUser : Form
    {
        public AdminUser()
        {
            InitializeComponent();
        }
        UserController userController = new UserController();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_guest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string user_id = dgv_user.Rows[row].Cells["user_id"].Value.ToString();
           
        }

        private void AdminUser_Load(object sender, EventArgs e)
        {
            bool display = userController.displayUserData(dgv_user);
            if (!display)
            {
                MessageBox.Show("Tidak Ada Data User", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserADD add = new UserADD();
            add.Show();
            add.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserEdit edit = new UserEdit();
            edit.Show();
            edit.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
