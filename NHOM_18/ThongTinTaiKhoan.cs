﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ThongTinTaiKhoan : Form
    {
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Da luu ");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAd mnuNguoiDung = new HomeAd();
            mnuNguoiDung.ShowDialog();
            this.Close();
        }
    }
}
