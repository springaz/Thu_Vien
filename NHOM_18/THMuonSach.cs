﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM_18
{
    public partial class THMuonSach : Form
    {
        public THMuonSach()
        {
            InitializeComponent();
        }

        private void THMuonSach_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form mnuTinhHinhMuon = new Form();
            mnuTinhHinhMuon.ShowDialog();
            this.Close();
        }

        private void lblBaoCao_Click(object sender, EventArgs e)
        {

        }
    }
}