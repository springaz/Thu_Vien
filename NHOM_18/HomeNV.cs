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
    public partial class HomeNV : Form
    {
        public HomeNV()
        {
            InitializeComponent();
        }

        private void HomeNV_Load(object sender, EventArgs e)
        {

        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            Form7 mnudocgia = new Form7();
            mnudocgia.Show();
        }

        private void btnPhieuMuonTra_Click(object sender, EventArgs e)
        {
            Form8 mnuPhieuMuonTra = new Form8();
            mnuPhieuMuonTra.Show();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            QuanLyBaoCao thongke = new QuanLyBaoCao();
            thongke.Show();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            Form3 dsSach = new Form3();
            dsSach.Show();
        }
    }
}
