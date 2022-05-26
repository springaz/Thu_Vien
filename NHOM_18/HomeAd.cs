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
            this.Hide();
            Form7 mnuDocGia = new Form7();
            mnuDocGia.ShowDialog();
            this.Close();
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
            this.Hide();
            QuanLyBaoCao thongke = new QuanLyBaoCao();
            thongke.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAd homead = new HomeAd();
            homead.ShowDialog();
            this.Close();
        }
      

        private void btnSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 quanlysach = new Form3();
            quanlysach.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 mnuPhieuTra = new Form8();
            mnuPhieuTra.ShowDialog();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Quanlytacc taikhoan = new Quanlytacc();
            this.Hide();
            taikhoan.ShowDialog();
            this.Close();
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

