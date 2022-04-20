namespace WindowsFormsApp2
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPhieuMuonSach = new System.Windows.Forms.Label();
            this.gbPM = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMaSachTK = new System.Windows.Forms.Label();
            this.txtMaSachTK = new System.Windows.Forms.TextBox();
            this.gbThongTinSach = new System.Windows.Forms.GroupBox();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblMaSachTT = new System.Windows.Forms.Label();
            this.txtMaSachTT = new System.Windows.Forms.TextBox();
            this.gbChoMuon = new System.Windows.Forms.GroupBox();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnMuon = new System.Windows.Forms.Button();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.NgayTra = new System.Windows.Forms.DateTimePicker();
            this.NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.lblMaDG = new System.Windows.Forms.Label();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.gbDSSach = new System.Windows.Forms.GroupBox();
            this.listPhieuMuon = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPM.SuspendLayout();
            this.gbThongTinSach.SuspendLayout();
            this.gbChoMuon.SuspendLayout();
            this.gbDSSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPhieuMuonSach
            // 
            this.lblPhieuMuonSach.AutoSize = true;
            this.lblPhieuMuonSach.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuMuonSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhieuMuonSach.Location = new System.Drawing.Point(364, 7);
            this.lblPhieuMuonSach.Name = "lblPhieuMuonSach";
            this.lblPhieuMuonSach.Size = new System.Drawing.Size(243, 35);
            this.lblPhieuMuonSach.TabIndex = 0;
            this.lblPhieuMuonSach.Text = "Phiếu Mượn Sách";
            this.lblPhieuMuonSach.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbPM
            // 
            this.gbPM.Controls.Add(this.btnSearch);
            this.gbPM.Controls.Add(this.lblMaSachTK);
            this.gbPM.Controls.Add(this.txtMaSachTK);
            this.gbPM.Location = new System.Drawing.Point(19, 64);
            this.gbPM.Name = "gbPM";
            this.gbPM.Size = new System.Drawing.Size(405, 116);
            this.gbPM.TabIndex = 8;
            this.gbPM.TabStop = false;
            this.gbPM.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(154, 77);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 22);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblMaSachTK
            // 
            this.lblMaSachTK.AutoSize = true;
            this.lblMaSachTK.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSachTK.Location = new System.Drawing.Point(16, 32);
            this.lblMaSachTK.Name = "lblMaSachTK";
            this.lblMaSachTK.Size = new System.Drawing.Size(182, 21);
            this.lblMaSachTK.TabIndex = 8;
            this.lblMaSachTK.Text = "Nhập mã sách cần tìm ";
            // 
            // txtMaSachTK
            // 
            this.txtMaSachTK.Location = new System.Drawing.Point(208, 31);
            this.txtMaSachTK.Name = "txtMaSachTK";
            this.txtMaSachTK.Size = new System.Drawing.Size(164, 22);
            this.txtMaSachTK.TabIndex = 7;
            // 
            // gbThongTinSach
            // 
            this.gbThongTinSach.Controls.Add(this.btnAddDetail);
            this.gbThongTinSach.Controls.Add(this.lblTacGia);
            this.gbThongTinSach.Controls.Add(this.txtTacGia);
            this.gbThongTinSach.Controls.Add(this.lblTheLoai);
            this.gbThongTinSach.Controls.Add(this.txtTheLoai);
            this.gbThongTinSach.Controls.Add(this.lblTenSach);
            this.gbThongTinSach.Controls.Add(this.txtTenSach);
            this.gbThongTinSach.Controls.Add(this.lblMaSachTT);
            this.gbThongTinSach.Controls.Add(this.txtMaSachTT);
            this.gbThongTinSach.Location = new System.Drawing.Point(19, 192);
            this.gbThongTinSach.Name = "gbThongTinSach";
            this.gbThongTinSach.Size = new System.Drawing.Size(405, 257);
            this.gbThongTinSach.TabIndex = 13;
            this.gbThongTinSach.TabStop = false;
            this.gbThongTinSach.Text = "Thông tin sách";
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(124, 215);
            this.btnAddDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(156, 22);
            this.btnAddDetail.TabIndex = 19;
            this.btnAddDetail.Text = "Thêm vào chi tiết";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTacGia.Location = new System.Drawing.Point(16, 169);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(65, 21);
            this.lblTacGia.TabIndex = 15;
            this.lblTacGia.Text = "Tác giả";
            this.lblTacGia.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(102, 170);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(164, 22);
            this.txtTacGia.TabIndex = 14;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTheLoai.Location = new System.Drawing.Point(16, 124);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(77, 21);
            this.lblTheLoai.TabIndex = 13;
            this.lblTheLoai.Text = "Thể Loại";
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(102, 125);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(164, 22);
            this.txtTheLoai.TabIndex = 12;
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenSach.Location = new System.Drawing.Point(16, 79);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(81, 21);
            this.lblTenSach.TabIndex = 11;
            this.lblTenSach.Text = "Tên Sách";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(102, 80);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(164, 22);
            this.txtTenSach.TabIndex = 10;
            // 
            // lblMaSachTT
            // 
            this.lblMaSachTT.AutoSize = true;
            this.lblMaSachTT.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSachTT.Location = new System.Drawing.Point(16, 31);
            this.lblMaSachTT.Name = "lblMaSachTT";
            this.lblMaSachTT.Size = new System.Drawing.Size(76, 21);
            this.lblMaSachTT.TabIndex = 9;
            this.lblMaSachTT.Text = "Mã Sách";
            this.lblMaSachTT.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMaSachTT
            // 
            this.txtMaSachTT.Location = new System.Drawing.Point(102, 32);
            this.txtMaSachTT.Name = "txtMaSachTT";
            this.txtMaSachTT.Size = new System.Drawing.Size(164, 22);
            this.txtMaSachTT.TabIndex = 7;
            // 
            // gbChoMuon
            // 
            this.gbChoMuon.Controls.Add(this.btnTrangChu);
            this.gbChoMuon.Controls.Add(this.btnHuy);
            this.gbChoMuon.Controls.Add(this.btnMuon);
            this.gbChoMuon.Controls.Add(this.cbMaDG);
            this.gbChoMuon.Controls.Add(this.cbMaSach);
            this.gbChoMuon.Controls.Add(this.cbTinhTrang);
            this.gbChoMuon.Controls.Add(this.lblTinhTrang);
            this.gbChoMuon.Controls.Add(this.lblMaSach);
            this.gbChoMuon.Controls.Add(this.NgayTra);
            this.gbChoMuon.Controls.Add(this.NgayMuon);
            this.gbChoMuon.Controls.Add(this.lblNgayTra);
            this.gbChoMuon.Controls.Add(this.lblNgayMuon);
            this.gbChoMuon.Controls.Add(this.lblMaDG);
            this.gbChoMuon.Controls.Add(this.lblMaPhieu);
            this.gbChoMuon.Controls.Add(this.txtMaPhieu);
            this.gbChoMuon.Location = new System.Drawing.Point(441, 64);
            this.gbChoMuon.Name = "gbChoMuon";
            this.gbChoMuon.Size = new System.Drawing.Size(516, 385);
            this.gbChoMuon.TabIndex = 16;
            this.gbChoMuon.TabStop = false;
            this.gbChoMuon.Text = "Thực hiện cho mượn sách";
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTrangChu.Location = new System.Drawing.Point(347, 253);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(92, 41);
            this.btnTrangChu.TabIndex = 28;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHuy.Location = new System.Drawing.Point(219, 253);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 41);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.BackColor = System.Drawing.Color.LawnGreen;
            this.btnMuon.Location = new System.Drawing.Point(85, 253);
            this.btnMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(92, 41);
            this.btnMuon.TabIndex = 26;
            this.btnMuon.Text = "Cho Mượn";
            this.btnMuon.UseVisualStyleBackColor = false;
            // 
            // cbMaDG
            // 
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(102, 77);
            this.cbMaDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(108, 24);
            this.cbMaDG.TabIndex = 25;
            // 
            // cbMaSach
            // 
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(352, 29);
            this.cbMaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(108, 24);
            this.cbMaSach.TabIndex = 24;
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Location = new System.Drawing.Point(352, 77);
            this.cbTinhTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(108, 24);
            this.cbTinhTrang.TabIndex = 21;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTinhTrang.Location = new System.Drawing.Point(251, 79);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(94, 21);
            this.lblTinhTrang.TabIndex = 20;
            this.lblTinhTrang.Text = "Tình Trạng";
            this.lblTinhTrang.Click += new System.EventHandler(this.label13_Click);
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSach.Location = new System.Drawing.Point(251, 30);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(76, 21);
            this.lblMaSach.TabIndex = 16;
            this.lblMaSach.Text = "Mã Sách";
            // 
            // NgayTra
            // 
            this.NgayTra.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NgayTra.Location = new System.Drawing.Point(132, 191);
            this.NgayTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Size = new System.Drawing.Size(266, 22);
            this.NgayTra.TabIndex = 18;
            this.NgayTra.Value = new System.DateTime(2021, 11, 24, 0, 0, 0, 0);
            // 
            // NgayMuon
            // 
            this.NgayMuon.Location = new System.Drawing.Point(132, 143);
            this.NgayMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Size = new System.Drawing.Size(266, 22);
            this.NgayMuon.TabIndex = 17;
            this.NgayMuon.Value = new System.DateTime(2021, 11, 16, 0, 0, 0, 0);
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayTra.Location = new System.Drawing.Point(16, 191);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(79, 21);
            this.lblNgayTra.TabIndex = 15;
            this.lblNgayTra.Text = "Ngày Trả";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayMuon.Location = new System.Drawing.Point(16, 143);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(104, 21);
            this.lblNgayMuon.TabIndex = 13;
            this.lblNgayMuon.Text = "Ngày Mượn ";
            // 
            // lblMaDG
            // 
            this.lblMaDG.AutoSize = true;
            this.lblMaDG.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaDG.Location = new System.Drawing.Point(16, 79);
            this.lblMaDG.Name = "lblMaDG";
            this.lblMaDG.Size = new System.Drawing.Size(67, 21);
            this.lblMaDG.TabIndex = 11;
            this.lblMaDG.Text = "Mã ĐG";
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaPhieu.Location = new System.Drawing.Point(16, 31);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(80, 21);
            this.lblMaPhieu.TabIndex = 9;
            this.lblMaPhieu.Text = "Mã Phiếu";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(102, 32);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(108, 22);
            this.txtMaPhieu.TabIndex = 7;
            // 
            // gbDSSach
            // 
            this.gbDSSach.Controls.Add(this.listPhieuMuon);
            this.gbDSSach.Controls.Add(this.dataGridView1);
            this.gbDSSach.Location = new System.Drawing.Point(16, 466);
            this.gbDSSach.Name = "gbDSSach";
            this.gbDSSach.Size = new System.Drawing.Size(940, 174);
            this.gbDSSach.TabIndex = 17;
            this.gbDSSach.TabStop = false;
            this.gbDSSach.Text = "Danh sách mượn";
            // 
            // listPhieuMuon
            // 
            this.listPhieuMuon.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.listPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.listPhieuMuon.Location = new System.Drawing.Point(-44, 22);
            this.listPhieuMuon.Name = "listPhieuMuon";
            this.listPhieuMuon.RowHeadersWidth = 51;
            this.listPhieuMuon.RowTemplate.Height = 24;
            this.listPhieuMuon.Size = new System.Drawing.Size(1011, 234);
            this.listPhieuMuon.TabIndex = 3;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "STT";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Mã Phiếu";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã ĐG";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã sách";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày Mượn";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày Trả";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Tình Trạng";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.column7});
            this.dataGridView1.Location = new System.Drawing.Point(13, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(902, 258);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Phiếu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã ĐG";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã sách";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Mượn";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày Trả";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số Lượng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // column7
            // 
            this.column7.HeaderText = "Tình Trạng";
            this.column7.MinimumWidth = 8;
            this.column7.Name = "column7";
            this.column7.Width = 150;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 651);
            this.Controls.Add(this.gbDSSach);
            this.Controls.Add(this.gbChoMuon);
            this.Controls.Add(this.gbThongTinSach);
            this.Controls.Add(this.gbPM);
            this.Controls.Add(this.lblPhieuMuonSach);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form9";
            this.Text = "Phiếu Mượn Sách";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.gbPM.ResumeLayout(false);
            this.gbPM.PerformLayout();
            this.gbThongTinSach.ResumeLayout(false);
            this.gbThongTinSach.PerformLayout();
            this.gbChoMuon.ResumeLayout(false);
            this.gbChoMuon.PerformLayout();
            this.gbDSSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhieuMuonSach;
        private System.Windows.Forms.GroupBox gbPM;
        private System.Windows.Forms.Label lblMaSachTK;
        private System.Windows.Forms.TextBox txtMaSachTK;
        private System.Windows.Forms.GroupBox gbThongTinSach;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblMaSachTT;
        private System.Windows.Forms.TextBox txtMaSachTT;
        private System.Windows.Forms.GroupBox gbChoMuon;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label lblMaDG;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.DateTimePicker NgayTra;
        private System.Windows.Forms.DateTimePicker NgayMuon;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.ComboBox cbMaDG;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.GroupBox gbDSSach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn column7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.DataGridView listPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}