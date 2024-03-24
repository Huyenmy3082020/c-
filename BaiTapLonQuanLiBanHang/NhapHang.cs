using BaiTapLonQuanLiBanHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonQuanLiBanHang
{
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            LoadTenLoaiHang();
            LoadTenMatHang();
            LoadTenNhaCungCap();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbxTenLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void LoadTenLoaiHang()
        {
            cbxTenLoaiHang.DataSource = LoaihangDAO.Instance.dsLoaiHang();
            cbxTenLoaiHang.DisplayMember = "tenLh";
        }
        void LoadTenMatHang()
        {
            cbxTenMatHang.DataSource = MatHangDAO.Instance.dsMathang();
            cbxTenMatHang.DisplayMember = "tenHang";
        }
        void LoadTenNhaCungCap()
        {
            cbxTenNhaCC.DataSource = NhaCungCapDAO.Instance.DanhSachNhaCungCap();
            cbxTenNhaCC.DisplayMember = "ten";


        }
    }
}
