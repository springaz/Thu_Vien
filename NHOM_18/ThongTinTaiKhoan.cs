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
    public partial class ThongTinTaiKhoan : Form
    {
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Da luu ");
        }
<<<<<<< HEAD

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeAd mnuNguoiDung = new HomeAd();
            mnuNguoiDung.ShowDialog();
            this.Close();
        }
=======
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
    }
}
