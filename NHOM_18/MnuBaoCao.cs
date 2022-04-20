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
            THMuonSach tinhhinhmuon = new THMuonSach();
            tinhhinhmuon.Show();

        }

        private void btnTraTre_Click(object sender, EventArgs e)
        {
            TraTre tratre = new TraTre();
            tratre.Show();
        }
    }
}
