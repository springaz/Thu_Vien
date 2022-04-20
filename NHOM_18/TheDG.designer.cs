
namespace WindowsFormsApp2
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTenDG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbNgapLap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rd56Up = new System.Windows.Forms.RadioButton();
            this.rd1855 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnTaoThe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thẻ độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(39, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // txtbTenDG
            // 
            this.txtbTenDG.Location = new System.Drawing.Point(137, 29);
            this.txtbTenDG.Name = "txtbTenDG";
            this.txtbTenDG.Size = new System.Drawing.Size(202, 22);
            this.txtbTenDG.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(433, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtbNgapLap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rd56Up);
            this.groupBox1.Controls.Add(this.rd1855);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtbEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtbDiaChi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtbTenDG);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 201);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thẻ độc giả";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(551, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(182, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "15/04/2022";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(433, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ngày hết hạn";
            // 
            // txtbNgapLap
            // 
            this.txtbNgapLap.Location = new System.Drawing.Point(551, 108);
            this.txtbNgapLap.Name = "txtbNgapLap";
            this.txtbNgapLap.ReadOnly = true;
            this.txtbNgapLap.Size = new System.Drawing.Size(182, 22);
            this.txtbNgapLap.TabIndex = 13;
            this.txtbNgapLap.Text = "15/11/2021";
            this.txtbNgapLap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(433, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày lập thẻ";
            // 
            // rd56Up
            // 
            this.rd56Up.AutoSize = true;
            this.rd56Up.Location = new System.Drawing.Point(148, 136);
            this.rd56Up.Name = "rd56Up";
            this.rd56Up.Size = new System.Drawing.Size(137, 21);
            this.rd56Up.TabIndex = 11;
            this.rd56Up.TabStop = true;
            this.rd56Up.Text = "Từ 56 tuổi trở lên";
            this.rd56Up.UseVisualStyleBackColor = true;
            // 
            // rd1855
            // 
            this.rd1855.AutoSize = true;
            this.rd1855.Location = new System.Drawing.Point(148, 109);
            this.rd1855.Name = "rd1855";
            this.rd1855.Size = new System.Drawing.Size(141, 21);
            this.rd1855.TabIndex = 10;
            this.rd1855.TabStop = true;
            this.rd1855.Text = "Từ 18 đến 55 tuổi";
            this.rd1855.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(39, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Loại độc giả";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(533, 66);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(200, 22);
            this.txtbEmail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(433, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // txtbDiaChi
            // 
            this.txtbDiaChi.Location = new System.Drawing.Point(137, 66);
            this.txtbDiaChi.Name = "txtbDiaChi";
            this.txtbDiaChi.Size = new System.Drawing.Size(202, 22);
            this.txtbDiaChi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(39, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa chỉ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(533, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnTaoThe
            // 
            this.btnTaoThe.Location = new System.Drawing.Point(585, 269);
            this.btnTaoThe.Name = "btnTaoThe";
            this.btnTaoThe.Size = new System.Drawing.Size(95, 32);
            this.btnTaoThe.TabIndex = 5;
            this.btnTaoThe.Text = "Tạo thẻ";
            this.btnTaoThe.UseVisualStyleBackColor = true;
            this.btnTaoThe.Click += new System.EventHandler(this.btnTaoThe_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTaoThe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Thẻ độc giả";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTenDG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbNgapLap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rd56Up;
        private System.Windows.Forms.RadioButton rd1855;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnTaoThe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}