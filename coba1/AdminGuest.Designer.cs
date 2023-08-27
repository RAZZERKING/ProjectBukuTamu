namespace coba1
{
    partial class AdminGuest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_guest = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pct_guest = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_penerimaTamu = new System.Windows.Forms.Label();
            this.txt_keperluan = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.Label();
            this.txt_instansi = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.Label();
            this.txt_guestId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_guest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_guest)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_guest
            // 
            this.dgv_guest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_guest.Location = new System.Drawing.Point(989, 52);
            this.dgv_guest.Name = "dgv_guest";
            this.dgv_guest.Size = new System.Drawing.Size(334, 513);
            this.dgv_guest.TabIndex = 0;
            this.dgv_guest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_guest_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(989, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1256, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pct_guest
            // 
            this.pct_guest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pct_guest.Location = new System.Drawing.Point(477, 20);
            this.pct_guest.Name = "pct_guest";
            this.pct_guest.Size = new System.Drawing.Size(497, 326);
            this.pct_guest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct_guest.TabIndex = 3;
            this.pct_guest.TabStop = false;
            this.pct_guest.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_penerimaTamu);
            this.groupBox1.Controls.Add(this.txt_keperluan);
            this.groupBox1.Controls.Add(this.txt_contact);
            this.groupBox1.Controls.Add(this.txt_instansi);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_guestId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 545);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guest Data";
            // 
            // txt_penerimaTamu
            // 
            this.txt_penerimaTamu.AutoSize = true;
            this.txt_penerimaTamu.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_penerimaTamu.Location = new System.Drawing.Point(219, 471);
            this.txt_penerimaTamu.Name = "txt_penerimaTamu";
            this.txt_penerimaTamu.Size = new System.Drawing.Size(46, 44);
            this.txt_penerimaTamu.TabIndex = 12;
            this.txt_penerimaTamu.Text = "A";
            this.txt_penerimaTamu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_penerimaTamu.Visible = false;
            // 
            // txt_keperluan
            // 
            this.txt_keperluan.AutoSize = true;
            this.txt_keperluan.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_keperluan.Location = new System.Drawing.Point(219, 386);
            this.txt_keperluan.Name = "txt_keperluan";
            this.txt_keperluan.Size = new System.Drawing.Size(46, 44);
            this.txt_keperluan.TabIndex = 11;
            this.txt_keperluan.Text = "A";
            this.txt_keperluan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_keperluan.Visible = false;
            // 
            // txt_contact
            // 
            this.txt_contact.AutoSize = true;
            this.txt_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(219, 301);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(46, 44);
            this.txt_contact.TabIndex = 10;
            this.txt_contact.Text = "A";
            this.txt_contact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_contact.Visible = false;
            // 
            // txt_instansi
            // 
            this.txt_instansi.AutoSize = true;
            this.txt_instansi.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_instansi.Location = new System.Drawing.Point(219, 216);
            this.txt_instansi.Name = "txt_instansi";
            this.txt_instansi.Size = new System.Drawing.Size(46, 44);
            this.txt_instansi.TabIndex = 9;
            this.txt_instansi.Text = "A";
            this.txt_instansi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_instansi.Visible = false;
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(219, 131);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(46, 44);
            this.txt_name.TabIndex = 8;
            this.txt_name.Text = "A";
            this.txt_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_name.Visible = false;
            // 
            // txt_guestId
            // 
            this.txt_guestId.AutoSize = true;
            this.txt_guestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guestId.Location = new System.Drawing.Point(219, 46);
            this.txt_guestId.Name = "txt_guestId";
            this.txt_guestId.Size = new System.Drawing.Size(46, 44);
            this.txt_guestId.TabIndex = 7;
            this.txt_guestId.Text = "A";
            this.txt_guestId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_guestId.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(170, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Penerima Tamu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(194, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Keperluan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(206, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(206, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Instansi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(212, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(203, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guest Id";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(477, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cari";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(883, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cari";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(680, 519);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "Cari";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_date);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(477, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 133);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TimeStamp";
            // 
            // txt_date
            // 
            this.txt_date.AutoSize = true;
            this.txt_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.txt_date.Location = new System.Drawing.Point(200, 53);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(89, 39);
            this.txt_date.TabIndex = 5;
            this.txt_date.Text = "Date";
            this.txt_date.Visible = false;
            // 
            // AdminGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pct_guest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_guest);
            this.Name = "AdminGuest";
            this.Text = "AdminGuest";
            this.Load += new System.EventHandler(this.AdminGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_guest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_guest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_guest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pct_guest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txt_guestId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_date;
        private System.Windows.Forms.Label txt_penerimaTamu;
        private System.Windows.Forms.Label txt_keperluan;
        private System.Windows.Forms.Label txt_contact;
        private System.Windows.Forms.Label txt_instansi;
        private System.Windows.Forms.Label txt_name;
    }
}