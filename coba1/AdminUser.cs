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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace coba1
{
    public partial class AdminUser : Form
    {
        public AdminUser()
        {
            InitializeComponent();
        }

        UserController userController = new UserController();
        User user;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_guest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
            this.Hide();
            UserADD add = new UserADD();
            add.ShowDialog();
            this.Show();
            bool display = userController.displayUserData(dgv_user);
            if (!display)
            {
                MessageBox.Show("Tidak Ada Data User", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv_user.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_user.SelectedRows[0];
                string username = selectedRow.Cells["username"].Value.ToString();
           
                MessageBox.Show("Selected Username: " + username);
                
                user = userController.getUserByUsername(username);

                if (user != null)
                {
                    UserEdit userEditForm = new UserEdit(user);
                    userEditForm.Show();
                }
                else
                {
                    MessageBox.Show("Data User tidak ditemukan!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Tidak ada data yang dipilih!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }





        private void button2_Click(object sender, EventArgs e)
        {
            bool delete = userController.deleteUser(user.id);
            if (delete)
            {
                bool display = userController.displayUserData(dgv_user);
                if (!display)
                {
                    MessageBox.Show("Tidak Ada Data User", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                MessageBox.Show("Data berhasil dihapus!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_user.Refresh();
            }
            else
            {
                MessageBox.Show("Data gagal dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dgv_user.Refresh();
        }

        private void txt_username_Click(object sender, EventArgs e)
        {

        }

        private void txt_userId_Click(object sender, EventArgs e)
        {

        }

        private void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string user_id = dgv_user.Rows[row].Cells["username"].Value.ToString();
            user = userController.getUserByUsername(user_id);
            if (user != null)
            {
                txt_userId.Text = user.id;
                txt_userId.Visible = true;
                txt_username.Text = user.username;
                txt_username.Visible = true;
                txt_name.Text = user.name;
                txt_name.Visible = true;
                txt_contact.Text = user.contact;
                txt_contact.Visible = true;
            }

        }

        private void dgv_user_SelectionChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            bool display = userController.displayUserData(dgv_user);
            if (!display)
            {
                MessageBox.Show("Tidak Ada Data User", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           
            (dgv_user.DataSource as DataTable).DefaultView.RowFilter =
               String.Format("username like '%" + txt_cari.Text + "%'");
           

        }
    }
}
