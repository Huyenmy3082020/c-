namespace BaiTapLonQuanLiBanHang
{
    partial class LoaiHang
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgDanhSachLoaiHang = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txbTenLH = new System.Windows.Forms.TextBox();
            this.TênMaLH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachLoaiHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txbTenLH);
            this.panel1.Controls.Add(this.TênMaLH);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 734);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 605);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 55);
            this.button2.TabIndex = 20;
            this.button2.Text = "Làm Mới";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgDanhSachLoaiHang);
            this.groupBox1.Location = new System.Drawing.Point(0, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 371);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách loại hàng";
            // 
            // dtgDanhSachLoaiHang
            // 
            this.dtgDanhSachLoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachLoaiHang.Location = new System.Drawing.Point(6, 25);
            this.dtgDanhSachLoaiHang.Name = "dtgDanhSachLoaiHang";
            this.dtgDanhSachLoaiHang.RowHeadersWidth = 62;
            this.dtgDanhSachLoaiHang.RowTemplate.Height = 28;
            this.dtgDanhSachLoaiHang.Size = new System.Drawing.Size(961, 335);
            this.dtgDanhSachLoaiHang.TabIndex = 0;
            this.dtgDanhSachLoaiHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachLoaiHang_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(379, 606);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 55);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = " Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(34, 605);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 55);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(193, 605);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 55);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(725, 607);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 52);
            this.button3.TabIndex = 11;
            this.button3.Text = "In";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txbTenLH
            // 
            this.txbTenLH.Location = new System.Drawing.Point(591, 69);
            this.txbTenLH.Multiline = true;
            this.txbTenLH.Name = "txbTenLH";
            this.txbTenLH.Size = new System.Drawing.Size(261, 32);
            this.txbTenLH.TabIndex = 14;
            this.txbTenLH.Validating += new System.ComponentModel.CancelEventHandler(this.txbTenLH_Validating);
            // 
            // TênMaLH
            // 
            this.TênMaLH.Location = new System.Drawing.Point(111, 69);
            this.TênMaLH.Multiline = true;
            this.TênMaLH.Name = "TênMaLH";
            this.TênMaLH.Size = new System.Drawing.Size(261, 32);
            this.TênMaLH.TabIndex = 10;
            this.TênMaLH.Validating += new System.ComponentModel.CancelEventHandler(this.TênMaLH_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mã LH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên LH";
            // 
            // LoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 684);
            this.Controls.Add(this.panel1);
            this.Name = "LoaiHang";
            this.Text = "LoaiHang";
            this.Load += new System.EventHandler(this.LoaiHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachLoaiHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgDanhSachLoaiHang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txbTenLH;
        private System.Windows.Forms.TextBox TênMaLH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}