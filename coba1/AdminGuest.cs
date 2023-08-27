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
    public partial class AdminGuest : Form
    {
        public AdminGuest()
        {
            InitializeComponent();
        }
        GuestController guestController = new GuestController();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminGuest_Load(object sender, EventArgs e)
        {
            bool display = guestController.displayGuestData(dgv_guest);
            if (!display)
            {
                MessageBox.Show("Tidak Ada Data Tamu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_guest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string guest_id = dgv_guest.Rows[row].Cells["guest_id"].Value.ToString();
            string imagePath = Application.StartupPath + "/foto_tamu/";
            Guest guest = guestController.getGuestData(guest_id);
            if (guest != null)
            {
                txt_guestId.Text = guest.id;
                txt_guestId.Visible = true;
                txt_name.Text = guest.name;
                txt_name.Visible = true;
                txt_instansi.Text = guest.instansi;
                txt_instansi.Visible = true;
                txt_contact.Text = guest.contact;
                txt_contact.Visible = true;
                txt_keperluan.Text = guest.keperluan;
                txt_keperluan.Visible = true;
                txt_penerimaTamu.Text = guest.penerimaTamu;
                txt_penerimaTamu.Visible = true;
                txt_date.Text = guest.date;
                txt_date.Visible = true;
                //string path = imagePath + guest.foto;
                pct_guest.Image = Image.FromFile(Path.Combine(imagePath, guest.foto));
            }
        }
    }
}
