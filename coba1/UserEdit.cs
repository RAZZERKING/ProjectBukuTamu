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
        
        UserController userController = new UserController();
        User user;
        public UserEdit(User user)
        {
            InitializeComponent();
            this.user = user;
            txt_username.Text = user.username;
            txt_name.Text = user.name;
            txt_contact.Text = user.contact;
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            if (user != null) 
            {
                txt_username.Text = user.username;
                txt_username.Visible = true;
                txt_name.Text = user.name;
                txt_name.Visible = true;
                txt_contact.Text = user.contact;
                txt_contact.Visible = true;
            }
            else
            {
                
                MessageBox.Show("Data user tidak tersedia.");
            }
        }

        private void txt_instansiTamu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string name = txt_name.Text;
            string contact = txt_contact.Text;

            bool update = userController.updateUser(user.id, username, name, contact);
            if(!update)
            {
                MessageBox.Show("Data gagal diupdate", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }              
            MessageBox.Show("Data berhasil diupdate!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
           
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
