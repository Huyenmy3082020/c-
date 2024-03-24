namespace BaiTapLonQuanLiBanHang
{
    partial class NhapHang
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
            this.txbSoLuongNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachNhaCungCap = new System.Windows.Forms.DataGridView();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTenLoaiHang = new System.Windows.Forms.ComboBox();
            this.cbxTenNhaCC = new System.Windows.Forms.ComboBox();
            this.cbxTenMatHang = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxTenNhaCC);
            this.panel1.Controls.Add(this.cbxTenMatHang);
            this.panel1.Controls.Add(this.cbxTenLoaiHang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbSoLuongNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txbTen);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 637);
            this.panel1.TabIndex = 3;
            // 
            // txbSoLuongNhap
            // 
            this.txbSoLuongNhap.Location = new System.Drawing.Point(580, 173);
            this.txbSoLuongNhap.Multiline = true;
            this.txbSoLuongNhap.Name = "txbSoLuongNhap";
            this.txbSoLuongNhap.Size = new System.Drawing.Size(261, 32);
            this.txbSoLuongNhap.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tên mặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Số lượng nhập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(594, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 26);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDanhSachNhaCungCap);
            this.groupBox1.Location = new System.Drawing.Point(3, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 374);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhà cung cấp";
            // 
            // dtgvDanhSachNhaCungCap
            // 
            this.dtgvDanhSachNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachNhaCungCap.Location = new System.Drawing.Point(-3, 25);
            this.dtgvDanhSachNhaCungCap.Name = "dtgvDanhSachNhaCungCap";
            this.dtgvDanhSachNhaCungCap.RowHeadersWidth = 62;
            this.dtgvDanhSachNhaCungCap.RowTemplate.Height = 28;
            this.dtgvDanhSachNhaCungCap.Size = new System.Drawing.Size(1070, 335);
            this.dtgvDanhSachNhaCungCap.TabIndex = 0;
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(594, 25);
            this.txbTen.Multiline = true;
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(261, 32);
            this.txbTen.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Giá nhập";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày nhập hàng";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(801, 662);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(116, 49);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 656);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 53);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(408, 655);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 54);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(585, 656);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(111, 55);
            this.btnIn.TabIndex = 11;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tên loại hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tên nhà CC";
            // 
            // cbxTenLoaiHang
            // 
            this.cbxTenLoaiHang.FormattingEnabled = true;
            this.cbxTenLoaiHang.Location = new System.Drawing.Point(155, 25);
            this.cbxTenLoaiHang.Name = "cbxTenLoaiHang";
            this.cbxTenLoaiHang.Size = new System.Drawing.Size(232, 28);
            this.cbxTenLoaiHang.TabIndex = 28;
            this.cbxTenLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cbxTenLoaiHang_SelectedIndexChanged);
            // 
            // cbxTenNhaCC
            // 
            this.cbxTenNhaCC.FormattingEnabled = true;
            this.cbxTenNhaCC.Location = new System.Drawing.Point(155, 101);
            this.cbxTenNhaCC.Name = "cbxTenNhaCC";
            this.cbxTenNhaCC.Size = new System.Drawing.Size(232, 28);
            this.cbxTenNhaCC.TabIndex = 30;
            // 
            // cbxTenMatHang
            // 
            this.cbxTenMatHang.FormattingEnabled = true;
            this.cbxTenMatHang.Location = new System.Drawing.Point(155, 173);
            this.cbxTenMatHang.Name = "cbxTenMatHang";
            this.cbxTenMatHang.Size = new System.Drawing.Size(232, 28);
            this.cbxTenMatHang.TabIndex = 29;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(213, 655);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 54);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 804);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXoa);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachNhaCungCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDanhSachNhaCungCap;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbSoLuongNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTenNhaCC;
        private System.Windows.Forms.ComboBox cbxTenMatHang;
        private System.Windows.Forms.ComboBox cbxTenLoaiHang;
        private System.Windows.Forms.Button btnSua;
    }
}