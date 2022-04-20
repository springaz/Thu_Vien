
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
            // 
            // QuanLyBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.btnTraTre);
            this.Controls.Add(this.btnMuonTra);
            this.Controls.Add(this.lblBaoCao);
            this.Name = "QuanLyBaoCao";
            this.Text = "QuanLyBaoCao";
            this.Load += new System.EventHandler(this.QuanLyBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaoCao;
        private System.Windows.Forms.Button btnMuonTra;
        private System.Windows.Forms.Button btnTraTre;
    }
}