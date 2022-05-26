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
    public partial class DanhsachPhTra : Form
    {
        public DanhsachPhTra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 DsPhieuTra = new Form5();
            DsPhieuTra.Show();
        }

        private void DanhsachPhTra_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 mnuMuonTra = new Form8();
            mnuMuonTra.ShowDialog();
            this.Close();
        }
=======
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
    }
}
