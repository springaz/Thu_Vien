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
    public partial class Quanlytacc : Form
    {
        public Quanlytacc()
        {
            InitializeComponent();
        }

        private void Quanlytacc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan thongtinmoi = new ThongTinTaiKhoan();
            thongtinmoi.Show();
        }
<<<<<<< HEAD

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAd mnuAd = new HomeAd();
            mnuAd.ShowDialog();
            this.Close();
        }
=======
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
    }
}
