using NHOM_18;
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
    public partial class QuanLyBaoCao : Form
    {
        public QuanLyBaoCao()
        {
            InitializeComponent();
        }

        private void QuanLyBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            this.Hide();
            THMuonSach tinhhinhmuon = new THMuonSach();
            tinhhinhmuon.ShowDialog();
            this.Close();
        }

        private void btnTraTre_Click(object sender, EventArgs e)
        {
            this.Hide();
            TraTre tratre = new TraTre();
            tratre.ShowDialog();
            this.Close();
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
