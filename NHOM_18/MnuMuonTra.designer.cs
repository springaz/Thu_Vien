
namespace WindowsFormsApp2
{
    partial class Form8
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.btnBack = new System.Windows.Forms.Button();
=======
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(283, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 49);
            this.button3.TabIndex = 9;
            this.button3.Text = "Danh sách phiếu trả";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "Danh sách phiếu mượn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý phiếu mượn trả";
            // 
<<<<<<< HEAD
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
=======
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(541, 202);
<<<<<<< HEAD
            this.Controls.Add(this.btnBack);
=======
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
<<<<<<< HEAD
            this.Text = "Quản lý thư viện";
=======
            this.Text = "Quản lý phiếu mượn trả";
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnBack;
=======
>>>>>>> 8b0447d92c8d310e22fd6c97e99d0abc395f4062
    }
}