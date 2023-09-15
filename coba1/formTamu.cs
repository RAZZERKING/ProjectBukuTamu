using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace coba1
{
    public partial class formTamu : Form
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice videoSource;
        public formTamu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoSource.SignalToStop();
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Hide();

        }
        void mulaiKamera()
        {
            if(videoSource.IsRunning) {
            
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
            videoSource = new VideoCaptureDevice(captureDevice[comboBoxWebcamList.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }
        bool simpanFoto()
        {
            string targetFolder = Application.StartupPath + "/foto_tamu/";

            if (!Directory.Exists(targetFolder))
            {
                MessageBox.Show("Folder tujuan tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string fileName = "foto_tamu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".jpg";// Nama file dengan format timestamp
            try
            {
                string filePath = Path.Combine(targetFolder, txt_fotoTamu.Text);
                pictureBox2.Image.Save(filePath, ImageFormat.Jpeg);
                return true;
                //MessageBox.Show("Foto berhasil disimpan di folder tujuan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception)
            {
                MessageBox.Show("ada yang salah dengan kamera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void clearForm(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox textBox)
                {
                    textBox.Clear();
                }

                if (c.HasChildren)
                {
                    clearForm(c);
                }
            }
        }


        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void formTamu_Load(object sender, EventArgs e)
        {
            dateTamu.Value = DateTime.Now;
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo deviceList in captureDevice)
            {
                comboBoxWebcamList.Items.Add(deviceList.Name);


            }
            comboBoxWebcamList.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
            mulaiKamera();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "foto_tamu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".jpg";
                txt_fotoTamu.Text = fileName;
                if((Bitmap)pictureBox1.Image == null){
                    MessageBox.Show("ada yang salah dengan kamera", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
                }
            }catch(Exception)
            {
                MessageBox.Show("ada yang salah dengan kamera", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //simpanFoto();
            GuestController guestController = new GuestController();
            try
            {
                bool createNewGuest = guestController.createNewGuest(txt_namaTamu.Text, txt_instansiTamu.Text, txt_contactTamu.Text, dateTamu.Value.ToString("yyyy-MM-dd HH:mm:ss"), txt_keperluanTamu.Text, txt_penerimaTamu.Text, txt_fotoTamu.Text);
                if (createNewGuest && simpanFoto())
                {
                    //guestController.createNewGuest(txt_namaTamu.Text, txt_instansiTamu.Text, txt_contactTamu.Text, dateTamu.Value.ToString("yyyy-MM-dd HH:mm:ss"), txt_keperluanTamu.Text, txt_penerimaTamu.Text, txt_fotoTamu.Text
                    MessageBox.Show("data berhasil dimasukkan \n Selamat Datang", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForm(this);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxWebcamList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mulaiKamera();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearForm(this);
        }

        private void formTamu_FormClosed(object sender, FormClosedEventArgs e)
        {
            videoSource.SignalToStop();
        }

        private void formTamu_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoSource.SignalToStop();
        }
    }
}
