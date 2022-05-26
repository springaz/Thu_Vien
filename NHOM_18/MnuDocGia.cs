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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Hide();
            DSDocGia dsDocGia = new DSDocGia();
            dsDocGia.ShowDialog();
            this.Close();
=======
            DSDocGia dsDocGia = new DSDocGia();
            dsDocGia.Show();
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Hide();
            DSDocGia dsDocGia = new DSDocGia();
            dsDocGia.ShowDialog();
            this.Close();
=======
            FormDanhSachPhMuon dsPhieuMuon = new FormDanhSachPhMuon();
            dsPhieuMuon.Show();
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
        }

        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Hide();
            DSDocGia dsDocGia = new DSDocGia();
            dsDocGia.ShowDialog();
            this.Close();
=======
            DanhsachPhTra dsPhieuTra = new DanhsachPhTra();
            dsPhieuTra.Show();
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
        }

        private void btnThemDG_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Hide();
            Form4 ThemDG = new Form4();
            ThemDG.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAd mnuBaoCao = new HomeAd();
            mnuBaoCao.ShowDialog();
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

=======
            Form4 ThemDG = new Form4();
            ThemDG.Show();
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
        }
    }
}
