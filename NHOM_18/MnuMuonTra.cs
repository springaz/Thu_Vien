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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDanhSachPhMuon PhieuMuon = new FormDanhSachPhMuon();
            PhieuMuon.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DanhsachPhTra PhieuTra = new DanhsachPhTra();
            PhieuTra.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAd mnuBaoCao = new HomeAd();
            mnuBaoCao.ShowDialog();
            this.Close();
        }
    }
}
