
namespace WindowsFormsApp2
{
    partial class QuanLyBaoCao
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
<<<<<<< HEAD
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThemDG = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(17, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 28);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Quay lại:";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 48);
            this.button1.TabIndex = 40;
            this.button1.Text = "Thống kê sách trả trễ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnThemDG
            // 
            this.btnThemDG.Location = new System.Drawing.Point(75, 114);
            this.btnThemDG.Name = "btnThemDG";
            this.btnThemDG.Size = new System.Drawing.Size(178, 48);
            this.btnThemDG.TabIndex = 39;
            this.btnThemDG.Text = "Tình hình mượn sách";
            this.btnThemDG.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "Báo cáo - Thống kê";
=======
            this.lblBaoCao = new System.Windows.Forms.Label();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.btnTraTre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaoCao
            // 
            this.lblBaoCao.AutoSize = true;
            this.lblBaoCao.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBaoCao.Location = new System.Drawing.Point(233, 62);
            this.lblBaoCao.Name = "lblBaoCao";
            this.lblBaoCao.Size = new System.Drawing.Size(344, 45);
            this.lblBaoCao.TabIndex = 28;
            this.lblBaoCao.Text = "Báo cáo - Thống kê";
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuonTra.Location = new System.Drawing.Point(103, 165);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(264, 73);
            this.btnMuonTra.TabIndex = 29;
            this.btnMuonTra.Text = "Tình hình mượn sách ";
            this.btnMuonTra.UseVisualStyleBackColor = true;
            this.btnMuonTra.Click += new System.EventHandler(this.btnMuonTra_Click);
            // 
            // btnTraTre
            // 
            this.btnTraTre.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraTre.Location = new System.Drawing.Point(428, 165);
            this.btnTraTre.Name = "btnTraTre";
            this.btnTraTre.Size = new System.Drawing.Size(264, 73);
            this.btnTraTre.TabIndex = 29;
            this.btnTraTre.Text = "Thống kê sách trả trễ";
            this.btnTraTre.UseVisualStyleBackColor = true;
            this.btnTraTre.Click += new System.EventHandler(this.btnTraTre_Click);
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
            // 
            // QuanLyBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(538, 231);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThemDG);
            this.Controls.Add(this.label2);
            this.Name = "QuanLyBaoCao";
            this.Text = "Quản lý thư viện";
=======
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.btnTraTre);
            this.Controls.Add(this.btnMuonTra);
            this.Controls.Add(this.lblBaoCao);
            this.Name = "QuanLyBaoCao";
            this.Text = "QuanLyBaoCao";
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
            this.Load += new System.EventHandler(this.QuanLyBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThemDG;
        private System.Windows.Forms.Label label2;
=======
        private System.Windows.Forms.Label lblBaoCao;
        private System.Windows.Forms.Button btnMuonTra;
        private System.Windows.Forms.Button btnTraTre;
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
    }
}