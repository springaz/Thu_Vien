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
<<<<<<< HEAD
            this.Hide();
            THMuonSach tinhhinhmuon = new THMuonSach();
            tinhhinhmuon.ShowDialog();
            this.Close();
=======
            THMuonSach tinhhinhmuon = new THMuonSach();
            tinhhinhmuon.Show();

>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
        }

        private void btnTraTre_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
            TraTre tratre = new TraTre();
            tratre.Show();
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
        }
    }
}
