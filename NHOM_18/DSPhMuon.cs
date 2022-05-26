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
    public partial class FormDanhSachPhMuon : Form
    {
        public FormDanhSachPhMuon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 phieumuon = new Form9();
            phieumuon.Show();
        }

        private void FormDanhSachPhMuon_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 mnuMuonTra = new Form8();
            mnuMuonTra.ShowDialog();
            this.Close();
        }
    }
}
