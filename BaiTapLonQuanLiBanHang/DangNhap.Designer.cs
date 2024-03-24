namespace BaiTapLonQuanLiBanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbtenMatKhau = new System.Windows.Forms.TextBox();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbDangKiTaiKhoan = new System.Windows.Forms.Label();
            this.cbxMatKhau = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxMatKhau);
            this.panel1.Controls.Add(this.txbtenMatKhau);
            this.panel1.Controls.Add(this.txbTenDangNhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbDangKiTaiKhoan);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 341);
            this.panel1.TabIndex = 1;
            // 
            // txbtenMatKhau
            // 
            this.txbtenMatKhau.Location = new System.Drawing.Point(219, 155);
            this.txbtenMatKhau.Multiline = true;
            this.txbtenMatKhau.Name = "txbtenMatKhau";
            this.txbtenMatKhau.PasswordChar = '*';
            this.txbtenMatKhau.Size = new System.Drawing.Size(278, 32);
            this.txbtenMatKhau.TabIndex = 7;
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(218, 105);
            this.txbTenDangNhap.Multiline = true;
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(278, 32);
            this.txbTenDangNhap.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(50, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(49, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Đăng kí";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbDangKiTaiKhoan
            // 
            this.lbDangKiTaiKhoan.AutoSize = true;
            this.lbDangKiTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDangKiTaiKhoan.Location = new System.Drawing.Point(190, 26);
            this.lbDangKiTaiKhoan.Name = "lbDangKiTaiKhoan";
            this.lbDangKiTaiKhoan.Size = new System.Drawing.Size(309, 37);
            this.lbDangKiTaiKhoan.TabIndex = 0;
            this.lbDangKiTaiKhoan.Text = "Đăng nhập hệ thống";
            // 
            // cbxMatKhau
            // 
            this.cbxMatKhau.AutoSize = true;
            this.cbxMatKhau.Location = new System.Drawing.Point(221, 205);
            this.cbxMatKhau.Name = "cbxMatKhau";
            this.cbxMatKhau.Size = new System.Drawing.Size(138, 24);
            this.cbxMatKhau.TabIndex = 8;
            this.cbxMatKhau.Text = "Hiện mật khẩu";
            this.cbxMatKhau.UseVisualStyleBackColor = true;
            this.cbxMatKhau.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 365);
            this.Controls.Add(this.panel1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbtenMatKhau;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbDangKiTaiKhoan;
        private System.Windows.Forms.CheckBox cbxMatKhau;
    }
}