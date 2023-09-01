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
    public partial class UserEdit : Form
    {
        public UserEdit()
        {
            InitializeComponent();
        }
        private User user;
        public UserEdit(User user)
        {
            InitializeComponent();
             this.user = user;
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            txt_username.Text = user.username;
            txt_name.Text = user.name;
            txt_contact.Text = user.contact;


        }

        private void txt_instansiTamu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            bool update = userController.updateUser(user.id, txt_username.Text, txt_name.Text, txt_contact.Text);
            if(update)
            {
                MessageBox.Show("Data berhasil diupdate!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data gagal diupdate", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
