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
                // Initialize the user object
            try
            {
                bool add = userController.createNewUser(txt_username.Text, txt_name.Text, txt_password.Text, txt_contact.Text);
                if (!add)
                {
                    MessageBox.Show("Data gagal disimpan!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Close();
                
                MessageBox.Show("Data berhasil disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
           
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
