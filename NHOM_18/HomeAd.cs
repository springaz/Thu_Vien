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
    public partial class HomeAd : Form
    {
        public HomeAd()
        {
            InitializeComponent();
        }

        private void lblMain_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form7 mnuDocGia = new Form7();
            mnuDocGia.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }






        private void picProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void gbLich_Enter(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            QuanLyBaoCao thongke = new QuanLyBaoCao();
            thongke.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeAd homead = new HomeAd();
            homead.Show();
        }
      

        private void btnSach_Click(object sender, EventArgs e)
        {
            Form3 quanlysach = new Form3();
            quanlysach.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 mnuPhieuTra = new Form8();
            mnuPhieuTra.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Quanlytacc taikhoan = new Quanlytacc();
            taikhoan.Show();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            this.Hide();
            dangnhap.ShowDialog();
            this.Close();
        }
    }
    }

