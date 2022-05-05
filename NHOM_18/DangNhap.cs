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
            string user = "abc";
            string pass = "123456";
            HomeNV homeNv = new HomeNV(); 
            HomeAd homead = new HomeAd(); 
            if (user.Equals(txtbTenDN.Text) && pass.Equals(txtbMatKhau.Text))
            {
                if (rdNhanVien.Checked)
                {
                    
                    this.Hide();
                    homeNv.Show();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    homead.Show();
                    this.Close();
                }
                MessageBox.Show("Dang nhap thanh cong");
            }
            else
                MessageBox.Show("Sai thong tin vui long nhap lai");

        }

        private void txtbTenDN_TextChanged(object sender, EventArgs e)
        {

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
