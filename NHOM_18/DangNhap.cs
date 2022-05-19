using System;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtbTenDN.AutoSize = false;
            this.txtbTenDN.Size = new System.Drawing.Size(240, 20);
            this.txtbMatKhau.AutoSize = false;
            this.txtbMatKhau.Size = new System.Drawing.Size(240, 20);
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string NhanVien = "NhanVien";
            string Admin = "Admin";
            string pass = "123456";
            HomeNV homeNV = new HomeNV();
            HomeAd homeAD = new HomeAd();
            if (txtbTenDN.Text != null && txtbMatKhau.Text != null)
            {
                if (txtbTenDN.Text == NhanVien && txtbMatKhau.Text == pass)
                {
                    this.Hide();
                    homeNV.ShowDialog();
                    this.Close();
                }
                else if(txtbTenDN.Text == Admin && txtbMatKhau.Text == pass)
                {
                    this.Hide();
                    homeAD.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ten Hoac Mat Khau Khong Dung");
                }
            }
            else
            {
                if (txtbTenDN.Text != null)
                {
                    MessageBox.Show("Ten Dang Nhap Khong Duoc De Trong");
                }
                else if (txtbMatKhau.Text != null)
                {
                    MessageBox.Show("Mat Khau khong duoc de trong");
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtbMatKhau_TextChanged(object sender, EventArgs e)
        {
            this.txtbMatKhau.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.lblDN.BackColor = Color.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdNhanVien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdAdmin_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
