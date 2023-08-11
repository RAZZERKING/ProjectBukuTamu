using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coba1
{
    internal class Auth 
    { 
        public bool validatePassword(string HashPassword, string inputPassword)
        {
            //return BCrypt.Net.BCrypt.Verify(inputPassword, HashPassword);
            return HashPassword == inputPassword;
        }

        public bool AuthUser(string username, string password)
        {
            UserController databaseHelper = new UserController();
            if (databaseHelper.isUsernameExist(username))
            {
                User user = databaseHelper.getUserByUsername(username);
                if (validatePassword(password, user.password))
                {
                    user.isAuth = true;
                    MessageBox.Show($"selamat datang {user.name}", "login berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            MessageBox.Show("username tidak ditemukan");
            return false;
        }
    }
}
