﻿using System;
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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_tamu_Click(object sender, EventArgs e)
        {

            formTamu log = new formTamu();
            log.Show(); 
            this.Hide();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.AuthUser(txt_username.Text, txt_password.Text);

        }
    }
}
