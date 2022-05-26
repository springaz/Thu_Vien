using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class DSDocGia : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=XUANBUI;Initial Catalog=QuanLyThuVien;Integrated Security=True ";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from DSDocGia";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public DSDocGia()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }
<<<<<<< HEAD

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 mnuDocGia = new Form7();
            mnuDocGia.ShowDialog();
            this.Close();
        }
=======
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
    }
}
