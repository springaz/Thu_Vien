
namespace WindowsFormsApp2
{
    partial class DangNhap
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
            this.btnDN = new System.Windows.Forms.Button();
            this.txtbTenDN = new System.Windows.Forms.TextBox();
            this.txtbMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDN = new System.Windows.Forms.Label();
            this.rdNhanVien = new System.Windows.Forms.RadioButton();
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDN
            // 
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDN.Location = new System.Drawing.Point(332, 294);
            this.btnDN.Margin = new System.Windows.Forms.Padding(4);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(142, 41);
            this.btnDN.TabIndex = 0;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // txtbTenDN
            // 
            this.txtbTenDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTenDN.Location = new System.Drawing.Point(279, 112);
            this.txtbTenDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtbTenDN.Name = "txtbTenDN";
            this.txtbTenDN.Size = new System.Drawing.Size(291, 26);
            this.txtbTenDN.TabIndex = 1;
            this.txtbTenDN.TextChanged += new System.EventHandler(this.txtbTenDN_TextChanged);
            // 
            // txtbMatKhau
            // 
            this.txtbMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMatKhau.Location = new System.Drawing.Point(279, 163);
            this.txtbMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtbMatKhau.Name = "txtbMatKhau";
            this.txtbMatKhau.Size = new System.Drawing.Size(291, 26);
            this.txtbMatKhau.TabIndex = 2;
            this.txtbMatKhau.TextChanged += new System.EventHandler(this.txtbMatKhau_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(85, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(85, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // lblDN
            // 
            this.lblDN.AutoSize = true;
            this.lblDN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDN.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDN.ForeColor = System.Drawing.Color.White;
            this.lblDN.Location = new System.Drawing.Point(325, 54);
            this.lblDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDN.Name = "lblDN";
            this.lblDN.Size = new System.Drawing.Size(170, 37);
            this.lblDN.TabIndex = 5;
            this.lblDN.Text = "Đăng nhập";
            this.lblDN.Click += new System.EventHandler(this.label3_Click);
            // 
            // rdNhanVien
            // 
            this.rdNhanVien.AutoSize = true;
            this.rdNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNhanVien.Location = new System.Drawing.Point(279, 214);
            this.rdNhanVien.Name = "rdNhanVien";
            this.rdNhanVien.Size = new System.Drawing.Size(97, 23);
            this.rdNhanVien.TabIndex = 7;
            this.rdNhanVien.TabStop = true;
            this.rdNhanVien.Text = "Nhân viên";
            this.rdNhanVien.UseVisualStyleBackColor = false;
            this.rdNhanVien.CheckedChanged += new System.EventHandler(this.rdNhanVien_CheckedChanged);
            // 
            // rdAdmin
            // 
            this.rdAdmin.AutoSize = true;
            this.rdAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdAdmin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAdmin.Location = new System.Drawing.Point(420, 214);
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.Size = new System.Drawing.Size(75, 23);
            this.rdAdmin.TabIndex = 8;
            this.rdAdmin.TabStop = true;
            this.rdAdmin.Text = "Admin";
            this.rdAdmin.UseVisualStyleBackColor = false;
            this.rdAdmin.CheckedChanged += new System.EventHandler(this.rdAdmin_CheckedChanged);
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQuyen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblQuyen.Location = new System.Drawing.Point(85, 211);
            this.lblQuyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(172, 26);
            this.lblQuyen.TabIndex = 11;
            this.lblQuyen.Text = "Quyền truy cập";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 407);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.rdAdmin);
            this.Controls.Add(this.rdNhanVien);
            this.Controls.Add(this.lblDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbMatKhau);
            this.Controls.Add(this.txtbTenDN);
            this.Controls.Add(this.btnDN);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhap";
            this.Text = "Quản lí hệ thống thư viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.TextBox txtbTenDN;
        private System.Windows.Forms.TextBox txtbMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDN;
        private System.Windows.Forms.RadioButton rdNhanVien;
        private System.Windows.Forms.RadioButton rdAdmin;
        private System.Windows.Forms.Label lblQuyen;
    }
}

