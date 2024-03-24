namespace BaiTapLonQuanLiBanHang
{
    partial class NhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewdsnv = new System.Windows.Forms.DataGridView();
            this.txbPhuCap = new System.Windows.Forms.TextBox();
            this.txbLCB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpkNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.cbxDiaChi = new System.Windows.Forms.ComboBox();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdsnv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txbPhuCap);
            this.panel1.Controls.Add(this.txbLCB);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dtpkNgayVaoLam);
            this.panel1.Controls.Add(this.dtpkNgaySinh);
            this.panel1.Controls.Add(this.txbSDT);
            this.panel1.Controls.Add(this.cbxDiaChi);
            this.panel1.Controls.Add(this.txbTen);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 698);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewdsnv);
            this.groupBox1.Location = new System.Drawing.Point(3, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 374);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // dataGridViewdsnv
            // 
            this.dataGridViewdsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdsnv.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewdsnv.Name = "dataGridViewdsnv";
            this.dataGridViewdsnv.RowHeadersWidth = 62;
            this.dataGridViewdsnv.RowTemplate.Height = 28;
            this.dataGridViewdsnv.Size = new System.Drawing.Size(981, 340);
            this.dataGridViewdsnv.TabIndex = 0;
            this.dataGridViewdsnv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewdsnv_CellClick);
            this.dataGridViewdsnv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewdsnv_CellContentClick);
            // 
            // txbPhuCap
            // 
            this.txbPhuCap.Location = new System.Drawing.Point(645, 226);
            this.txbPhuCap.Multiline = true;
            this.txbPhuCap.Name = "txbPhuCap";
            this.txbPhuCap.Size = new System.Drawing.Size(261, 32);
            this.txbPhuCap.TabIndex = 18;
            this.txbPhuCap.Validating += new System.ComponentModel.CancelEventHandler(this.txbPhuCap_Validating);
            // 
            // txbLCB
            // 
            this.txbLCB.Location = new System.Drawing.Point(645, 168);
            this.txbLCB.Multiline = true;
            this.txbLCB.Name = "txbLCB";
            this.txbLCB.Size = new System.Drawing.Size(261, 32);
            this.txbLCB.TabIndex = 17;
            this.txbLCB.Validating += new System.ComponentModel.CancelEventHandler(this.txbLCB_Validating);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 47);
            this.button2.TabIndex = 15;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpkNgayVaoLam
            // 
            this.dtpkNgayVaoLam.Location = new System.Drawing.Point(645, 116);
            this.dtpkNgayVaoLam.Name = "dtpkNgayVaoLam";
            this.dtpkNgayVaoLam.Size = new System.Drawing.Size(200, 26);
            this.dtpkNgayVaoLam.TabIndex = 16;
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.Location = new System.Drawing.Point(645, 59);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(200, 26);
            this.dtpkNgaySinh.TabIndex = 15;
            this.dtpkNgaySinh.Value = new System.DateTime(2024, 3, 12, 10, 32, 32, 0);
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(126, 156);
            this.txbSDT.Multiline = true;
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(261, 32);
            this.txbSDT.TabIndex = 14;
            this.txbSDT.Validating += new System.ComponentModel.CancelEventHandler(this.txbSDT_Validating);
            // 
            // cbxDiaChi
            // 
            this.cbxDiaChi.FormattingEnabled = true;
            this.cbxDiaChi.Items.AddRange(new object[] {
            "Hà Nội",
            "Hồ Chí Minh",
            "Hải Phòng",
            "Đà Nẵng",
            "Cần Thơ",
            "Hải Dương",
            "Hà Giang",
            "Cao Bằng",
            "Lai Châu",
            "Lào Cai",
            "Tuyên Quang",
            "Yên Bái",
            "Thái Nguyên",
            "Phú Thọ",
            "Bắc Kạn",
            "Lạng Sơn",
            "Quảng Ninh",
            "Bắc Giang",
            "Bắc Ninh",
            "Hòa Bình",
            "Hà Nam",
            "Hưng Yên",
            "Thái Bình",
            "Vĩnh Phúc",
            "Nam Định",
            "Ninh Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Bình Định",
            "Phú Yên",
            "Khánh Hòa",
            "Ninh Thuận",
            "Bình Thuận",
            "Kon Tum",
            "Gia Lai",
            "Đắk Lắk",
            "Đắk Nông",
            "Lâm Đồng",
            "Bình Phước",
            "Bình Dương",
            "Đồng Nai",
            "Tây Ninh",
            "Long An",
            "Đồng Tháp",
            "Tiền Giang",
            "An Giang",
            "Bến Tre",
            "Vĩnh Long",
            "Trà Vinh",
            "Hậu Giang",
            "Kiên Giang",
            "Sóc Trăng",
            "Bạc Liêu",
            "Cà Mau",
            "Thanh Hóa",
            "Nghệ An",
            "Hà Tĩnh",
            "Quảng Bình",
            "Quảng Trị",
            "Thừa Thiên Huế",
            "Bà Rịa - Vũng Tàu",
            "Sơn La",
            "Điện Biên"});
            this.cbxDiaChi.Location = new System.Drawing.Point(126, 108);
            this.cbxDiaChi.Name = "cbxDiaChi";
            this.cbxDiaChi.Size = new System.Drawing.Size(261, 28);
            this.cbxDiaChi.TabIndex = 13;
            this.cbxDiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.cbxDiaChi_Validating);
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(126, 47);
            this.txbTen.Multiline = true;
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(261, 32);
            this.txbTen.TabIndex = 10;
            this.txbTen.Validating += new System.ComponentModel.CancelEventHandler(this.txbTen_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tên ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phụ cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lương cơ bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày vào làm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 755);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 747);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 61);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(469, 753);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 55);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(891, 755);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 53);
            this.button3.TabIndex = 11;
            this.button3.Text = "In";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(240, 753);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 55);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 858);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnXoa);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load_1);
            this.TextChanged += new System.EventHandler(this.NhanVien_TextChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdsnv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.ComboBox cbxDiaChi;
        private System.Windows.Forms.DateTimePicker dtpkNgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.TextBox txbPhuCap;
        private System.Windows.Forms.TextBox txbLCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewdsnv;
        private System.Windows.Forms.Button btnSua;
    }
}