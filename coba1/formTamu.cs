﻿using System;
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
            
            mainMenu login = new mainMenu();
            login.Show();
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
        void simpanFoto()
        {
            string targetFolder = Application.StartupPath + "/foto_tamu/";

            if (!Directory.Exists(targetFolder))
            {
                MessageBox.Show("Folder tujuan tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fileName = "foto_tamu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".jpg";// Nama file dengan format timestamp
            try
            {
                string filePath = Path.Combine(targetFolder, txt_fotoTamu.Text);
                pictureBox2.Image.Save(filePath, ImageFormat.Jpeg);
                MessageBox.Show("Foto berhasil disimpan di folder tujuan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show("ada yang salah dengan kamera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }catch(Exception ex)
            {
                MessageBox.Show("ada yang salah dengan kamera", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            simpanFoto();
        }

        private void comboBoxWebcamList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mulaiKamera();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
