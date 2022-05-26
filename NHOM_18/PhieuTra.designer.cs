namespace WindowsFormsApp2
{
    partial class Form5
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
            this.gbListTra = new System.Windows.Forms.GroupBox();
            this.ListTraSach = new System.Windows.Forms.DataGridView();
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
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.cbMaSachTra = new System.Windows.Forms.ComboBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblMaSachTra = new System.Windows.Forms.Label();
            this.NgayTra = new System.Windows.Forms.DateTimePicker();
            this.NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblPhieuTraSach = new System.Windows.Forms.Label();
            this.lblMaDG = new System.Windows.Forms.Label();
            this.gbTraSach = new System.Windows.Forms.GroupBox();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.gbThongTinSach = new System.Windows.Forms.GroupBox();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.txTacGia = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.txTheLoai = new System.Windows.Forms.TextBox();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.txTenSach = new System.Windows.Forms.TextBox();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.txMaSach = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbListTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListTraSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.gbTraSach.SuspendLayout();
            this.gbThongTinSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListTra
            // 
            this.gbListTra.Controls.Add(this.ListTraSach);
            this.gbListTra.Controls.Add(this.dataGridView1);
            this.gbListTra.Location = new System.Drawing.Point(23, 466);
            this.gbListTra.Name = "gbListTra";
            this.gbListTra.Size = new System.Drawing.Size(940, 174);
            this.gbListTra.TabIndex = 22;
            this.gbListTra.TabStop = false;
            this.gbListTra.Text = "Danh sách trả";
            // 
            // ListTraSach
            // 
            this.ListTraSach.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.ListTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListTraSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ListTraSach.Location = new System.Drawing.Point(-44, 22);
            this.ListTraSach.Name = "ListTraSach";
            this.ListTraSach.RowHeadersWidth = 51;
            this.ListTraSach.RowTemplate.Height = 24;
            this.ListTraSach.Size = new System.Drawing.Size(1011, 234);
            this.ListTraSach.TabIndex = 3;
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
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
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
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.LawnGreen;
            this.btnTraSach.Location = new System.Drawing.Point(85, 253);
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(92, 41);
            this.btnTraSach.TabIndex = 26;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = false;
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
            // cbMaSachTra
            // 
            this.cbMaSachTra.FormattingEnabled = true;
            this.cbMaSachTra.Location = new System.Drawing.Point(352, 29);
            this.cbMaSachTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaSachTra.Name = "cbMaSachTra";
            this.cbMaSachTra.Size = new System.Drawing.Size(108, 24);
            this.cbMaSachTra.TabIndex = 24;
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
            // 
            // lblMaSachTra
            // 
            this.lblMaSachTra.AutoSize = true;
            this.lblMaSachTra.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSachTra.Location = new System.Drawing.Point(251, 30);
            this.lblMaSachTra.Name = "lblMaSachTra";
            this.lblMaSachTra.Size = new System.Drawing.Size(76, 21);
            this.lblMaSachTra.TabIndex = 16;
            this.lblMaSachTra.Text = "Mã Sách";
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
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(281, 34);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(164, 22);
            this.txtMaSach.TabIndex = 7;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.lblMaSach);
            this.gbSearch.Controls.Add(this.txtMaSach);
            this.gbSearch.Location = new System.Drawing.Point(180, 55);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(610, 82);
            this.gbSearch.TabIndex = 19;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(470, 34);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 22);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSach.Location = new System.Drawing.Point(62, 34);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(182, 21);
            this.lblMaSach.TabIndex = 8;
            this.lblMaSach.Text = "Nhập mã sách cần tìm ";
            // 
            // lblPhieuTraSach
            // 
            this.lblPhieuTraSach.AutoSize = true;
            this.lblPhieuTraSach.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuTraSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhieuTraSach.Location = new System.Drawing.Point(371, 7);
            this.lblPhieuTraSach.Name = "lblPhieuTraSach";
            this.lblPhieuTraSach.Size = new System.Drawing.Size(207, 35);
            this.lblPhieuTraSach.TabIndex = 18;
            this.lblPhieuTraSach.Text = "Phiếu Trả Sách";
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
            // gbTraSach
            // 
            this.gbTraSach.Controls.Add(this.btnTrangChu);
            this.gbTraSach.Controls.Add(this.btnHuy);
            this.gbTraSach.Controls.Add(this.btnTraSach);
            this.gbTraSach.Controls.Add(this.cbMaDG);
            this.gbTraSach.Controls.Add(this.cbMaSachTra);
            this.gbTraSach.Controls.Add(this.cbTinhTrang);
            this.gbTraSach.Controls.Add(this.lblTinhTrang);
            this.gbTraSach.Controls.Add(this.lblMaSachTra);
            this.gbTraSach.Controls.Add(this.NgayTra);
            this.gbTraSach.Controls.Add(this.NgayMuon);
            this.gbTraSach.Controls.Add(this.lblNgayTra);
            this.gbTraSach.Controls.Add(this.lblNgayMuon);
            this.gbTraSach.Controls.Add(this.lblMaDG);
            this.gbTraSach.Controls.Add(this.lblMaPhieu);
            this.gbTraSach.Controls.Add(this.txtMaPhieu);
            this.gbTraSach.Location = new System.Drawing.Point(23, 152);
            this.gbTraSach.Name = "gbTraSach";
            this.gbTraSach.Size = new System.Drawing.Size(516, 308);
            this.gbTraSach.TabIndex = 21;
            this.gbTraSach.TabStop = false;
            this.gbTraSach.Text = "Thực hiện trả sách";
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
            // gbThongTinSach
            // 
            this.gbThongTinSach.Controls.Add(this.btnAddDetail);
            this.gbThongTinSach.Controls.Add(this.lblTacGia);
            this.gbThongTinSach.Controls.Add(this.txTacGia);
            this.gbThongTinSach.Controls.Add(this.lblTheLoai);
            this.gbThongTinSach.Controls.Add(this.txTheLoai);
            this.gbThongTinSach.Controls.Add(this.lbTenSach);
            this.gbThongTinSach.Controls.Add(this.txTenSach);
            this.gbThongTinSach.Controls.Add(this.lbMaSach);
            this.gbThongTinSach.Controls.Add(this.txMaSach);
            this.gbThongTinSach.Location = new System.Drawing.Point(558, 152);
            this.gbThongTinSach.Name = "gbThongTinSach";
            this.gbThongTinSach.Size = new System.Drawing.Size(405, 308);
            this.gbThongTinSach.TabIndex = 23;
            this.gbThongTinSach.TabStop = false;
            this.gbThongTinSach.Text = "Thông tin sách";
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(140, 226);
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
            // 
            // txTacGia
            // 
            this.txTacGia.Location = new System.Drawing.Point(102, 170);
            this.txTacGia.Name = "txTacGia";
            this.txTacGia.Size = new System.Drawing.Size(164, 22);
            this.txTacGia.TabIndex = 14;
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
            // txTheLoai
            // 
            this.txTheLoai.Location = new System.Drawing.Point(102, 125);
            this.txTheLoai.Name = "txTheLoai";
            this.txTheLoai.Size = new System.Drawing.Size(164, 22);
            this.txTheLoai.TabIndex = 12;
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenSach.Location = new System.Drawing.Point(16, 79);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(81, 21);
            this.lbTenSach.TabIndex = 11;
            this.lbTenSach.Text = "Tên Sách";
            // 
            // txTenSach
            // 
            this.txTenSach.Location = new System.Drawing.Point(102, 80);
            this.txTenSach.Name = "txTenSach";
            this.txTenSach.Size = new System.Drawing.Size(164, 22);
            this.txTenSach.TabIndex = 10;
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaSach.Location = new System.Drawing.Point(16, 31);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(76, 21);
            this.lbMaSach.TabIndex = 9;
            this.lbMaSach.Text = "Mã Sách";
            // 
            // txMaSach
            // 
            this.txMaSach.Location = new System.Drawing.Point(102, 32);
            this.txMaSach.Name = "txMaSach";
            this.txMaSach.Size = new System.Drawing.Size(164, 22);
            this.txMaSach.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(447, 311);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 28);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Quay lại:";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 28);
            this.button1.TabIndex = 41;
            this.button1.Text = "Quay lại:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(988, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbThongTinSach);
            this.Controls.Add(this.gbListTra);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.lblPhieuTraSach);
            this.Controls.Add(this.gbTraSach);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form5";
            this.Text = "Quản lý thư viện";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.gbListTra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListTraSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbTraSach.ResumeLayout(false);
            this.gbTraSach.PerformLayout();
            this.gbThongTinSach.ResumeLayout(false);
            this.gbThongTinSach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListTra;
        private System.Windows.Forms.DataGridView ListTraSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn column7;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.ComboBox cbMaDG;
        private System.Windows.Forms.ComboBox cbMaSachTra;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblMaSachTra;
        private System.Windows.Forms.DateTimePicker NgayTra;
        private System.Windows.Forms.DateTimePicker NgayMuon;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblPhieuTraSach;
        private System.Windows.Forms.Label lblMaDG;
        private System.Windows.Forms.GroupBox gbTraSach;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.GroupBox gbThongTinSach;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.TextBox txTacGia;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.TextBox txTheLoai;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.TextBox txTenSach;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.TextBox txMaSach;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
    }
}