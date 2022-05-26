
namespace WindowsFormsApp2
{
    partial class TraTre
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
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.NgayBC = new System.Windows.Forms.DateTimePicker();
            this.gbTinhHinh = new System.Windows.Forms.GroupBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtNgayTre = new System.Windows.Forms.TextBox();
            this.NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lblSoNgayTre = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblBaoCao = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbTinhHinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(17, 41);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(82, 20);
            this.lblThoiGian.TabIndex = 30;
            this.lblThoiGian.Text = "Thời gian:";
            // 
            // NgayBC
            // 
            this.NgayBC.Location = new System.Drawing.Point(117, 41);
            this.NgayBC.Name = "NgayBC";
            this.NgayBC.Size = new System.Drawing.Size(311, 27);
            this.NgayBC.TabIndex = 31;
            // 
            // gbTinhHinh
            // 
            this.gbTinhHinh.Controls.Add(this.txtTenSach);
            this.gbTinhHinh.Controls.Add(this.txtNgayTre);
            this.gbTinhHinh.Controls.Add(this.NgayMuon);
            this.gbTinhHinh.Controls.Add(this.NgayBC);
            this.gbTinhHinh.Controls.Add(this.lblSoNgayTre);
            this.gbTinhHinh.Controls.Add(this.lblNgayMuon);
            this.gbTinhHinh.Controls.Add(this.lblTenSach);
            this.gbTinhHinh.Controls.Add(this.lblThoiGian);
            this.gbTinhHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTinhHinh.Location = new System.Drawing.Point(29, 138);
            this.gbTinhHinh.Name = "gbTinhHinh";
            this.gbTinhHinh.Size = new System.Drawing.Size(732, 236);
            this.gbTinhHinh.TabIndex = 32;
            this.gbTinhHinh.TabStop = false;
            this.gbTinhHinh.Text = "Thống kê sách trả trễ";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(117, 94);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(174, 27);
            this.txtTenSach.TabIndex = 33;
            // 
            // txtNgayTre
            // 
            this.txtNgayTre.Location = new System.Drawing.Point(450, 94);
            this.txtNgayTre.Name = "txtNgayTre";
            this.txtNgayTre.Size = new System.Drawing.Size(100, 27);
            this.txtNgayTre.TabIndex = 33;
            // 
            // NgayMuon
            // 
            this.NgayMuon.Location = new System.Drawing.Point(117, 155);
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Size = new System.Drawing.Size(311, 27);
            this.NgayMuon.TabIndex = 31;
            // 
            // lblSoNgayTre
            // 
            this.lblSoNgayTre.AutoSize = true;
            this.lblSoNgayTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgayTre.Location = new System.Drawing.Point(320, 97);
            this.lblSoNgayTre.Name = "lblSoNgayTre";
            this.lblSoNgayTre.Size = new System.Drawing.Size(124, 20);
            this.lblSoNgayTre.TabIndex = 30;
            this.lblSoNgayTre.Text = "Số ngày trả trễ:";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayMuon.Location = new System.Drawing.Point(17, 155);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(93, 20);
            this.lblNgayMuon.TabIndex = 30;
            this.lblNgayMuon.Text = "Ngày mượn";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(17, 97);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(78, 20);
            this.lblTenSach.TabIndex = 30;
            this.lblTenSach.Text = "Tên sách";
            // 
            // lblBaoCao
            // 
            this.lblBaoCao.AutoSize = true;
            this.lblBaoCao.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBaoCao.Location = new System.Drawing.Point(244, 81);
            this.lblBaoCao.Name = "lblBaoCao";
            this.lblBaoCao.Size = new System.Drawing.Size(286, 37);
            this.lblBaoCao.TabIndex = 33;
            this.lblBaoCao.Text = "Báo cáo - Thống kê";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(573, 380);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 35);
            this.btnLuu.TabIndex = 34;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(654, 380);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 35);
            this.btnIn.TabIndex = 34;
            this.btnIn.Text = "Xuất";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 28);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Quay lại:";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TraTre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblBaoCao);
            this.Controls.Add(this.gbTinhHinh);
            this.Name = "TraTre";
            this.Text = "Quản lý thư viện";
            this.Load += new System.EventHandler(this.TraTre_Load);
            this.gbTinhHinh.ResumeLayout(false);
            this.gbTinhHinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.DateTimePicker NgayBC;
        private System.Windows.Forms.GroupBox gbTinhHinh;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtNgayTre;
        private System.Windows.Forms.DateTimePicker NgayMuon;
        private System.Windows.Forms.Label lblSoNgayTre;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblBaoCao;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnBack;
    }
}