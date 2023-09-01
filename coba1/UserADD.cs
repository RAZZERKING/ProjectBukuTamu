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
    public partial class UserADD : Form
    {
        public UserADD()
        {
            InitializeComponent();
        }
        UserController userController = new UserController();
        User user;
        private void btn_update_Click(object sender, EventArgs e)
        {
            bool add = userController.createNewUser(user.id, txt_name.Text, txt_name.Text, txt_password.Text, txt_contact.Text);
            if (add)
            {
                MessageBox.Show("Data berhasil disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data gagal disimpan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
