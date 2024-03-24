namespace BaiTapLonQuanLiBanHang
{
    partial class NhaCungCap
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
            this.dtgDanhSachNhaCungCap = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txbDienThoai = new System.Windows.Forms.TextBox();
            this.cbxDiaChi = new System.Windows.Forms.ComboBox();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.txbNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbNCC);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txbDienThoai);
            this.panel1.Controls.Add(this.cbxDiaChi);
            this.panel1.Controls.Add(this.txbTen);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 721);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgDanhSachNhaCungCap);
            this.groupBox1.Location = new System.Drawing.Point(0, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 348);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhà cung cấp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtgDanhSachNhaCungCap
            // 
            this.dtgDanhSachNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachNhaCungCap.Location = new System.Drawing.Point(0, 25);
            this.dtgDanhSachNhaCungCap.Name = "dtgDanhSachNhaCungCap";
            this.dtgDanhSachNhaCungCap.RowHeadersWidth = 62;
            this.dtgDanhSachNhaCungCap.RowTemplate.Height = 28;
            this.dtgDanhSachNhaCungCap.Size = new System.Drawing.Size(1075, 299);
            this.dtgDanhSachNhaCungCap.TabIndex = 0;
            this.dtgDanhSachNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachNhaCungCap_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 60);
            this.button1.TabIndex = 14;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(225, 575);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 60);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(412, 577);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 56);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(818, 579);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 56);
            this.button3.TabIndex = 11;
            this.button3.Text = "In";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txbDienThoai
            // 
            this.txbDienThoai.Location = new System.Drawing.Point(591, 69);
            this.txbDienThoai.Multiline = true;
            this.txbDienThoai.Name = "txbDienThoai";
            this.txbDienThoai.Size = new System.Drawing.Size(261, 32);
            this.txbDienThoai.TabIndex = 14;
            this.txbDienThoai.Validating += new System.ComponentModel.CancelEventHandler(this.txbDienThoai_Validating);
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
            this.cbxDiaChi.Location = new System.Drawing.Point(591, 144);
            this.cbxDiaChi.Name = "cbxDiaChi";
            this.cbxDiaChi.Size = new System.Drawing.Size(119, 28);
            this.cbxDiaChi.TabIndex = 13;
            this.cbxDiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.cbxDiaChi_Validating);
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(145, 149);
            this.txbTen.Multiline = true;
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(261, 32);
            this.txbTen.TabIndex = 10;
            this.txbTen.Validating += new System.ComponentModel.CancelEventHandler(this.txbTen_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tên NCC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điện thoại";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(599, 579);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 56);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txbNCC
            // 
            this.txbNCC.Location = new System.Drawing.Point(145, 81);
            this.txbNCC.Multiline = true;
            this.txbNCC.Name = "txbNCC";
            this.txbNCC.Size = new System.Drawing.Size(261, 32);
            this.txbNCC.TabIndex = 21;
            this.txbNCC.Validating += new System.ComponentModel.CancelEventHandler(this.txbNCC_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ma NCC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 734);
            this.Controls.Add(this.panel1);
            this.Name = "NhaCungCap";
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachNhaCungCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgDanhSachNhaCungCap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txbDienThoai;
        private System.Windows.Forms.ComboBox cbxDiaChi;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNCC;
    }
}