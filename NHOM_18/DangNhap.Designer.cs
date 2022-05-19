
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
            this.SuspendLayout();
            // 
            // btnDN
            // 
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDN.Location = new System.Drawing.Point(250, 209);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(106, 33);
            this.btnDN.TabIndex = 0;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // txtbTenDN
            // 
            this.txtbTenDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTenDN.Location = new System.Drawing.Point(209, 91);
            this.txtbTenDN.Name = "txtbTenDN";
            this.txtbTenDN.Size = new System.Drawing.Size(219, 23);
            this.txtbTenDN.TabIndex = 1;
            // 
            // txtbMatKhau
            // 
            this.txtbMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMatKhau.Location = new System.Drawing.Point(209, 132);
            this.txtbMatKhau.Name = "txtbMatKhau";
            this.txtbMatKhau.Size = new System.Drawing.Size(219, 23);
            this.txtbMatKhau.TabIndex = 2;
            this.txtbMatKhau.TextChanged += new System.EventHandler(this.txtbMatKhau_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(64, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
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
            this.label2.Location = new System.Drawing.Point(64, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // lblDN
            // 
            this.lblDN.AutoSize = true;
            this.lblDN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDN.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDN.ForeColor = System.Drawing.Color.White;
            this.lblDN.Location = new System.Drawing.Point(244, 44);
            this.lblDN.Name = "lblDN";
            this.lblDN.Size = new System.Drawing.Size(142, 31);
            this.lblDN.TabIndex = 5;
            this.lblDN.Text = "Đăng nhập";
            this.lblDN.Click += new System.EventHandler(this.label3_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 331);
            this.Controls.Add(this.lblDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbMatKhau);
            this.Controls.Add(this.txtbTenDN);
            this.Controls.Add(this.btnDN);
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
    }
}

