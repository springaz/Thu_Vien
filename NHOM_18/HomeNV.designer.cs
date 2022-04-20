
namespace WindowsFormsApp2
{
    partial class HomeNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeNV));
            this.btnHome = new System.Windows.Forms.Button();
            this.LinklblHoTen = new System.Windows.Forms.LinkLabel();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnSignout = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.MonthCalendar();
            this.gbLich = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnPhieuMuonTra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbLich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(52, 93);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(156, 48);
            this.btnHome.TabIndex = 24;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // LinklblHoTen
            // 
            this.LinklblHoTen.AutoSize = true;
            this.LinklblHoTen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LinklblHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinklblHoTen.LinkColor = System.Drawing.Color.White;
            this.LinklblHoTen.Location = new System.Drawing.Point(756, 47);
            this.LinklblHoTen.Name = "LinklblHoTen";
            this.LinklblHoTen.Size = new System.Drawing.Size(131, 23);
            this.LinklblHoTen.TabIndex = 23;
            this.LinklblHoTen.TabStop = true;
            this.LinklblHoTen.Text = "Nguyễn Văn A";
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.SystemColors.Menu;
            this.btnThongke.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.Location = new System.Drawing.Point(700, 93);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(156, 48);
            this.btnThongke.TabIndex = 20;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnSignout
            // 
            this.btnSignout.Location = new System.Drawing.Point(922, 49);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(97, 23);
            this.btnSignout.TabIndex = 19;
            this.btnSignout.Text = "Đăng xuất";
            this.btnSignout.UseVisualStyleBackColor = true;
            // 
            // btnSach
            // 
            this.btnSach.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.Location = new System.Drawing.Point(214, 93);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(156, 48);
            this.btnSach.TabIndex = 17;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDocGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.Location = new System.Drawing.Point(376, 93);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(156, 48);
            this.btnDocGia.TabIndex = 16;
            this.btnDocGia.Text = "Độc giả";
            this.btnDocGia.UseVisualStyleBackColor = false;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // lblMain
            // 
            this.lblMain.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMain.Location = new System.Drawing.Point(369, 29);
            this.lblMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(394, 61);
            this.lblMain.TabIndex = 15;
            this.lblMain.Text = "Hệ thống thư viện";
            this.lblMain.UseMnemonic = false;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(12, 40);
            this.date.Name = "date";
            this.date.TabIndex = 12;
            // 
            // gbLich
            // 
            this.gbLich.Controls.Add(this.date);
            this.gbLich.Location = new System.Drawing.Point(686, 167);
            this.gbLich.Name = "gbLich";
            this.gbLich.Size = new System.Drawing.Size(358, 275);
            this.gbLich.TabIndex = 26;
            this.gbLich.TabStop = false;
            this.gbLich.Text = "Tiện ích";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHelp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(862, 93);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(156, 48);
            this.btnHelp.TabIndex = 21;
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnPhieuMuonTra
            // 
            this.btnPhieuMuonTra.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPhieuMuonTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuMuonTra.Location = new System.Drawing.Point(538, 93);
            this.btnPhieuMuonTra.Name = "btnPhieuMuonTra";
            this.btnPhieuMuonTra.Size = new System.Drawing.Size(156, 48);
            this.btnPhieuMuonTra.TabIndex = 22;
            this.btnPhieuMuonTra.Text = "Phiếu mượn trả";
            this.btnPhieuMuonTra.UseVisualStyleBackColor = false;
            this.btnPhieuMuonTra.Click += new System.EventHandler(this.btnPhieuMuonTra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // HomeNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1072, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.LinklblHoTen);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.btnSach);
            this.Controls.Add(this.btnDocGia);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.gbLich);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnPhieuMuonTra);
            this.Name = "HomeNV";
            this.Text = "Hệ thống thư viện";
            this.Load += new System.EventHandler(this.HomeNV_Load);
            this.gbLich.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.LinkLabel LinklblHoTen;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.MonthCalendar date;
        private System.Windows.Forms.GroupBox gbLich;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnPhieuMuonTra;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}